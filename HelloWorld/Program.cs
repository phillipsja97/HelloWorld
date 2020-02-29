using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HelloWorld
{
    class Program
    {
        private static object pattern;

        static void Main(string[] args)
        {
            var animals = new string[] { "Triceratops", "Gorilla", "Corgi", "Toucan", "dog" };

            Console.WriteLine("What is your name?");

            var name = Console.ReadLine();

            Console.WriteLine($"Nice to meet you, {name}.");

            Console.ReadLine();

            Console.WriteLine("What is your favorite Color?");

            var favColor = Console.ReadLine();

            Random random = new Random();

            var randomIndex = random.Next(0, animals.Length);

            Console.WriteLine($"Would you like a {favColor}, {animals[randomIndex]}");

            Console.ReadLine();


            int CountSyllables(string word)
            {
                char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'y' };
                string currentWord = word;
                int numVowels = 0;
                bool lastWasVowel = false;
                foreach (char wc in currentWord)
                {
                    bool foundVowel = false;
                    foreach (char v in vowels)
                    {
                        if (v == wc && lastWasVowel)
                        {
                            foundVowel = true;
                            lastWasVowel = true;
                            break;
                        }
                        else if (v == wc && !lastWasVowel)
                        {
                            numVowels++;
                            foundVowel = true;
                            lastWasVowel = true;
                            break;
                        }
                    }

                    if (!foundVowel)
                        lastWasVowel = false;
                }

                if (currentWord.Length > 2 &&
                    currentWord.Substring(currentWord.Length - 2) == "es")
                    numVowels--;

                else if (currentWord.Length > 1 &&
                    currentWord.Substring(currentWord.Length - 1) == "e")
                    numVowels--;
                return numVowels;
            }
            foreach (var animal in animals)
            {
                if (CountSyllables(animal) >= 2)
                {
                    Console.WriteLine(animal);
                }
            }
            Console.ReadLine();

            Console.WriteLine("Type in any letters...");

            var input = Console.ReadLine();

            var increment = 0;

            foreach (var letter in input)
            {
                increment++;
                var result = new String(letter, increment);
                Console.WriteLine(result);
            }


            Console.ReadLine();

            Console.WriteLine("Press enter to mulitply an array of 1,2,3");

            Console.ReadLine();

            int[] numbers = new int[3] { 1, 2, 3 };

            int prod = numbers.Aggregate(1, (a, b) => a * b);

            Console.WriteLine(prod);

            Console.WriteLine("Press enter to mulitply an array of 2,4,5");

            Console.ReadLine();

            int[] numbers2 = new int[3] { 2, 4, 5 };

            int prod2 = numbers2.Aggregate(1, (a, b) => a * b);

            Console.WriteLine(prod2);

            Console.ReadLine();

            Console.WriteLine("Would you like to multiply a set of numbers in a list together or get the square of a set of numbers in a list? Press 1 for multiply or 2 for square.");

            var multInput = Convert.ToInt32(Console.ReadLine());

            if (multInput == 2)
            {
                Console.WriteLine("What set of numbers would you like to square? Write your numbers like this, ex: 1,2,3");
                var final = 1;
                var dope = 1;
                var go = "";
                var numberList = "";
                List<string> numberSet = new List<string>();
                var multNumbers = Console.ReadLine();
                var splitNum = multNumbers.Split(',');
                foreach (var c in splitNum)
                {
                    var finalInt = int.Parse(c);
                    final = finalInt;
                    dope = final *= finalInt;
                    go = dope.ToString();
                    numberSet.Add(go);
                    numberList = string.Join(", ", numberSet);
                }
                Console.WriteLine(numberList);
            }

            if (multInput == 1)
            {
                Console.WriteLine("List the numbers that you would like to multiply? Write your numbers in this pattern: 1,2,3");
                var final = 1;
                var squared = Console.ReadLine();
                var enteredNumbers = squared.Split(',');
                foreach (var s in enteredNumbers)
                {
                    var finalInt = int.Parse(s);
                    final *= finalInt;
                }
                Console.WriteLine(final);

            }

            Console.ReadLine();

            Console.WriteLine("Enter * to multiply and ^ to square a set of numbers. Example: *1,2,3 returns 6");

            var shortInput = Console.ReadLine();

            char[] theCharacters = shortInput.ToCharArray();

            var theResult = 1;
            var addResult = 0;
            var divResult = 1;
            var theFinal = 1;
            var avgDiv = 0;
            var avgFinal = 0;
            var theSet = "";
            var listToSq = "";
            List<string> numberSetForSq = new List<string>();

            if (theCharacters.Contains('*'))
            {
                var splitted = shortInput.Split(',');

                foreach (var t in splitted.Skip(1))
                {
                    var finalInt = int.Parse(t);
                    theResult *= finalInt;
                }
                Console.WriteLine(theResult);
            }
            else if (theCharacters.Contains('^'))
            {
                var splitted = shortInput.Split(',', '^');

                foreach (var f in splitted.Skip(1))
                {
                    var finalInt = int.Parse(f);
                    theResult = finalInt;
                    theFinal = theResult *= finalInt;
                    theSet = theFinal.ToString();
                    numberSetForSq.Add(theSet);
                    listToSq = string.Join(", ", numberSetForSq);
                }
                Console.WriteLine(listToSq);
            }
            else if (theCharacters.Contains('+'))
            {
                var splitted = shortInput.Split(',', '+');

                foreach (var a in splitted.Skip(1))
                {
                    var finalInt = int.Parse(a);
                    addResult += finalInt;
                }
                Console.WriteLine(addResult);
            }
            //else if (theCharacters.Contains('/'))
            //{
            //    var splitted = shortInput.Split(',', '/');

            //    foreach (var a in splitted.Skip(1))
            //    {
            //        var finalInt = int.Parse(a);
            //        divResult = finalInt;
            //        finalInt /= divResult;
            //    }
            //    Console.WriteLine(divResult);
            //}
            //else if (shortInput.Contains("avg"))
            //{
            //    var inputRemoved = shortInput.Remove(0, 3);
            //    var splitted = inputRemoved.Split(',');
            //    var splitInt = Convert.ToInt32(splitted);
            //    Console.WriteLine(splitInt);
            //    Console.ReadLine();

            //    foreach (var a in splitted)
            //    {
            //        var finalInt = int.Parse(a);
            //        avgDiv += finalInt;
            //        var avg = avgDiv / splitted.Length;
            //        Console.WriteLine(avg);
            //        //avg = avgFinal;
            //        //Console.WriteLine(avgFinal);
            //    }
            //    Console.WriteLine(avgFinal);
            //}



            Console.ReadLine();

        Console.ReadLine();
            Console.WriteLine("Tell Me a secret");
            var str = Console.ReadLine();
            if (str.Length > 4)
            {
                Console.WriteLine(
                    string.Concat(
                        "".PadLeft(str.Length - 4, '*'),
                        str.Substring(str.Length - 4)
                    )
                );
            }
            else
            {
                Console.WriteLine(str);
            }


Console.WriteLine("Enter a pin between 4 and 8 digits");

                var userPin = Console.ReadLine();

char[] pins = userPin.ToCharArray();

int ignore;

var successful = int.TryParse(userPin, out ignore);

            if (pins.Length > 8)
            {
                Console.WriteLine("Password can't be longer than 8 digits");
            }
            else if (pins.Length< 4)
            {
                Console.WriteLine("Password must be longer than 4 digits");
            }
            else if (!successful)
            {
                Console.WriteLine("Password can't contain any letters");
            }
            else
            {
                Console.WriteLine("Password saved");
            }

            Console.ReadLine();

            //Console.WriteLine("Enter a 10 digit phone number in any format");

            //var teleInput = Console.ReadLine();

            //if (teleInput.Length != 10)
            //{
            //    Console.WriteLine("Telephone number must be 10 digits");
            //}
            //else if ();
            //{

            //}
        }
    }
}
