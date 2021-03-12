using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace ABE.Assignment2.DomainLogic.Types
{
    public class TeacherInputType : InputObjectGraphType
    {
        public TeacherInputType()
        {
            Name = "teacherInput";
            Field<NonNullGraphType<StringGraphType>>("FirstName");
            Field<NonNullGraphType<StringGraphType>>("LastName");
        }
    }
}
