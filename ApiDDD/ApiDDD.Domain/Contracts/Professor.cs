using System;
using System.Collections.Generic;
using System.Text;

namespace ApiDDD.Domain.Contracts
{
    public class Professor
    {
        #region Propriedades
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Cpf { get; set; }
      
        #endregion
    }
}
