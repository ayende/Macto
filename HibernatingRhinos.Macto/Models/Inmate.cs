﻿using System;

namespace HibernatingRhinos.Macto.Models
{
    public class Inmate
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
		public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}