﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Management_System.model
{
    public class User
    {
        private string id;
        private string name;
        private int age;
        private double height, weight;
        private string gender;
        private string bloodGrp;
        private DateTime dateOfBirth;
        private string email;
        private string phone;
        private Trainer trainer;

        public User(string id, string name, int age, double height, double weight, string gender, string bloodGrp, DateTime dateOfBirth, string email, string phone, Trainer trainer)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.height = height;
            this.weight = weight;
            this.gender = gender;
            this.bloodGrp = bloodGrp;
            this.dateOfBirth = dateOfBirth;
            this.email = email;
            this.phone = phone;
            this.trainer = trainer; 
        }

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public double Height { get => height; set => height = value; }
        public double Weight { get => weight; set => weight = value; }
        public string Gender { get => gender; set => gender = value; }
        public string BloodGrp { get => bloodGrp; set => bloodGrp = value; }
        public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public string Email { get => email; set => email = value; }
        public string Phone { get => phone; set => phone = value; }
        public Trainer Trainer { get => trainer; set => trainer = value; }
    }
}
