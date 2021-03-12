using ABE.Assignment2.DomainLogic.Models;
using ABE.Assignment2.DomainLogic.Service;
using ABE.Assignment2.DomainLogic.Types;
using GraphQL;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace ABE.Assignment2.DomainLogic.Querys
{
    public class TeacherMutation : ObjectGraphType
    {
        private readonly ITeacherService _teacherService;
        public TeacherMutation(ITeacherService teacherService)
        {
            _teacherService = teacherService;

            Field<TeacherType>(
                "AddTeacher",
                arguments: new QueryArguments(new QueryArgument<NonNullGraphType<TeacherInputType>> { Name = "teacher" }),
                resolve: context =>
                {
                    var teacher = context.GetArgument<Teacher>("teacher");
                    return _teacherService.AddTeacherAsync(teacher);
                });
        }
    }
}
