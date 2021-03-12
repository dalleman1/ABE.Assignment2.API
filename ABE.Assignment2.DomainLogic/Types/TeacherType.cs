using ABE.Assignment2.DomainLogic.Models;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace ABE.Assignment2.DomainLogic.Types
{
    public class TeacherType : ObjectGraphType<Teacher>
    {
        public TeacherType()
        {
            Name = "Teacher";
            Field(_ => _.Id).Description("Teacher's Id.");
            Field(_ => _.FirstName).Description
            ("First name of the Teacher");
            Field(_ => _.LastName).Description
            ("Last name of the Teacher");
        }
    }
}
