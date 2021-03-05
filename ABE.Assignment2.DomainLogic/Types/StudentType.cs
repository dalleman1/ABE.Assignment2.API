using ABE.Assignment2.DomainLogic.Models;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace ABE.Assignment2.DomainLogic.Types
{
    public class StudentType : ObjectGraphType<Student>
    {
        public StudentType()
        {
            Name = "Student";
            Field(_ => _.Id).Description("The student's Id.");
            Field(_ => _.FirstName).Description
            ("First name of the Student");
            Field(_ => _.LastName).Description
            ("Last name of the Student");
            Field(_ => _.Courses).Description
            ("The courses the student is enrolled in");
        }
    }
}
