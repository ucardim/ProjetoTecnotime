using System;
using System.Collections.Generic;
using System.Text;
using Projeto.Application.ViewModels;

namespace Projeto.Application.Contracts
{
    public interface IClienteAppService
    {
        void Cadastrar(ClienteCadastroViewModel model);
        void Atualizar(ClienteEdicaoViewModel model);
        void Excluir(int idCliente);

        List<ClienteConsultaViewModel> ConsultarTodos();
        ClienteConsultaViewModel ConsultarPorId(int idCliente);
    }
}

