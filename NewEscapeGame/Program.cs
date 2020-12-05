using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace NewEscapeGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("start text here");
            Console.ReadLine();
            int CandleTimer = 10;
            int LightCount = 0;
            int ChainCount = 0;

            if (CandleTimer > 0)
            {

                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("Input the number for where you want to go.");
                    Console.WriteLine("1 The Bed Room");
                    Console.WriteLine("2 The Basement");
                    Console.WriteLine("3 N/A");
                    Console.WriteLine("4 N/A");
                    Console.WriteLine("10 - Exit the game");
                    Console.WriteLine($"Candle Left: {CandleTimer}");


                    string action = Console.ReadLine();

                    Puzzles puzzles = new Puzzles();
                  
                    bool ticket2 = true;
                    bool ticket3 = true;
                    bool ticket4 = true;

                    switch (action)
                    {
                        case "1":
                            {
                                if (ChainCount == 0 & CandleTimer>0)
                                {
                                    puzzles.Chain();

                                    bool ticket1 = true;
                                    while (ticket1 == true & CandleTimer >0)
                                    {
                                        int InputChain = Int32.Parse(Console.ReadLine());
                                        int AnswerForChain = puzzles.ChainAnswers;

                                        if (InputChain == AnswerForChain)
                                        {
                                            Console.WriteLine("You are correct. Press Enter to select other rooms to search");
                                            ChainCount += 1;
                                            CandleTimer -= 1;
                                            Console.WriteLine($"Candle Left: {CandleTimer}");
                                            Console.ReadLine();
                                            Console.Clear();
                                            ticket1 = false;
                                            break;
                                        }
                                        else if (CandleTimer>0)
                                        {
                                            Console.WriteLine("Try again by Pressing Enter and inputnumer. Or press [10] to go back to room selection.");
                                            CandleTimer -= 1;
                                            Console.WriteLine($"Candle Left: {CandleTimer}");
                                            string actionChain = Console.ReadLine();
                                            switch (actionChain)
                                            {
                                                case "1":
                                                    {
                                                        Console.ReadLine();
                                                        break;//check
                                                    }
                                                case "10":
                                                    {
                                                        
                                                        ticket1=false;
                                                        break;
                                                    }
                                            }
                                        }continue;
                                    }
                                    continue;
                                }
                                else
                                {
                                    if (CandleTimer>0)
                                    {
                                        Console.WriteLine("There is nothing else I can do. Lets go another place.");
                                        Console.WriteLine("Press Enter to selection menu");
                                        Console.ReadLine();
                                        Console.Clear();
                                        continue;
                                        ////check later
                                    }
                                    else
                                    {
                                        Console.WriteLine("Game Over");
                                        Console.ReadLine();
                                        Environment.Exit(0);

                                        break;
                                    }
                                }
                            }
                        case "2":
                            {
                                if (LightCount == 0 & CandleTimer>0)
                                {
                                    puzzles.Light();
                                    int InputLight = Int16.Parse(Console.ReadLine());
                                    int AnswerForLight = puzzles.LightAnswers;

                                    //bool InputLight = Convert.ToBoolean(Console.ReadLine());
                                    while (ticket2 == true & CandleTimer>0)
                                    {
                                        if (InputLight == AnswerForLight)
                                        {
                                            Console.WriteLine("You are correct. Press Enter to select other rooms to search");
                                            LightCount += 1;
                                            CandleTimer -= 1;
                                            Console.WriteLine($"Candle Left: {CandleTimer}");
                                            Console.ReadLine();
                                            Console.Clear();
                                            ticket2 = false;
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Try again by Pressing Enter and inputnumer. Or press [10] to go back to room selection.");
                                            CandleTimer -= 1;
                                            Console.WriteLine($"Candle Left: {CandleTimer}");
                                            string actionLight = Console.ReadLine();
                                            switch (actionLight)
                                            {
                                                case "1":
                                                    {
                                                        break;
                                                        //check
                                                    }
                                                case "10":
                                                    {
                                                        ticket2 = false;
                                                        break;
                                                    }
                                            }
                                        }continue;
                                    }
                                    continue;
                                }
                                else
                                {
                                    if (CandleTimer>0)
                                    {
                                        Console.WriteLine("There is nothing else I can do. Lets go another place.");
                                        Console.ReadLine();
                                        Console.Clear();
                                        continue;

                                        ////check later
                                    }
                                    else
                                    {
                                        Console.WriteLine("Game Over");
                                        Console.ReadLine();
                                        Environment.Exit(0);

                                        break;
                                    }

                                }
                            }  
                        //case "3":
                            
                        //    break;

                        //case "4":
                           
                        //    break;

                        case "10":
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("You cannot go there. Please Input a valid responce. Hit return to try again");
                            Console.ReadLine();
                            continue;
                    }
                    if (LightCount == 1 & ChainCount==1 )
                    {
                        Console.WriteLine("you found a key and the path to exit");
                        Console.WriteLine("congratuaration");
                        Console.ReadLine();
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("Game Over");
                        Console.ReadLine();
                        Environment.Exit(0);

                        break;
                    }
                }
            }
        }

    }

}

