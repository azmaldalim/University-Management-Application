using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace UniversityManagementSystemWebApplication.Models
{
    public class FixedData : DropCreateDatabaseIfModelChanges<UniversityDBContext>
    {
        protected override void Seed(UniversityDBContext context)
        {
            var semesters = new List<Semester>
                {
                    new Semester{Name = "1st"},
                    new Semester{Name = "2nd"},
                    new Semester{Name = "3rd"},
                    new Semester{Name = "4th"},
                    new Semester{Name = "5th"},
                    new Semester{Name = "6th"},
                    new Semester{Name = "7th"},
                    new Semester{Name = "8th"}
                };

            var designations = new List<Designation>
                {
                    new Designation{Name = "Chairman"},
                    new Designation{Name = "Department Head"},
                    new Designation{Name = "Senior"},
                    new Designation{Name = "Lecturer"}
                };

            new List<ClassRoom>
                {
                    new ClassRoom{RoomNo = "A-101"},
                    new ClassRoom{RoomNo = "B-102"},
                    new ClassRoom{RoomNo = "A-201"},
                    new ClassRoom{RoomNo = "C-202"},
                    new ClassRoom{RoomNo = "C-301"}
                }.ForEach(c => context.ClassRooms.Add(c));
            new List<GradeLetter>
                {
                    new GradeLetter{Name="A+"},
                    new GradeLetter{Name="A"},
                    new GradeLetter{Name="A-"},
                    new GradeLetter{Name="B+"},
                    new GradeLetter{Name="B"},
                    new GradeLetter{Name="B-"},
                    new GradeLetter{Name="C"},
                    new GradeLetter{Name="D"},
                    new GradeLetter{Name = "F"}
                }.ForEach(g =>context.GradeLetters.Add(g));

            var departments = new List<Department>
                {
                    new Department{Code = "CSE",Name = "Computer Science"},
                    new Department{Code = "EEE",Name = "Electrical. "},
                    new Department{Code = "BBA",Name = "Business"},
                    new Department{Code = "ETE",Name = "Electrical Tech."}
                };

            new List<Day>
                {
                    new Day{Name = "Saturday"},
                    new Day{Name = "Sunday"},
                    new Day{Name = "Monday"},
                    new Day{Name = "Tuesday"},
                    new Day{Name = "Wednesday"},
                    new Day{Name = "Thursday"},
                    new Day{Name = "Friday"}
                }.ForEach(d => context.Days.Add(d));
            new List<Course>
                {
                    new Course{Name = "Object Oriented Programming",Code ="OOP" ,Credit = 4, Department = departments[0], Semester = semesters[0],Description = "Good and nice course"},
                    new Course{Name = "Programming Language II",Code = "JAVA",Credit = 3,Department = departments[0], Semester = semesters[1],Description = "Good and nice course"},
                    new Course{Name = "Business in Business",Code ="Business" ,Credit = 3,Department = departments[2], Semester = semesters[2],Description = "Learn Business "},
                    new Course{Name = "Electrical Device",Code = "Device",Credit = 2,Department = departments[1], Semester = semesters[3], Description = "Play with device"},
                    new Course{Code = "ANet",Credit = 3,Name = "Advance Networking",Description = "Advance networking good",Department=departments[1],Semester = semesters[4]},
                    new Course{Code = "C++",Credit = 3,Name = "C Plus Plus",Description = "Cplusplus",Department=departments[1],Semester = semesters[5]},
                    new Course{Code = "Net",Credit = 3,Name = "Networking",Description = "Networking",Department=departments[1],Semester = semesters[6]},
                    new Course{Code = "Account",Credit = 3,Name = "Accounting",Description = "Accounting",Department=departments[2],Semester = semesters[7]}
                }.ForEach(c => context.Courses.Add(c));

            new List<Teacher>
                {
                    new Teacher{Name = "Kamrul Hasan Tomal", Address = "Bonani", CreditToBeTaken = 6, RemainingCredit = 6,Department = departments[0], ContractNo = 01673565,Email = "km@gmail.com",Designation = designations[0] },
                    new Teacher{Name = "Zohirul Alam Tiemoon", Address = "Shamoli", CreditToBeTaken = 6,RemainingCredit = 6,Department = departments[0],ContractNo = 016735565,Email = "tiemoon@gmail.com",Designation = designations[1] },
                    new Teacher{Name = "Md Nipun", Address = "Bonani", CreditToBeTaken = 6,RemainingCredit = 6,Department = departments[2],ContractNo = 01653565,Email = "n@gmail.com",Designation = designations[2] },
                    new Teacher{Name = "Asraful Hoque", Address = "Uttara", CreditToBeTaken = 6,RemainingCredit = 6,Department = departments[3],ContractNo = 0167453565,Email = "a@gmail.com",Designation = designations[3] }
                }.ForEach( t => context.Teachers.Add(t));

            new List<Student>
                {
                    new Student{Name = "Raihan Saikat",Email = "raihan.saikat@gmail.com",ContactNo = 0234557,Department = departments[0],RegNo = "CSE2013001",Date =Convert.ToDateTime("2013-07-15 00:00:00.000")},
                    new Student{Name = "Tauhid",Email = "tauhid@gmail.com",ContactNo = 02541557,Department = departments[0],RegNo = "CSE2013002",Date =Convert.ToDateTime("2013-07-15 00:00:00.000")},
                    new Student{Name = "Mallik",Email = "m@gmail.com",ContactNo = 01687557,Department = departments[0],RegNo = "CSE2013003",Date =Convert.ToDateTime("2013-07-17 00:00:00.000")},
                    new Student{Name = "Arnob",Email = "arnob@gmail.com",ContactNo = 01674557,Department = departments[2],RegNo = "BBA2013001",Date =Convert.ToDateTime("2013-07-12 00:00:00.000")}
                }.ForEach(s => context.Students.Add(s));
        }
    }
}