using System;
using System.Collections.Generic;
using System.Text;

namespace ApiDDD.Domain.Entities
{
    public class Turma
    {
        #region Propriedades
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Periodo { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataTermino { get; set; }
        public Guid IdProfessor { get; set; }
        #endregion
        #region Relacionamentos
        public Professor Professor { get; set; }
        public List<TurmaAluno> Alunos { get; set; }

        #endregion

    }
}
