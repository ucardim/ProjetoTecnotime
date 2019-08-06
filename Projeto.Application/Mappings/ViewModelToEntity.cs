using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Projeto.Domain.Entities;
using Projeto.Application.ViewModels;

namespace Projeto.Application.Mappings
{
    public class ViewModelToEntity : Profile
    {
        //construtor
        public ViewModelToEntity()
        {
            #region Função

            CreateMap<ClienteCadastroViewModel, Cliente>();
            CreateMap<ClienteEdicaoViewModel, Cliente>();

            #endregion

            #region Produto

            CreateMap<ProdutoCadastroViewModel, Produto>();
            CreateMap<ProdutoEdicaoViewModel, Produto>();

            #endregion
        }
    }
}
