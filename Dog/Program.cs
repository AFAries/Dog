using System;

namespace Dog
{
    //Make the enum before the class
    public enum Gender
    {
        Male, 
        Female
    }


    public class Dog
    {
        string name, owner;
        int age;
        Gender gen;

        public Dog(string name, string owner, int age, Gender gen)
        {
            this.name = name;
            this.owner = owner;
            this.age = age;
            this.gen = gen;
        }

        //Will make the dog bark/woof a number of times...
        void Bark(int barkNumber)
        {
            int numBark = 0;
              while (numBark < barkNumber)
            {
                Console.WriteLine("Woof");
                numBark++;
            }
        }


        //Sets up one string and keeps on adding to it, 
        //the if statements determine which word to use in the string
        string GetTag()
        {
            string dogTag = "If lost, call " + owner + ".";

            if (gen == Gender.Male)
            {
                dogTag += " His";
            }
            else if (gen == Gender.Female)
            {
                dogTag += " Her";
            }

            dogTag += " name is " + name + " and ";

            if (gen == Gender.Female)
            {
                dogTag += "she";
            }
            else if (gen == Gender.Male)
            {
                dogTag += "he";
            }

            dogTag += " is " + age;

            if (age == 1)
            {
                dogTag += " year";
            }

            else if (age != 1)
            {
                dogTag += " years";
            }

            dogTag += " old.";
            return dogTag;

        }

        static void Main(string[] args)
        { 
            //Sets values for output (output will use 'his', 'year' in the string
            //inu=dog in Japanese....
            //The dog will bark 3 times
            Dog inu = new Dog("Orion", "Shawn", 1, Gender.Male);
            inu.Bark(3);
            Console.WriteLine(inu.GetTag());
            Console.WriteLine("");
            //Sets values for output (output will use 'her' and 'years'
            //hund=dog in German....
            //The dog will bark once
            Dog hund = new Dog("Lileu", "Dale", 4, Gender.Female);
            hund.Bark(1);
            Console.WriteLine(hund.GetTag());


            //Changed puppy->inu and myDog to hund, but this is Copy/paste of what
            //the output is to look like from the challenge

            //Dog puppy = Dog("Orion", "Shawn", 1, Gender.Male);  // create object instance
            //puppy.Bark(3); // output: Woof!Woof!Woof!
            //Console.WriteLine(puppy.GetTag()); // output: If lost, call Shawn. His name is Orion and he is 1 year old.

            //Dog myDog = Dog("Lileu", "Dale", 4, Gender.Female);  // create object instance
            //myDog.Bark(1); // output: Woof!
            //Console.WriteLine(myDog.GetTag()); // output: If lost, call Dale. Her name is Lileu and she is 4 years old.

        }

    }
}
