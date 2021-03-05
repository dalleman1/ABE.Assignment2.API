using ABE.Assignment2.DomainLogic.Models;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace ABE.Assignment2.DomainLogic.Types
{
    public class CourseType : ObjectGraphType<Course>
    {
        public CourseType()
        {
            Name = "Course";
            Field(_ => _.Id).Description("Course's Id.");
            Field(_ => _.Name).Description
            ("Name of the course");
            Field(_ => _.Teacher).Description
            ("The courses teacher");
            Field(_ => _.Students).Description
            ("The students enrolled in the course");
        }
    }
}
