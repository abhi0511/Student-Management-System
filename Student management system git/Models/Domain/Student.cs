﻿namespace student_data_management.Models.Domain
{
    public class Student
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
        public string Email { get; set; }
        public int rollno { get; set; }
        public String address { get; set; }
        public DateTime dob { get; set; }

    }
}
