using ApiDDD.Application.Models.Aluno;
using ApiDDD.Application.Models.Professor;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiDDD.Application.Models.Turma

{
    public class TurmaConsultaModel
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Periodo { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataTermino { get; set; }

        public ProfessorConsultaModel Professor { get; set; }
    }
}
