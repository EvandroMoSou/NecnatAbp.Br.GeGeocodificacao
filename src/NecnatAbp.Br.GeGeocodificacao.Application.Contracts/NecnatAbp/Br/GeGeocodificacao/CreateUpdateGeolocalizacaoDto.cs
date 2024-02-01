﻿using NecnatAbp.Dtos;
using System;
using System.ComponentModel.DataAnnotations;

namespace NecnatAbp.Br.GeGeocodificacao
{
    public class CreateUpdateGeolocalizacaoDto : ConcurrencyDto
    {
        [Required]
        public Guid LogradouroId { get; set; }

        public int? Numero { get; set; }

        [Required]
        public decimal Latitude { get; set; }

        [Required]
        public decimal Longitude { get; set; }

        [Required]
        public bool Ativo { get; set; }
    }
}