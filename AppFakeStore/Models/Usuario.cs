﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFakeStore.Models
{
    public class Usuario
    {
        public Address address { get; set; }
        public int id { get; set; }
        public string email { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public Name name { get; set; }
        public string phone { get; set; }
        public int __v { get; set; }
        public string FullName => $"{name.firstname} {name.lastname}";
        public string Direccion => $"{address.street} {address.number}";
        public string city { get; set; }


    }

    public class Address
    {
        public Geolocation geolocation { get; set; }

        public string street { get; set; }
        public int number { get; set; }
        public string zipcode { get; set; }
    }

    public class Geolocation
    {
        public string lat { get; set; }
        public string _long { get; set; }
    }

    public class Name
    {
        public string firstname { get; set; }
        public string lastname { get; set; }
    }

}