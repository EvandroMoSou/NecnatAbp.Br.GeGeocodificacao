﻿using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace NecnatAbp.Br.GeGeocodificacao
{
    public class Geolocalizacao : AuditedAggregateRoot<Guid>
    {
        public Guid LogradouroId { get; set; }
        public Logradouro? Logradouro { get; set; }
        public int? Numero { get; set; }
        public decimal? Latitude { get; set; }
        public decimal? Longitude { get; set; }
        public bool Ativo { get; set; }
        public int Origem { get; set; }
    }
}
