using System;
using System.IO;

namespace _2020_Day2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader(new FileStream("input.txt", FileMode.Open)))
            {
                string line; int max, min, total = 0; string password, letter; int accepted=0;

                while ((line = reader.ReadLine()) != null)
                {
                    min = int.Parse(line.Remove(2).Replace('-', ' '));
                    max = int.Parse(line.Remove(0, 2).Replace('-', ' ').Trim().Remove(2));
                    password = line.Remove(0, 7).Replace(':', ' ').Trim();
                    letter = (line.Replace(':', ' ').Replace('-', ' ').TrimStart('1', '2', '3', '4', '5', '6', '7', '8', '9', '0').Trim().Remove(0, 2).Trim().Remove(1));

                    // Creating array of string length 
                    char[] ch = new char[letter.Length];
                    // Copy character by character into array 
                    for (int i = 0; i < letter.Length; i++)
                    {
                        ch[i] = letter[i];
                    }
                    // Printing content of array 
                    foreach (char c in letter)
                    {


                        foreach (char l in password)
                        {

                            if (c == l)
                            {
                                
                                total++;
                                
                            }



                        }
                        
                       

                        if(total >= min && total <= max )
                        {

                            accepted++;
                        }

                        Console.WriteLine(min + " " + total + " " + max);
                        
                        total = 0;
                    }

                    

                    Console.WriteLine(accepted);

                }
            }
            
            Console.ReadKey();
        }
    }
}

