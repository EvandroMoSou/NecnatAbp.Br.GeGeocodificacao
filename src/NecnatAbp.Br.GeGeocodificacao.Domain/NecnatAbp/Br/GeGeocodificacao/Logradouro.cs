using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace NecnatAbp.Br.GeGeocodificacao
{
    public class Logradouro : AuditedAggregateRoot<Guid>
    {
        public int Cep { get; set; }

        public string Nome { get; set; } = string.Empty;
        public string? NomeAbreviado { get; set; }
        public string? Complemento { get; set; }

        public Guid BairroDistritoId { get; set; }
        public BairroDistrito? BairroDistrito { get; set; }

        public Guid CidadeMunicipioId { get; set; }
        public CidadeMunicipio? CidadeMunicipio { get; set; }

        public UnidadeFederativa UnidadeFederativa { get; set; }

        public bool Ativo { get; set; }
        public int Origem { get; set; }
    }
}
