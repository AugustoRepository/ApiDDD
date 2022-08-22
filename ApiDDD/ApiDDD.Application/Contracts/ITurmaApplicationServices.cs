using ApiDDD.Application.Models.Turma;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiDDD.Application.Contracts
{
    public interface ITurmaApplicationServices
    {
        void Inserir(TurmaCadastroModel model);
        void Alterar(TurmaEdicaoModel model);
        void Excluir(Guid id);

        List<TurmaConsultaModel> ObterTodos();

        TurmaConsultaModel ObterPorId(Guid id);
    }
}
