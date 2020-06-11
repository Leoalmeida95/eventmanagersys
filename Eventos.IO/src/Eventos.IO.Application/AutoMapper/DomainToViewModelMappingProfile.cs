using AutoMapper;
using Eventos.IO.Domain.Eventos;
using Eventos.IO.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using Eventos.IO.Domain.Organizadores;

namespace Eventos.IO.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Evento, EventoViewModel>();
            CreateMap<Endereco, EnderecoViewModel>();
            CreateMap<Categoria, CatagoriaViewModel>();
            CreateMap<Organizador, OrganizadorViewModel>();
        }
    }
}
