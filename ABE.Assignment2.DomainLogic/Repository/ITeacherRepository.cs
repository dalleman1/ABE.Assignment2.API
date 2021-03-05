﻿using ABE.Assignment2.DomainLogic.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ABE.Assignment2.DomainLogic.Repository
{
    public interface ITeacherRepository
    {
        List<Teacher> GetAllTeachers();
        Teacher GetTeacherById(int id);
        Course GetCourseByTeacher(int id);
    }
}
