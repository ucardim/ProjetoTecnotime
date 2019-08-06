using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Projeto.Application.Contracts;
using Projeto.Application.ViewModels;
using Projeto.Domain.Contracts.Services;
using Projeto.Domain.Entities;

namespace Projeto.Application.Services
{
    public class ProdutoAppService : IProdutoAppService
    {
        //atributo
        private readonly IProdutoDomainService domainService;

        //construtor para injeção de dependência
        public ProdutoAppService(IProdutoDomainService domainService)
        {
            this.domainService = domainService;
        }

        public void Cadastrar(ProdutoCadastroViewModel model)
        {
            var produto = Mapper.Map<Produto>(model);
            domainService.Cadastrar(produto);
        }

        public void Atualizar(ProdutoEdicaoViewModel model)
        {
            var produto = Mapper.Map<Produto>(model);
            domainService.Atualizar(produto);
        }

        public void Excluir(int idProduto)
        {
            domainService.Excluir(idProduto);
        }

        public List<ProdutoConsultaViewModel> ConsultarTodos()
        {
            var lista = domainService.ConsultarTodos();
            var model = Mapper.Map<List<ProdutoConsultaViewModel>>(lista);

            return model;
        }

        public ProdutoConsultaViewModel ConsultarPorId(int idProduto)
        {
            var produto = domainService.ConsultarPorId(idProduto);
            var model = Mapper.Map<ProdutoConsultaViewModel>(produto);

            return model;
        }
    }
}
