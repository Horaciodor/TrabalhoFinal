using AutoMapper;
using FilMax.Entidade;
using FilMax.Repositorio;
using FilMax.Services;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilMax.Aplicação
{
    public class TsukiService
    {
        public TsukiRepository _repository { get; set; }
        public readonly IMapper _mapper;

        public TsukiService(IMapper mapper, IConfiguration configuration)
        {
            _repository = new TsukiRepository(configuration);
            _mapper = mapper;
        }

        public void Adicionar(Mangas manga)
        {
            _repository.AdicionarManga(manga);
        }

        public void Remover(int id)
        {
            _repository.Remover(id);
        }

        public List<Mangas> Listar()
        {
            return _repository.Lista();
        }

        public void Editar(Mangas m)
        {
            _repository.Editar(m);
        }
    }  
}
