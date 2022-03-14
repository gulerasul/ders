using System;
using System.Collections.Generic;
using System.Text;

namespace homework
{
    class Vehicle
    {
        public string color;
        public int year;
        public string brand;
        public string model;
        public int FuelCapacity;
        public int FuelFor1Km;
        public int CurrentFuel;

        public Vehicle()
        {

        }

        public Vehicle(string color)

        {
            this.color = color;
        }
        public Vehicle(string color, string model) : this(color)
        {
            this.model = model;
        }
        public Vehicle(string brand, string color, string model) : this(color, model)
        {
            this.brand = brand;
        }
        public Vehicle(string brand, string color, string model, int year) : this(color, model, brand)
        {
            this.year = year;
        }
        public Vehicle(string brand, string color, string model, int year, int FuelCapacity) : this(color, model, brand, year)
        {
            this.FuelCapacity = FuelCapacity;
        }
        public Vehicle(string brand, string color, string model, int year, int FuelCapacity, int FuelFor1km) : this(color, model, brand, year, FuelCapacity)

        {
            this.FuelFor1Km = FuelFor1Km;
        }


        public Vehicle(string brand, string color, string model, int year, int FuelCapacity, int FuelFor1km, int CurrentFuel) : this(color, model, brand, year, FuelCapacity, FuelFor1Km)
        {
            this.CurrentFuel = CurrentFuel;
        }


    }
    
