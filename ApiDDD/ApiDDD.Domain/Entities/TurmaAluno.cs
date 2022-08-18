using System;
using System.Collections.Generic;
using System.Text;

namespace ApiDDD.Domain.Entities
{
    public class TurmaAluno
    {
        #region Propriedades
        public Guid IdTurma { get; set; }
        public Guid IdAluno { get; set; }
        #endregion

        #region Relacionamentos
        public Turma Turma { get; set; }
        public Aluno Aluno { get; set; }
        #endregion
    }
}
