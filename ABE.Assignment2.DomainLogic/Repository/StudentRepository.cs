﻿using ABE.Assignment2.DomainLogic.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ABE.Assignment2.DomainLogic.Repository
{
    class StudentRepository
    {
        private List<Student> students = new List<Student>();
        private List<Course> courses = new List<Course>();
        private Teacher teacher = new Teacher();

        public StudentRepository()
        {
            Course course1 = new Course
            {
                Id = 001,
                Name = "AFP",
                Students = students,
                Teacher = teacher

            };

            Teacher teacher1 = new Teacher
            {
                Id = 1,
                FirstName ="Henrik",
                LastName="Kirk",
                Course = course1
            };
            Student student1 = new Student
            {
                Id = 101,
                FirstName = "Oskar",
                LastName ="Vedel",
                Courses = courses
            };

            students.Add(student1);
            teacher = teacher1;
            courses.Add(course1);
        }

    }
}
