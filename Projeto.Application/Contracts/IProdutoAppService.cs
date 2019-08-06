using System;
using System.Collections.Generic;
using System.Text;
using Projeto.Application.ViewModels;

namespace Projeto.Application.Contracts
{
    public interface IProdutoAppService
    {
        void Cadastrar(ProdutoCadastroViewModel model);
        void Atualizar(ProdutoEdicaoViewModel model);
        void Excluir(int idProduto);

        List<ProdutoConsultaViewModel> ConsultarTodos();
        ProdutoConsultaViewModel ConsultarPorId(int idProduto);
    }
}
