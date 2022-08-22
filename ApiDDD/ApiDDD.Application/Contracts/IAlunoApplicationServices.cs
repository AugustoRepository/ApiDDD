using ApiDDD.Application.Models.Aluno;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiDDD.Application.Contracts
{
    public interface IAlunoApplicationServices
    {
        void Inserir(AlunoCadastroModel model);
        void Alterar(AlunoEdicaoModel model);
        void Excluir(Guid id);

        List<AlunoConsultaModel> ObterTodos();

        AlunoConsultaModel ObterPorId(Guid id);
    }
}
