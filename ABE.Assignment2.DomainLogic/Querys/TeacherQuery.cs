using ABE.Assignment2.DomainLogic.Service;
using ABE.Assignment2.DomainLogic.Types;
using GraphQL;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace ABE.Assignment2.DomainLogic.Querys
{
    public class TeacherQuery : ObjectGraphType
    {
        private readonly ITeacherService _teacherService;
        public TeacherQuery(ITeacherService teacherService)
        {
            _teacherService = teacherService;
            int id = 0;

            Field<ListGraphType<TeacherType>>(
                name: "getAllTeachers", resolve: context =>
                {
                    return _teacherService.GetAllTeachers();
                });

            Field<TeacherType>(
                name: "teacher",
                arguments: new QueryArguments(new QueryArgument<IntGraphType> { Name = "id" }),
                resolve: context =>
                {
                    id = context.GetArgument<int>("id");
                    return _teacherService.GetTeacherById(id);
                }
                );

            Field<CourseType>(
                name: "course",
                arguments: new QueryArguments(new QueryArgument<IntGraphType> { Name = "id" }),
                resolve: context =>
                {
                    id = context.GetArgument<int>("id");
                    return _teacherService.GetCourseByTeacher(id);
                }
                );

        }
    }
}
