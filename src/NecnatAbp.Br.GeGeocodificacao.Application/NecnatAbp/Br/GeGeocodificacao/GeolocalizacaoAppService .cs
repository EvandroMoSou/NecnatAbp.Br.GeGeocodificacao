﻿using NecnatAbp.AppServices;
using NecnatAbp.Br.GeGeocodificacao.DmGoogleGeocoding;
using NecnatAbp.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Dtos;

namespace NecnatAbp.Br.GeGeocodificacao
{
    public class GeolocalizacaoAppService :
        CrudsAppService<
            Geolocalizacao, //The Geolocalizacao entity
            GeolocalizacaoDto, //Used to show Geolocalizacaos
            Guid, //Primary key of the Geolocalizacao entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateGeolocalizacaoDto, //Used to create/update a Geolocalizacao
            GeolocalizacaoResultRequestDto>,
        IGeolocalizacaoAppService //implement the IGeolocalizacaoAppService
    {
        protected IGeolocalizacaoRepository TypedRepository { get; }
        protected ILogradouroRepository LogradouroRepository { get; }
        protected IGoogleGeocodingRepository GoogleGeocodingRepository { get; }

        public GeolocalizacaoAppService(IGeolocalizacaoRepository repository, ILogradouroRepository logradouroRepository, IGoogleGeocodingRepository googleGeocodingRepository) : base(repository)
        {
            TypedRepository = repository;
            LogradouroRepository = logradouroRepository;
            GoogleGeocodingRepository = googleGeocodingRepository;
        }

        protected override async Task<IQueryable<Geolocalizacao>> CreateFilteredQuerySearchAsync(GeolocalizacaoResultRequestDto input)
        {
            var q = await ReadOnlyRepository.GetQueryableAsync();

            if (string.IsNullOrWhiteSpace(input.Cep))
                throw new UserFriendlyException("O filtro Cep é obrigatório para essa pesquisa.");

            input.Cep = input.Cep.OnlyDigits();
            if (input.Cep.Length != LogradouroConsts.MaxCepLength)
                throw new UserFriendlyException($"O filtro Cep deve conter {LogradouroConsts.MaxCepLength} caracteres numéricos.");

            q = q.Where(x => x.Logradouro!.Cep == int.Parse(input.Cep.OnlyDigits()));
            q = q.Where(x => x.Numero == input.Numero);

            if (input.Ativo != null)
                q = q.Where(x => x.Ativo == input.Ativo);

            return q;
        }

        public async Task<GeolocalizacaoDto?> GetByCepAndNumeroFallbackGoogleAsync(GeolocalizacaoFallbackResultRequestDto input)
        {
            if (string.IsNullOrWhiteSpace(input.Cep))
                throw new UserFriendlyException("O filtro Cep é obrigatório para essa pesquisa.");

            input.Cep = input.Cep.OnlyDigits();
            if (input.Cep.Length != LogradouroConsts.MaxCepLength)
                throw new UserFriendlyException($"O filtro Cep deve conter {LogradouroConsts.MaxCepLength} caracteres numéricos.");

            var l = new List<GeolocalizacaoDto>();
            var geolocalizacao = await TypedRepository.GetByCepAndNumeroWithLogradouroAsync(int.Parse(input.Cep), input.Numero);

            if (geolocalizacao == null)
            {
                var logradouro = await LogradouroRepository.GetByCepAsync(int.Parse(input.Cep));
                if (logradouro == null)
                    logradouro = await GoogleGeocodingRepository.GetLogradouroByCepAsync(input.Cep);
                if (logradouro == null)
                    return null;

                geolocalizacao = await GoogleGeocodingRepository.GetGeolocalizacaoByLogradouroAndNumeroAsync(logradouro, input.Numero);
            }

            if (geolocalizacao == null)
                return null;

            return MapToGetListOutputDto(geolocalizacao);
        }

        protected override GeolocalizacaoDto MapToGetListOutputDto(Geolocalizacao entity)
        {
            var dto = base.MapToGetListOutputDto(entity);
            if (entity.Logradouro != null)
                dto.Logradouro = ObjectMapper.Map<Logradouro, LogradouroDto>(entity.Logradouro);

            return dto;
        }
    }
}
