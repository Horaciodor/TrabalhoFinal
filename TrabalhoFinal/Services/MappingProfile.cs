using AutoMapper;
using FilMax.Entidade;
using FilMax.Entidade.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilMax.Services;

public class MappingProfile : Profile
{ 
   public MappingProfile()
   {
     CreateMap<AutorDTO, Autor>().ReverseMap();

   }
}