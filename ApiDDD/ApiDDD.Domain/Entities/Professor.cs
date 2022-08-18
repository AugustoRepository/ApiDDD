using System;
using System.Collections.Generic;
using System.Text;

namespace ApiDDD.Domain.Entities
{
    public class Professor
    {
        #region Propriedades
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }

        #endregion
        #region Relacionamentos
        public List<Turma> Turmas { get; set; }
        #endregion
    }
}
