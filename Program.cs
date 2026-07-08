
using System;

namespace Calculator;

class Program
{
    static void Main()
    {
        bool LinebyLine = true;
        bool style = true;

    
             while(style)   
                {
                    Console.WriteLine("CHOOSE YOUR INPUT STYLE \n [1] LINE BY LINE SEPARATED WITH [ENTER] \n [2] ONE LINE CONNECTED WITH SYMBOLS");

                    switch (Console.ReadLine())
                    {
                        case "1":
                        LinebyLine = true;
                        style = false;
                        break;

                        case "2":
                        LinebyLine = false;
                        style = false;
                        break;

                        default:
                        Console.WriteLine("INVALID INPUT. TRY AGAIN");
                        style = true;
                        break;
                    }
                }
    
        bool MainMenu = true;

            while(MainMenu)
                {

                    if (LinebyLine == true)
                    Console.WriteLine("INPUT STYLE: LINE BY LINE CONNECTED WITH [ENTER]");
        
                    else
                    Console.WriteLine("INPUT STLE: ONE LINE CONNECTED WITH A SYMBOL");
            
       
                    Console.WriteLine("WELCOME \n CHOOSE YOUR OPERTAION \n [1] ADDITION  [2]SUBTRACTION  [3]MULTIPLICATION [4]DIVISION  [5]CHANGE INPUT STYLE [6]EXIT");
    
                    switch(Console.ReadLine())
                            {
                                case "1":

                                bool inAddition = true;
                
                                while(inAddition)
                                    {
                                        if (LinebyLine)
                                            {
                                                Console.WriteLine("ADDITION");
                    
                                                bool isValid = false;
                                                int myNumber = 0;
                                                int myNumber2 = 0;
                                                while(!isValid)
                                                    {
                                                        Console.WriteLine("CHOOSE YOUR NUMBER AND PRESS [ENTER]");
                     
                                                        string someString = Console.ReadLine();
                                                        isValid = int.TryParse(someString, out myNumber);

                                                        if (!isValid)
                                                        Console.WriteLine("INVALID INPUT, ENTER CORRECT INPUT");
                                                    }
                                                isValid = false;
                   
                                                    while(!isValid)
                    
                                                        {   
                     
                                                            Console.WriteLine("CHOOSE YOUR SECOND NUMBER AND PRESS [ENTER]");
                     
                                                            string someString = Console.ReadLine();
                                                            isValid = int.TryParse(someString, out myNumber2);

                                                             if (!isValid)
                                                            Console.WriteLine("INVALID INPUT, ENTER CORRECT INPUT");
                                                        }   

                                                            Console.WriteLine(Calculator.add(myNumber, myNumber2));

                                                            Console.WriteLine("[1] RETURN TO MAIN MENU");
                                                            string back = Console.ReadLine();

                                                            if (back == "1") break;
                                                            
                                            }
                                    }
                                    break;
                 }       
                        



                
            }
    
        }
    }



