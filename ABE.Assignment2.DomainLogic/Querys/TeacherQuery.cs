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

            Field<ListGraphType<TeacherType>>(
                name: "getAllTeachers", resolve: context =>
                {
                    return _teacherService.GetAllTeachers();
                });
        }
    }
}
