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
    public class ClienteAppService : IClienteAppService
    {
        //atributo
        private readonly IClienteDomainService domainService;

        //construtor para injeção de dependência
        public ClienteAppService(IClienteDomainService domainService)
        {
            this.domainService = domainService;
        }

        public void Cadastrar(ClienteCadastroViewModel model)
        {
            var cliente = Mapper.Map<Cliente>(model);
            domainService.Cadastrar(cliente);
        }

        public void Atualizar(ClienteEdicaoViewModel model)
        {
            var cliente = Mapper.Map<Cliente>(model);
            domainService.Atualizar(cliente);
        }

        public void Excluir(int idCliente)
        {
            domainService.Excluir(idCliente);
        }

        public List<ClienteConsultaViewModel> ConsultarTodos()
        {
            var lista = domainService.ConsultarTodos();
            var model = Mapper.Map<List<ClienteConsultaViewModel>>(lista);

            return model;
        }

        public ClienteConsultaViewModel ConsultarPorId(int idCliente)
        {
            var cliente = domainService.ConsultarPorId(idCliente);
            var model = Mapper.Map<ClienteConsultaViewModel>(cliente);

            return model;
        }
    }
}

