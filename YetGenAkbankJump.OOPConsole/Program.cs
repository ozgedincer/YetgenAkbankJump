// See https://aka.ms/new-console-template for more information
﻿using YetGenAkbankJump.OOPConsole.Entities;
using YetGenAkbankJump.OOPConsole.Enums;


var student = new Student()
{
    Id = Guid.NewGuid(),
    FirstName = "Özge",
    LastName="Dinçer",
    Gender = Gender.Female,
    No=1,
    CreatedOn = DateTimeOffset.Now,
    RegistrationDate = DateTimeOffset.Now.AddHours(-1),
};

var secondStudent = new Student()
{
    Id = Guid.NewGuid(),
    FirstName = "Alper",
    LastName = "Tunga",
    Gender = Gender.Male,
    No = 1,
    CreatedOn = DateTimeOffset.Now,
    RegistrationDate = DateTimeOffset.Now.AddHours(-1),
};

List<Student> students=new List<Student>();

students.Add(student);

students.Add(secondStudent);

students.ForEach(x => Console.WriteLine($"Öğrenci Bilgileri: No - {x.No} - {x.FirstName} - {x.LastName} - {x.Gender}"));

Console.ReadLine();
