using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_IvanRusev_11e
{
    public class Mobile
    {
        //class properties
        private string model;
        public string Model 
        {
            get { return model; }
            private set { model = value; }
        }

        private string brand;
        public string Brand
        {
            get { return brand; }
            private set { brand = value; }
        }

        private int yearOfManufacture;
        public int YearOfManufacture
        {
            get { return yearOfManufacture; }
            private set 
            { 
                if(value > 2020 || value < 1800)
                {
                    throw new ArgumentException("Invalid year");
                }
                else yearOfManufacture = value; 
            }
        }

        private double kilometers;
        public double Kilometers
        {
            get { return kilometers; }
            private set 
            { 
                if(value < 0)
                {
                    throw new ArgumentException("Kilometers cannot be smaller than zero!");
                }
                else kilometers = value; 
            }
        }

        public Owner MobileOwner { get; private set; }
        
        public static int mobilesCount;

        //constructors

        public Mobile()
        {
            this.Model = null;
            this.Brand = null;
            this.YearOfManufacture = 0;
            this.Kilometers = 0;
            this.MobileOwner = new Owner(null,null,null);
            mobilesCount++;
        }

        public Mobile(string model, string brand) : this()
        {
            this.Model = model;
            this.Brand = brand;
        }

        public Mobile(string model, string brand, int year)
            : this(model, brand)
        {
            this.YearOfManufacture = year;
        }

        public Mobile(string model, string brand, int year, double kms)
            : this(model, brand, year)
        {
            this.Kilometers = kms;
        }

        public Mobile(string model, string brand, int year, double kms, Owner owner)
            : this(model, brand, year, kms)
        {
            this.MobileOwner = owner;
        }

        //functionality

        public static void PrintMobileInfo(Mobile m)
        {
            Console.WriteLine();
            Console.WriteLine("###Selected mobile: ###");

            Console.WriteLine("Brand, Model and YoM: {0} {1} , {2}",m.Brand,m.Model,m.YearOfManufacture);
            Console.WriteLine("Current mileage: {0}",m.Kilometers);
            Console.WriteLine("Owners info:");
            Console.WriteLine("-Name: {0} {1}",m.MobileOwner.FirstName, m.MobileOwner.LastName);
            Console.WriteLine("-Phone number: {0}",m.MobileOwner.PhoneNumber);

        }
    }
}
