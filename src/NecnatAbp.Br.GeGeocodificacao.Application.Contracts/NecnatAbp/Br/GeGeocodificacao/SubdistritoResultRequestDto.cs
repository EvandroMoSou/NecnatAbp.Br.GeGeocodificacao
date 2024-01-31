﻿using NecnatAbp.Dtos;
using System;

namespace NecnatAbp.Br.GeGeocodificacao
{
    public class SubdistritoResultRequestDto : OptionalPagedAndSortedResultRequestDto
    {
        public string? GenericSearch { get; set; }
        public Guid? CidadeMunicipioId { get; set; }
        public Guid? BairroDistritoId { get; set; }
        public string? NomeContains { get; set; }
        public string? CodigoIbge { get; set; }
        public bool? Ativo { get; set; }
    }
}