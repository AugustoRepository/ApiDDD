using System;
using System.Collections.Generic;
using System.Text;

namespace ApiDDD.Domain.Contracts
{
    public class Turma
    {
        #region Propriedades
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Periodo { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataTermino { get; set; }
        public Guid IdProfessor { get; set; }
        #endregion
    }
}
