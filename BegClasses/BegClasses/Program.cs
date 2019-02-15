﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BegClasses
{
    class Program
    {
        static void Main(string[] args)
        {

            Animal myAnimal = new Animal("Billy", "Llama", "Yellow", 56);
            myAnimal.PrintDescription();
            Console.ReadLine();
            //Learning Targets:

            //I can create a class.
            //Learn how to create instance variables, methods and constructors in a class.

            //Create a class called: "Animal"

            

            //The class should have the following properties:

            //species (String)
            //name    (String)
            //color 	(String)
            //age     (int)


            //The class should have a constructor that takes in 3 strings (Color,Name,Species) and
            //initializes species, name and color to be the values of the inputs of the constructor.
            //Age should be initialized to 0;

            //The class should have the following methods  (they all should return nothing):

            //MakeSound()  - Prints the message: "Grrrrr" to the screen

            //SetAge(int newAge) -> sets the age property to be the value of newAge

            //PrintDescription() -> prints: name +" is a "+year+" year old, "+color+" "+species
        }
    }
}
