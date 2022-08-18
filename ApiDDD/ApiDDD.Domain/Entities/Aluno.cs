using System;
using System.Collections.Generic;
using System.Text;

namespace ApiDDD.Domain.Entities
{
    public class Aluno
    {
        #region Propriedades
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Matricula { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        #endregion

        #region Relacionamentos
        public List<TurmaAluno> Turmas { get; set; }
        #endregion
    }
}
