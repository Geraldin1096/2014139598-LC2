using _2014139598_ENT.Entities;
using _2014139598_ENT.Entities.EntitiesDTO;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace LineaTelefonica.WebAPI.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Cliente, ClienteDTO>();
            CreateMap<ClienteDTO, Cliente>();

            CreateMap<Trabajador, TrabajadorDTO>();
            CreateMap<TrabajadorDTO, Trabajador>();

            CreateMap<AdministradorEquipo, AdministradorEquipoDTO>();
            CreateMap<AdministradorEquipoDTO, AdministradorEquipo>();

            CreateMap<AdministrarLinea, AdministrarLineaDTO>();
            CreateMap<AdministrarLineaDTO, AdministrarLinea>();

            CreateMap<CentroAtencion, CentroAtencionDTO>();
            CreateMap<CentroAtencionDTO, CentroAtencion>();

            CreateMap<Contrato, ContratoDTO>();
            CreateMap<ContratoDTO, Contrato>();

            CreateMap<Departamento, DepartamentoDTO>();
            CreateMap<DepartamentoDTO, Departamento>();

        }
    }
}