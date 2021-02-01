using System;

namespace CSharpÖvningssamling3InkapslingArvOchPolymorfism
{
    public class PersonHandler
    {

        public void SetAge(Person pers, int age)
        { try {pers.GetAge = age; }catch (Exception e) { Console.WriteLine("{0} Exception caught.  SetAge(age) ", e); } }
        public void SetFName(Person pers, string fName)
        { try {pers.GetFName = fName;}catch (Exception e) { Console.WriteLine("{0} Exception caught.  SetFName(fName) ", e); } }
        public void SetLName(Person pers, string lName)
        { try {pers.GetLName = lName; }catch (Exception e) { Console.WriteLine("{0} Exception caught.  SetLName(lName) ", e); } }
        public void SetWeight(Person pers, double weight)
        { try {pers.GetWeight = weight; }catch (Exception e) { Console.WriteLine("{0} Exception caught.  SetAge(weight) ", e); } }
        public void SetHeight(Person pers, double height)
        { try {pers.GetHeight = height; }catch (Exception e) { Console.WriteLine("{0} Exception caught.  SetWeight(height) ", e); } }
        public Person CreatePerson(int age ,
                                   string fname,
                                   string lname,
                                   double height,
                                   double weight
            )
        {
            Person Per = new Person(age,fname,lname,height,weight);
            SetAge(Per, age);
            SetFName(Per, fname);
            SetLName(Per, lname);
            SetWeight(Per, height);
            SetHeight(Per, weight);
            return Per;
        }

    }
}
