using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpÖvningssamling3InkapslingArvOchPolymorfism
{
    abstract class Animal
    {

        public string Name { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }
        public int Age { get; set; }

        public Animal(string name, double weight, double height, int age)
        {
        
            Name = name;
            Weight = weight;
            Height = height;
            Age = age;
        }
        public virtual string Stats(){ return $"The animal {Name} weight is:{Weight}kg, it is {Height}cm high at age: {Age}"; }
        public abstract void DoSound();
    }
    class Horse : Animal
    {
        public string Breed{ get; set; }
        
        public Horse(string name, double weight, double height, int age, string breed) : base(name, weight, height, age)
        {
            Breed = breed;
        }

        public override string Stats(){return base.Stats() +" Of breed: " + Breed;}
        public override void DoSound()
        {
            Console.WriteLine("gnägg");
        }

    }
    class Dog : Animal
    {
        public string Size { get; set; }

        public Dog(string name, double weight, double height, int age, string size) : base(name, weight, height, age)
        {
            Size = size;
        }
        public override string Stats() { return base.Stats() + " Size: " + Size + ""; }
        public override void DoSound()
        {
            Console.WriteLine("Woooof! Woooof! ");
        }

    }
    class Hedgehog : Animal
    {
        public int Tags { get; set; }
        public Hedgehog(string name, double weight, double height, int age, int tags) : base(name, weight, height, age)
        {
            Tags = tags;
        }
        public override string Stats(){ return base.Stats() + " ldgksdlgksdöl: " + Tags;  }
        public override void DoSound()
        {
            Console.WriteLine("eiieeeeeyyyhh! ");
        }
    }
    class Worm : Animal
    {
        public int Lenght { get; set; }
        public Worm(string name, double weight, double height, int age, int lenght) : base(name, weight, height, age)
        {
            Name = name;
            Weight = weight;
            Height = height;
            Age = age;
            Lenght = lenght;
        }
        public override string Stats() { return base.Stats() + " lenght: " + Lenght + "cm"; }
        public override void DoSound()
        {
            Console.WriteLine("ZzZzZzZzZzZ! ");
        }
    }
    class Bird : Animal
    {
        public double WingSpan { get; set; }
        public Bird(string name, double weight, double height, int age, double wingSpan) : base(name, weight, height, age)
        {
            Name = name;
            Weight = weight;
            Height = height;
            Age = age;
            WingSpan = wingSpan;
        }
        public override string Stats() { return base.Stats() + " The wingspan is: " + WingSpan + "cm"; }
        public override void DoSound()
        {
            Console.WriteLine("PAKA! PAKA!! ");
        }
    }
    class Wolf : Animal
    {
        public double TeethSize { get; set; }
        public Wolf(string name, double weight, double height, int age, double teethSize) : base(name, weight, height, age)
        {
            Name = name;
            Weight = weight;
            Height = height;
            Age = age;
            TeethSize = teethSize;
        }

        public override string Stats(){ return base.Stats() + " teeth size: " + TeethSize +"cm"; }
        public override void DoSound()
        {
            Console.WriteLine("AOUUUU! AOUUUU!! ");
        }
    }

    class Pelican : Bird 
    {
        public double MouthVolume { get; set; }
        public Pelican(string name, double weight, double height, int age, double wingSpan, double mouthVolume) : base(name, weight, height, age, wingSpan)
        {
            Name = name;
            Weight = weight;
            Height = height;
            Age = age;
            WingSpan = wingSpan;
            MouthVolume = mouthVolume;
        }
        public override string Stats() { return base.Stats() + ". The mounth volume: : " + MouthVolume + "L"; }
        public override void DoSound()
        {
            Console.WriteLine("PAAAAAAAAAA!! ");
        }
    }
    class Flamingo : Bird 
    {
        public double LegLength { get; set; }
        public Flamingo(string name, double weight, double height, int age, double wingSpan, double legLength) : base(name, weight, height, age, wingSpan)
        {
            Name = name;
            Weight = weight;
            Height = height;
            Age = age;
            WingSpan = wingSpan;
            LegLength = legLength;
        }
        public override string Stats() { return base.Stats() + " The leg length: : " + LegLength+ "cm"; }
        public override void DoSound()
        {
            Console.WriteLine("PAh PAh PAh PAh PAh ");
        }

    }
    class Swan : Bird 
    {
        public double NeckLength {get; set; }
        public Swan(string name, double weight, double height, int age, double wingSpan, double neckLength) : base(name, weight, height, age, wingSpan)
        {
            Name = name;
            Weight = weight;
            Height = height;
            Age = age;
            WingSpan = wingSpan;
            NeckLength = neckLength;
        }
        public override string Stats() { return base.Stats() + " The neck length: " + NeckLength + "cm"; }
        public override void DoSound()
        {
            Console.WriteLine("HÄÄÄÄÄ! ");
        }
    }
    
    class Wolfman : Wolf, PersonInterface
    {
        public double Width { get; set; }
        public Wolfman(string name, double weight, double height, int age, double teethSize, double width) : base(name, weight, height, age, teethSize)
        {
            Name = name;
            Weight = weight;
            Height = height;
            Age = age;
            TeethSize = teethSize;
            Width = width;
        }
        public override void DoSound()
        {
            Console.WriteLine("AOUUUU! AOUUUU!! AOUUUU!!");
        }

        public void Talk()
        { Console.WriteLine("Jag är en man hjälp!"); }
            
        

        public override string Stats() { return base.Stats() + " teeth size: " + Width + "cm"; }

        //3.2) Arv

        //13. F: Om vi under utvecklingen kommer fram till att samtliga fåglar behöver ett nytt attribut, i vilken klass bör vi lägga det?
        //Svar: I Bird klassen
        //14. F: Om alla djur behöver det nya attributet, vart skulle man lägga det då?
        //Svar: I Animal klassen

        //3.4) Polymorfism

        //11. F: Varför är polymorfism viktigt att behärska?
        //Svar: Ett enkelt sätt att inte göra om hjulet, 
        //man kan lättare använda sig av likheterna mellan objekt liksom exemplet med animals och djuren.
       
        //12. F: Hur kan polymorfism förändra och förbättra kod via en bra struktur?
        //Svar: Man behöver inte impementera lika mycket kod och om det behövs så kan man hitta den största gemensama nämnaren
        
        //13. F: Vad är det för en skillnad på en Abstrakt klass och ett Interface?
        //Svar: Ett interface deklarerar bara medlemmarna och en abstrakt klass behöver bara ha en abstrakt metod medans 
        //ett interface måste vara helt abstrakt 
    }
}
