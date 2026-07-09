
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
       { 
        bool inAddition = true;
                
        while(inAddition)
            {
                if (LinebyLine)
                    {
                        Console.WriteLine("ADDITION");

                        bool isValid = false;
                        decimal myNumber = 0;
                        decimal myNumber2 = 0;
                        while(!isValid)
                            {
                                Console.WriteLine("CHOOSE YOUR NUMBER AND PRESS [ENTER]");

                                string someString = Console.ReadLine();
                                isValid = decimal.TryParse(someString, out myNumber);

                                if (!isValid)
                                Console.WriteLine("INVALID INPUT, ENTER CORRECT INPUT");
                            }
                        isValid = false;

                            while(!isValid)

                                {   

                                    Console.WriteLine("CHOOSE YOUR SECOND NUMBER AND PRESS [ENTER]");

                                    string someString = Console.ReadLine();
                                    isValid = decimal.TryParse(someString, out myNumber2);

                                        if (!isValid)
                                    Console.WriteLine("INVALID INPUT, ENTER CORRECT INPUT");
                                }   

                                    Console.WriteLine(Calculator.add(myNumber, myNumber2));

                                    break;
                                                            
                    }
                else
                     {
                         Console.WriteLine("ADDITION \n CHOOSE YOUR NUMBERS AND ADD + AFTER EACH NUMBER");

                        bool isValid = false;
                        string input = Console.ReadLine();
                        string[]pieces = input.Split('+');

                        List<int> numbers = new List<int>();

                        while(true)
                        {
                            foreach(string num in pieces)
                            {
                                isValid = int.TryParse(num, out int myNumber);

                                if(!isValid)
                                    Console.WriteLine($"{num} could not be processed, here is the rest of the equation");


                                else
                                numbers.Add(myNumber);  
                            }
                            
                            Console.WriteLine(Calculator.addList(numbers));
                            
                             break;
                        }
                    }
                    break;

            }
            break;
    } 
     case "2":
       { 
        bool inSubtraction = true;
                
        while(inSubtraction)
            {
                if (LinebyLine)
                    {
                        Console.WriteLine("SUBTRACTION");

                        bool isValid = false;
                        decimal myNumber = 0;
                        decimal myNumber2 = 0;
                        while(!isValid)
                            {
                                Console.WriteLine("CHOOSE YOUR NUMBER AND PRESS [ENTER]");

                                string someString = Console.ReadLine();
                                isValid = decimal.TryParse(someString, out myNumber);

                                if (!isValid)
                                Console.WriteLine("INVALID INPUT, ENTER CORRECT INPUT");
                            }
                        isValid = false;

                            while(!isValid)

                                {   

                                    Console.WriteLine("CHOOSE YOUR SECOND NUMBER AND PRESS [ENTER]");

                                    string someString = Console.ReadLine();
                                    isValid = decimal.TryParse(someString, out myNumber2);

                                        if (!isValid)
                                    Console.WriteLine("INVALID INPUT, ENTER CORRECT INPUT");
                                }   

                                    Console.WriteLine(Calculator.sub(myNumber, myNumber2));

                                    break;
                                                            
                    }
                else
                     {
                         Console.WriteLine("SUBTRACTION \n CHOOSE YOUR NUMBERS AND ADD - AFTER EACH NUMBER");

                        bool isValid = false;
                        string input = Console.ReadLine();
                        string[]pieces = input.Split('-');

                        List<int> numbers = new List<int>();

                        while(true)
                        {
                            foreach(string num in pieces)
                            {
                                isValid = int.TryParse(num, out int myNumber);

                                if(!isValid)
                                   
                                    Console.WriteLine($"{num} could not be processed, here is the rest of the equation");


                                else
                                numbers.Add(myNumber);  
                            }
                            
                            Console.WriteLine(Calculator.subList(numbers));
                            
                             break;
                        }
                    }
                    break;

            }
            break;
    } 
      case "3":
       { 
        bool inMultiplication = true;
                
        while(inMultiplication)
            {
                if (LinebyLine)
                    {
                        Console.WriteLine("MULTIPLICATION");

                        bool isValid = false;
                        decimal myNumber = 0;
                        decimal myNumber2 = 0;
                        while(!isValid)
                            {
                                Console.WriteLine("CHOOSE YOUR NUMBER AND PRESS [ENTER]");

                                string someString = Console.ReadLine();
                                isValid = decimal.TryParse(someString, out myNumber);

                                if (!isValid)
                                Console.WriteLine("INVALID INPUT, ENTER CORRECT INPUT");
                            }
                        isValid = false;

                            while(!isValid)

                                {   

                                    Console.WriteLine("CHOOSE YOUR SECOND NUMBER AND PRESS [ENTER]");

                                    string someString = Console.ReadLine();
                                    isValid = decimal.TryParse(someString, out myNumber2);

                                        if (!isValid)
                                    Console.WriteLine("INVALID INPUT, ENTER CORRECT INPUT");
                                }   

                                    Console.WriteLine(Calculator.mult(myNumber, myNumber2));

                                    break;
                                                            
                    }
                else
                     {
                         Console.WriteLine("MULTIPLICATION \n CHOOSE YOUR NUMBERS AND ADD * AFTER EACH NUMBER");

                        bool isValid = false;
                        string input = Console.ReadLine();
                        string[]pieces = input.Split('*');

                        List<int> numbers = new List<int>();

                        while(true)
                        {
                            foreach(string num in pieces)
                            {
                                isValid = int.TryParse(num, out int myNumber);

                                if(!isValid)
                                   
                                    Console.WriteLine($"{num} could not be processed, here is the rest of the equation");


                                else
                                numbers.Add(myNumber);  
                            }
                            
                            Console.WriteLine(Calculator.multList(numbers));
                            
                             break;
                        }
                    }
                    break;

            }
            break;
    } 
    case "4":
       { 
        bool inDivision = true;
                
        while(inDivision)
            {
                if (LinebyLine)
                    {
                        Console.WriteLine("DIVISION");

                        bool isValid = false;
                        decimal myNumber = 0;
                        decimal myNumber2 = 0;
                        while(!isValid)
                            {
                                Console.WriteLine("CHOOSE YOUR NUMBER AND PRESS [ENTER]");

                                string someString = Console.ReadLine();
                                isValid = decimal.TryParse(someString, out myNumber);

                                if (!isValid)
                                Console.WriteLine("INVALID INPUT, ENTER CORRECT INPUT");
                            }
                        isValid = false;

                            while(!isValid)

                                {   

                                    Console.WriteLine("CHOOSE YOUR SECOND NUMBER AND PRESS [ENTER]");

                                    string someString = Console.ReadLine();
                                    isValid = decimal.TryParse(someString, out myNumber2);

                                        if (!isValid)
                                    Console.WriteLine("INVALID INPUT, ENTER CORRECT INPUT");
                                }   

                                    Console.WriteLine(Calculator.div(myNumber, myNumber2));

                                    break;
                                                            
                    }
                else
                     {
                         Console.WriteLine("DIVISION \n CHOOSE YOUR NUMBERS AND ADD * AFTER EACH NUMBER");

                        bool isValid = false;
                        string input = Console.ReadLine();
                        string[]pieces = input.Split('/');

                        List<int> numbers = new List<int>();

                        while(true)
                        {
                            foreach(string num in pieces)
                            {
                                isValid = int.TryParse(num, out int myNumber);

                                if(!isValid)
                                   
                                    Console.WriteLine($"{num} could not be processed, here is the rest of the equation");


                                else
                                numbers.Add(myNumber);  
                            }
                            
                            Console.WriteLine(Calculator.divList(numbers));
                            
                             break;
                        }
                    }
                    break;

            }
            break;
    } 
        case "5":
            {
            if(LinebyLine) LinebyLine = false;
            else LinebyLine = true;

            break;
            }
        case "6":
            {
             MainMenu = false;
             break;           
            }      
                
    }

    }

}
}



    



