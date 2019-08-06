using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Projeto.Domain.Entities;
using Projeto.Application.ViewModels;

namespace Projeto.Application.Mappings
{
    public class EntityToViewModel : Profile
    {
        //construtor
        public EntityToViewModel()
        {
            #region Cliente

            CreateMap<Cliente, ClienteConsultaViewModel>();

            #endregion

            #region Produto

            CreateMap<Produto, ProdutoConsultaViewModel>();

            #endregion
        }
    }
}

