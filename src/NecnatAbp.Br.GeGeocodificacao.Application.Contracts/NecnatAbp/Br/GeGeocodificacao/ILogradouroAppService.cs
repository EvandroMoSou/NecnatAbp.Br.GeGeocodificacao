using NecnatAbp.AppServices;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace NecnatAbp.Br.GeGeocodificacao
{
    public interface ILogradouroAppService :
        ICrudsAppService< //Defines CRUD methods
            LogradouroDto, //Used to show Logradouros
            Guid, //Primary key of the Logradouro entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateLogradouroDto, //Used to create/update a Logradouro
            LogradouroResultRequestDto>
    {

    }
}
