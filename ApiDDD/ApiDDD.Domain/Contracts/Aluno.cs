using System;
using System.Collections.Generic;
using System.Text;

namespace ApiDDD.Domain.Contracts
{
    public class Aluno
    {
        #region Propriedades
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Matricula { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        #endregion
    }
}
