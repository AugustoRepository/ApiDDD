using ApiDDD.Application.Models.Professor;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiDDD.Application.Contracts
{
    public interface IProfessorApplicationServices
    {
        void Inserir(ProfessorCadastroModel model);
        void Alterar(ProfessorEdicaoModel model);
        void Excluir(Guid id);

        List<ProfessorConsultaModel> ObterTodos();

        ProfessorConsultaModel ObterPorId(Guid id);
    }
}
