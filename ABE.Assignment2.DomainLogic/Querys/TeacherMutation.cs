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

            Field<StringGraphType>(
                "DeleteTeacher",
                arguments: new QueryArguments(new QueryArgument<NonNullGraphType<IdGraphType>> { Name = "teacherId" }),
                resolve: context =>
                {
                    var teacherId = context.GetArgument<int>("teacherId");
                    var teacher = _teacherService.GetById(teacherId).Result;
                    if (teacher == null)
                    {
                        context.Errors.Add(new ExecutionError("Could not find teacher"));
                        return null;
                    }
                    _teacherService.DeleteTeacher(teacher);
                    return $"The Teacher with the id: {teacherId} has been successfully deleted.";
                });

             Field<TeacherType>(
                "updateTeacher",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<TeacherInputType>> { Name = "teacher" },
                    new QueryArgument<NonNullGraphType<IdGraphType>> { Name = "teacherId" }),
                resolve: context =>
                {
                    var NewTeacher = context.GetArgument<Teacher>("teacher");
                    var teacherId = context.GetArgument<int>("teacherId");
                    var currentTeacher = _teacherService.GetById(teacherId).Result;
                    if (currentTeacher == null)
                    {
                        context.Errors.Add(new ExecutionError("Couldn't find teacher."));
                        return null;
                    }
                    return _teacherService.UpdateAsync(currentTeacher, NewTeacher);
                }
            );
        }
    }
}
