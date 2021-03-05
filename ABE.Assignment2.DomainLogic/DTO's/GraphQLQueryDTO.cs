using System;
using System.Collections.Generic;
using System.Text;

namespace ABE.Assignment2.DomainLogic.DTO_s
{
    public class GraphQLQueryDTO
    {
        public string OperationName { get; set; }
        public string NamedQuery { get; set; }
        public string Query { get; set; }
        public string Variables { get; set; }
    }
}
