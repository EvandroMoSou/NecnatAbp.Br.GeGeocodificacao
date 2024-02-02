using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace NecnatAbp.Br.GeGeocodificacao.Bases
{
    public abstract class EfCoreGeolocalizacaoRepositoryBase<TEfCoreDbContext, TBairroDistrito, TCidadeMunicipio, TGeolocalizacao, TLogradouro, TTipoLogradouro>
        : EfCoreRepository<TEfCoreDbContext, TGeolocalizacao, Guid>,
        IGeolocalizacaoRepositoryBase<TBairroDistrito, TCidadeMunicipio, TGeolocalizacao, TLogradouro, TTipoLogradouro>,
        IRepository<TGeolocalizacao, Guid>
        where TEfCoreDbContext : IGeolocalizacaoDbContext<TBairroDistrito, TCidadeMunicipio, TGeolocalizacao, TLogradouro, TTipoLogradouro>
        where TBairroDistrito : BairroDistritoBase<TCidadeMunicipio>
        where TCidadeMunicipio : CidadeMunicipioBase
        where TGeolocalizacao : GeolocalizacaoBase<TBairroDistrito, TCidadeMunicipio, TLogradouro, TTipoLogradouro>, new()
        where TLogradouro : LogradouroBase<TBairroDistrito, TCidadeMunicipio, TTipoLogradouro>
        where TTipoLogradouro : TipoLogradouroBase
    {
        public EfCoreGeolocalizacaoRepositoryBase(IDbContextProvider<TEfCoreDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }

        public async Task<TGeolocalizacao?> GetByCepAndNumeroWithLogradouroAsync(int cep, int? numero)
        {
            var dbSet = await GetDbSetAsync();
            return await dbSet.Include(x => x.Logradouro).Where(x => x.Logradouro!.Cep == cep && x.Numero == numero).FirstOrDefaultAsync();
        }

        public async Task<TGeolocalizacao?> GetByLogradouroIdAndNumeroAsync(Guid logradouroId, int? numero)
        {
            var dbSet = await GetDbSetAsync();
            return await dbSet.Where(x => x.LogradouroId == logradouroId && x.Numero == numero).FirstOrDefaultAsync();
        }

        public async Task<TGeolocalizacao> MaintainAsync(TGeolocalizacao e, bool autoSave = false)
        {
            var eDb = await GetByLogradouroIdAndNumeroAsync(e.LogradouroId, e.Numero);
            var isInsert = eDb == null;

            if (isInsert)
                eDb = new TGeolocalizacao();
            else if (EntityEquals(eDb!, e))
                return eDb!;

            eDb = EntityMap(e, eDb!);

            if (isInsert)
                return await InsertAsync(eDb, autoSave);
            else
                return await UpdateAsync(eDb, autoSave);
        }

        public virtual bool EntityEquals(TGeolocalizacao e, TGeolocalizacao eCompare)
        {
            return e!.LogradouroId == eCompare.LogradouroId
                && e.Numero == eCompare.Numero
                && e.Latitude == eCompare.Latitude
                && e.Longitude == eCompare.Longitude;
        }

        public virtual TGeolocalizacao EntityMap(TGeolocalizacao source, TGeolocalizacao destination)
        {
            destination.LogradouroId = source.LogradouroId;
            destination.Numero = source.Numero;
            destination.Latitude = source.Latitude;
            destination.Longitude = source.Longitude;
            destination.InAtivo = source.InAtivo;
            destination.Origem = source.Origem;

            return destination;
        }
    }
}
