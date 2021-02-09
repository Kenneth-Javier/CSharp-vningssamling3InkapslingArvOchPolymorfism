using System;
using System.Collections.Generic;

namespace CSharpÖvningssamling3InkapslingArvOchPolymorfism
{
    class Program
    {
        ValuesOfStrings vos = new ValuesOfStrings();

        static void Main(string[] args)
        {
            //Person person = new Person();

            PersonHandler personHandler = new PersonHandler();

          //PrintWelcomeClient();
            //HandleOptions(person, personHandler);
            //HandleOptions(personHandler);
            //PrintOutPerson(person);

            //madePerson(person,personHandler);

            //CreatePerson(personHandler);

            ListOfAnimals();

            //printErrors();


            //PrintOutPerson(person);
        }

        static void CreatePerson(PersonHandler ph)
        {
        string FName = "Anders";
        string LName = "Andersson";
        double Weight = 90.4;
        double Height = 150.5;
        int Age = 45;

            try{ph.CreatePerson( 
                Age, FName, LName, Weight, Height); 
            } catch (Exception e) { Console.WriteLine("{0} Exception caught.  madePerson() ", e); }
        }

        private static void ListOfAnimals () 
        {
            List<Animal> AnimalList = new List<Animal>();           
            AnimalList.Add(new Horse("Harry", 55.2, 30.80, 7, "Gryningshorse"));
            AnimalList.Add(new Dog("Fido", 4.3, 23.21, 5, "smal"));
            AnimalList.Add(new Hedgehog("Kotten", 1.1, 9.2,2,320));
            AnimalList.Add(new Worm("Blixten", 5.0, 5.3, 89, 431));
            AnimalList.Add(new Bird("Klara", 25.8, 33, 7, 65.7));
            AnimalList.Add(new Wolf("Silver",50.1,150,11,5.3));
            AnimalList.Add(new Pelican("Nebi",20.7,60.4,27,120,30));
            AnimalList.Add(new Flamingo("Pedro",1.1,170.82,22,340.32,110.84));
            AnimalList.Add(new Swan("Sandra",30.0,120.3,6,131.5,90.62));
            AnimalList.Add(new Wolfman("Alex",180,200,30,10.1,90));

            foreach (var animal in AnimalList)
            {
                animal.DoSound();
                Console.WriteLine(animal.GetType().Name);
                Console.WriteLine(animal.Stats());
                if (animal is PersonInterface)
                {
                    var person = (PersonInterface)animal;
                    person.Talk();
                }
            }
        }
        static void printErrors()
        {
            List<UserError> userErrors = new List<UserError>
            { new NumericInputError(),
                new TextInputError() };
            foreach (var error in userErrors)
            { Console.WriteLine(error.UEMessage()); }
        }

        static void madePerson(Person p,PersonHandler ph)
        {
            try
            {   //p.GetAge = -10;
                ph.SetAge(p, 25);
                //Console.WriteLine();
            }catch (Exception e) { Console.WriteLine("{0} Exception caught.  madePerson() ", e); }
        }

        static void PrintOutPerson(Person p)
        {
            string[] starray = new string[]{ "\n",
                "" + p.GetFName + " " + p.GetLName,
            p.GetAge + " years old",        
            //"\n",
            p.GetHeight + " m",
            //"\n",
            p.GetWeight + " Kg",               
            //"\n" 
            };
        string s = String.Join("\n", starray);
        ValuesOfStrings.StrOut(s);
        }



        //Handles the menu optoions for the program
        private static void HandleOptions(PersonHandler ph)
        //private static void HandleOptions(Person p, PersonHandler ph)
        {
            //While true, menu will be running
            bool menuActual = true;
            do
            {
                //prints out menu
                PrintMainMenu();
                //switch recives input from user and handle options chose dependent of users string input
                string x = Console.ReadLine();
                string caseSwitch = x;
                switch (caseSwitch)
                {
                    case "1":
                        string n;
                        PrintName();
                        n = Console.ReadLine();
                        //try { p.GetFName = n; }catch (Exception e) { Console.WriteLine("{0} Exception caught.", e);}

                        PrintLastName();
                        n = Console.ReadLine();
                        //try { p.GetLName = n; }catch (Exception e){Console.WriteLine("{0} Exception caught.", e);}

                        int age;
                        PrintAge();
                        n = Console.ReadLine();
                        if (ValuesOfStrings.IsStringInt(n))
                        {age = ValuesOfStrings.IntParsedValue(n);}
                        else { age = 0; }//matar in ett default int värde för att kunna ta emot ett värde i person klassen
                        //try { p.GetAge = age; }catch (Exception e) { Console.WriteLine("{0} Exception caught.", e); }

                        double height;
                        PrintHeight();
                        n = Console.ReadLine();
                        if (ValuesOfStrings.IsStringDouble(n))
                        { height = ValuesOfStrings.DoubleParsedValue(n); }
                        else { height = 0.0; }//matar in ett default double värde för att kunna ta emot ett värde i person klassen
                        //try { p.GetHeight = height; }catch (Exception e) { Console.WriteLine("{0} Exception caught.", e); }

                        double weight;
                        PrintWeight();
                        n = Console.ReadLine();
                        if (ValuesOfStrings.IsStringDouble(n))
                        {weight = ValuesOfStrings.DoubleParsedValue(n);}
                        else { weight = 0.0; }//matar in ett default double värde för att kunna ta emot ett värde i person klassen
                        //try { p.GetWeight = weight; }catch (Exception e) { Console.WriteLine("{0} Exception caught.", e); }
                        
                        ValuesOfStrings.StrOut("\n" + "Thanx!");
                        //PrintOutPerson(p);
                        break;

                    case "2":
                        ValuesOfStrings.StrOut("2" + "\n");
                        //PrintOutPerson(p);

                        break;
                    case "3":
                        ValuesOfStrings.StrOut("3" + "\n");
                        //madePerson(p,ph);
                        break;


                    case "0":
                        ValuesOfStrings.StrOut("Menu 0 for Quit");
                        menuActual = false;
                        Environment.Exit(0);
                        break;
                    default:
                        ValuesOfStrings.StrOut("Wrong Input");
                        break;
                }
            } while (menuActual);
        }

        //Prints out how to use the menu system
        private static void PrintWelcomeClient()
        {
            string[] starray = new string[] { "Create a person!",
            "Du har kommit till huvudmenyn och kommer navigera genom att skriva in siffror för att testa olika funktioner.",
            "\n" };
            string s = String.Join("\n", starray);
            ValuesOfStrings.StrOut(s);
        }


        //Prints out the head menu
        private static void PrintMainMenu()
        {
            string[] starray = new string[]{"Mainmeny: ",
            "Menu 1: Create a new person",
            "Menu 2: Show persons",
            "Menu 3: Insert new person",
            "Menu 0 for Quit program",
            "\n" };
            string s = String.Join("\n", starray);
            ValuesOfStrings.StrOut(s);

        }

        private static void PrintName()
        {
            ValuesOfStrings.StrOut("Name: ");
        }

        private static void PrintLastName()
        {
            ValuesOfStrings.StrOut("Last Name: ");
        }

        private static void PrintAge()
        {
            ValuesOfStrings.StrOut("age: ");
        }

        private static void PrintWeight()
        {
            ValuesOfStrings.StrOut("Weight(Kg): ");
        }

        private static void PrintHeight()
        {
            ValuesOfStrings.StrOut("Height(Meters): ");
        }
    }

    

}
