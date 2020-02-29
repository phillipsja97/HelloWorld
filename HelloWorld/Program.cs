using System;
using System.Collections.Generic;
using System.Linq;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //var animals = new string[] { "Triceratops", "Gorilla", "Corgi", "Toucan", "dog" };

            //Console.WriteLine("What is your name?");

            //var name = Console.ReadLine();

            //Console.WriteLine($"Nice to meet you, {name}.");

            //Console.ReadLine();

            //Console.WriteLine("What is your favorite Color?");

            //var favColor = Console.ReadLine();

            //Random random = new Random();

            //var randomIndex = random.Next(0, animals.Length);

            //Console.WriteLine($"Would you like a {favColor}, {animals[randomIndex]}");

            //Console.ReadLine();


            //int CountSyllables(string word)
            //{
            //    char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'y' };
            //    string currentWord = word;
            //    int numVowels = 0;
            //    bool lastWasVowel = false;
            //    foreach (char wc in currentWord)
            //    {
            //        bool foundVowel = false;
            //        foreach (char v in vowels)
            //        {
            //            if (v == wc && lastWasVowel)
            //            {
            //                foundVowel = true;
            //                lastWasVowel = true;
            //                break;
            //            }
            //            else if (v == wc && !lastWasVowel)
            //            {
            //                numVowels++;
            //                foundVowel = true;
            //                lastWasVowel = true;
            //                break;
            //            }
            //        }

            //        if (!foundVowel)
            //            lastWasVowel = false;
            //    }

            //    if (currentWord.Length > 2 &&
            //        currentWord.Substring(currentWord.Length - 2) == "es")
            //        numVowels--;

            //    else if (currentWord.Length > 1 &&
            //        currentWord.Substring(currentWord.Length - 1) == "e")
            //        numVowels--;
            //    return numVowels;
            //}
            //foreach(var animal in animals)
            //{
            //    if (CountSyllables(animal) >= 2)
            //    {
            //        Console.WriteLine(animal);
            //    }
            //}
            //Console.ReadLine();

            //Console.WriteLine("Type in any letters...");

            //var input = Console.ReadLine();

            //var increment = 0;

            //foreach (var letter in input)
            //{
            //    increment++;
            //    var result = new String(letter, increment);
            //    Console.WriteLine(result);
            //}


            //Console.ReadLine();

            //Console.WriteLine("Press enter to mulitply an array of 1,2,3");

            //Console.ReadLine();

            //int[] numbers = new int[3] { 1, 2, 3 };

            //int prod = numbers.Aggregate(1, (a, b) => a * b);

            //Console.WriteLine(prod);

            //Console.WriteLine("Press enter to mulitply an array of 2,4,5");

            //Console.ReadLine();

            //int[] numbers2 = new int[3] { 2, 4, 5 };

            //int prod2 = numbers2.Aggregate(1, (a, b) => a * b);

            //Console.WriteLine(prod2);

            //Console.ReadLine();

            //Console.WriteLine("Would you like to multiply a set of numbers in a list together or get the square of a set of numbers in a list? Press 1 for multiply or 2 for square.");

            //var multInput = Convert.ToInt32(Console.ReadLine());

            //if (multInput == 2)
            //{
            //    Console.WriteLine("What set of numbers would you like to square? Write your numbers like this, ex: 1,2,3");
            //    var final = 1;
            //    var dope = 1;
            //    var go = "";
            //    var numberList = "";
            //    List<string> numberSet = new List<string>();
            //    var multNumbers = Console.ReadLine();
            //    var splitNum = multNumbers.Split(',');
            //    foreach (var c in splitNum)
            //    {
            //        var finalInt = int.Parse(c);
            //        final = finalInt;
            //        dope = final *= finalInt;
            //        go = dope.ToString();
            //        numberSet.Add(go);
            //        numberList = string.Join(", ", numberSet);
            //    }
            //    Console.WriteLine(numberList);
            //}

            //if (multInput == 1)
            //{
            //    Console.WriteLine("List the numbers that you would like to multiply? Write your numbers in this pattern: 1,2,3");
            //    var final = 1;
            //    var squared = Console.ReadLine();
            //    var enteredNumbers = squared.Split(',');
            //    foreach (var s in enteredNumbers)
            //    {
            //        var finalInt = int.Parse(s);
            //        final *= finalInt;
            //    }
            //    Console.WriteLine(final);

            //}

            //Console.ReadLine();
            //Console.WriteLine("Tell Me a secret");
            //var str = Console.ReadLine();
            //if (str.Length > 4)
            //{
            //    Console.WriteLine(
            //        string.Concat(
            //            "".PadLeft(str.Length - 4, '*'),
            //            str.Substring(str.Length - 4)
            //        )
            //    );
            //}
            //else
            //{
            //    Console.WriteLine(str);
            //}

            //Console.ReadLine();


        }
    }
}
