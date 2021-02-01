using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpÖvningssamling3InkapslingArvOchPolymorfism
{
    
    public class Person
    {
       // ValuesOfStrings vs = new ValuesOfStrings();

        private string fName ;  
        private string lName ;
        private double weight ;
        private double height ;
        private int age ;
        

        public string GetFName
        {
            get { return fName; }
            set
            {
                if (string.IsNullOrEmpty(value)) {throw new ArgumentNullException($"can not be null or empty");}
                else if (value.Length < 2 || value.Length > 10){throw new ArgumentException("Try again, Name must be longer than 2 letters but maximum 10");}
                else { fName = value; Console.WriteLine("Person name " + value); }
            }
        }
        public string GetLName
        {
            get { return lName; }
            set
            {
                if (string.IsNullOrEmpty(value)){ throw new ArgumentNullException($"can not be null or empty"); }
                else if (value.Length < 3 || value.Length > 15){throw new ArgumentException("Try again, Last Name must be longer than 3 letters but maximum 15");}
                else { lName = value; Console.WriteLine("Person last name " + value); }
            }
        }
        public double GetWeight
        {
            get { return weight; }
            set
            {
                if (value <= 0.0){throw new ArgumentException("Try again, weight must be between 1 and 200....." + value);}
                else{ weight = value; Console.WriteLine("Person weight " + value); }    
            }
        }   
        public double GetHeight
        {
            get { return height; }
            set
            {
                if (value <= 0.0){throw new ArgumentException("Try again, height must be between 1 and 200....." + value);}
                else {height = value; Console.WriteLine("Person height " + value); }
            }
        }
        public int GetAge
        {
            get { return age; }
            set
            {
                if (value <= 0 || value >= 200) { throw new ArgumentException("Try again, Age must be between 0 and 200......" + value); }
                else { age = value; Console.WriteLine("Person age " + value); }
            }
        }


        public Person(int age , string fname, string lname, double weight, double height)
        {
            try
            {
                GetAge = age;
                GetFName = fname;
                GetLName = lname;
                GetWeight = weight;
                GetHeight = height;
            }   
            catch (Exception e) { Console.WriteLine("{0} Exception caught.  Person() ", e); }
        }

    }
}
