﻿using NecnatAbp.Dtos;
using System;

namespace NecnatAbp.Br.GeGeocodificacao.Bases
{
    public class SubdistritoDtoBase : ConcurrencyAuditedEntityDto<Guid>
    {
        public Guid? BairroDistritoId { get; set; }
        public string? Nome { get; set; }
        public string? CodigoIbge { get; set; }
        public bool? InAtivo { get; set; }
    }
}
