using System;

namespace GP_opg_regnespil
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowMenu();

        }

        #region GetAddition method  
        static void GetAddition()
        {
            Random rndNumber = new Random();  
            int score = 0;
            int wrongCounter = 0;
            bool wrongNumber = false;         
            int rndNumber1 = 0;
            int rndNumber2 = 0; 
            int rightCount = 0;
            Console.WriteLine("Choose a difficulty from (1-3)");
            int difficulty = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            int answer = 0;
            int difficulty1 = 0;
            int difficulty2 = 0;
            int difficulty3 = 0;
            int pointsTotal = difficulty1 + difficulty2 + difficulty3;
            while (rightCount < 4)
            {
                if (wrongNumber == false)
                {
                    rightCount++;
                    if(difficulty == 1) {
                        rndNumber1 = rndNumber.Next(1, 10);
                        rndNumber2 = rndNumber.Next(1, 10);
                    }
                    else if(difficulty == 2)
                    {
                        rndNumber1 = rndNumber.Next(10, 100);
                        rndNumber2 = rndNumber.Next(10, 100);
                    }
                    else if (difficulty == 3)
                    {
                        rndNumber1 = rndNumber.Next(100, 1000);
                        rndNumber2 = rndNumber.Next(100, 1000);
                    }
                    else
                    {
                        rndNumber1 = rndNumber.Next(1, 10);
                        rndNumber2 = rndNumber.Next(1, 10);
                    }
                    Console.WriteLine("What is {0} plus {1} equal to?", rndNumber1, rndNumber2);
                    pointsTotal = difficulty1 + difficulty2 + difficulty3;
                    answer = Convert.ToInt32(Console.ReadLine());
                }

                int answerHelp = rndNumber1 + rndNumber2;
                if (answer == rndNumber1 + rndNumber2)
                {
                    if (difficulty == 1)
                    {
                        difficulty1 = difficulty1 + 1;
                    }
                    else if (difficulty == 2)
                    {
                        difficulty2 = difficulty2 + 10;
                    }
                    else if (difficulty == 3)
                    {
                        difficulty3 = difficulty3 + 100;
                    }
                    wrongNumber = false;
                    Console.Clear();
                    Console.WriteLine("You are correct\n");
                    score++;
                    pointsTotal = difficulty1 + difficulty2 + difficulty3;
                }
                else if(wrongCounter == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Incorrect for the 3rd time!!!\n");
                    Console.WriteLine("Svaret er: {0}\n", answerHelp);
                    wrongNumber = false;
                    wrongCounter = 0;
                }
                else
                {
                    Console.WriteLine("Incorrect try again!\n");
                    wrongNumber = true;
                    wrongCounter++;
                    answer = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("\nYour total points is {0}", pointsTotal);
        }
        #endregion

        #region GetMinus method  
        static void GetMinus()
        {
            Random rndNumber = new Random();
            int score = 0;
            int wrongCounter = 0;
            bool wrongNumber = false;
            int rndNumber1 = 0;
            int rndNumber2 = 0;
            int rightCount = 0;
            Console.WriteLine("Choose a difficulty from (1-3)");
            int difficulty = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            int answer = 0;
            int difficulty1 = 0;
            int difficulty2 = 0;
            int difficulty3 = 0;
            int pointsTotal = difficulty1 + difficulty2 + difficulty3;
            while (rightCount < 10)
            {
                if (wrongNumber == false)
                {
                    rightCount++;
                    if (difficulty == 1)
                    {
                        rndNumber1 = rndNumber.Next(1, 10);
                        rndNumber2 = rndNumber.Next(1, 5);
                    }
                    else if (difficulty == 2)
                    {
                        rndNumber1 = rndNumber.Next(10, 100);
                        rndNumber2 = rndNumber.Next(10, 100);
                    }
                    else if (difficulty == 3)
                    {
                        rndNumber1 = rndNumber.Next(100, 1000);
                        rndNumber2 = rndNumber.Next(100, 1000);
                    }
                    else
                    {
                        rndNumber1 = rndNumber.Next(1, 10);
                        rndNumber2 = rndNumber.Next(1, 10);
                    }
                    Console.WriteLine("What is {0} minus {1} equal to?", rndNumber1, rndNumber2);
                    pointsTotal = difficulty1 + difficulty2 + difficulty3;
                    answer = Convert.ToInt32(Console.ReadLine());
                }

                int answerHelp = rndNumber1 - rndNumber2;
                if (answer == rndNumber1 - rndNumber2)
                {
                    if (difficulty == 1)
                    {
                        difficulty1 = difficulty1 + 1;
                    }
                    else if (difficulty == 2)
                    {
                        difficulty2 = difficulty2 + 10;
                    }
                    else if (difficulty == 3)
                    {
                        difficulty3 = difficulty3 + 100;
                    }
                    wrongNumber = false;
                    Console.Clear();
                    Console.WriteLine("You are correct\n");
                    score++;
                    pointsTotal = difficulty1 + difficulty2 + difficulty3;
                }
                else if (wrongCounter == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Incorrect for the 3rd time!!!\n");
                    Console.WriteLine("Svaret er: {0}\n", answerHelp);
                    wrongNumber = false;
                    wrongCounter = 0;
                }
                else
                {
                    Console.WriteLine("Incorrect try again!\n");
                    wrongNumber = true;
                    wrongCounter++;
                    answer = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("\nYour total points is {0}", pointsTotal);
        }
        #endregion

        #region GetMultiplication method  
        static void GetMultiplicaton()
        {
            Random rndNumber = new Random();
            int score = 0;
            int wrongCounter = 0;
            bool wrongNumber = false;
            int rndNumber1 = 0;
            int rndNumber2 = 0;
            int rightCount = 0;
            Console.WriteLine("Choose a difficulty from (1-3)");
            int difficulty = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            int answer = 0;
            int difficulty1 = 0;
            int difficulty2 = 0;
            int difficulty3 = 0;
            int pointsTotal = difficulty1 + difficulty2 + difficulty3;
            while (rightCount < 10)
            {
                if (wrongNumber == false)
                {
                    rightCount++;
                    if (difficulty == 1)
                    {
                        rndNumber1 = rndNumber.Next(1, 10);
                        rndNumber2 = rndNumber.Next(1, 10);
                    }
                    else if (difficulty == 2)
                    {
                        rndNumber1 = rndNumber.Next(10, 100);
                        rndNumber2 = rndNumber.Next(10, 100);
                    }
                    else if (difficulty == 3)
                    {
                        rndNumber1 = rndNumber.Next(100, 1000);
                        rndNumber2 = rndNumber.Next(100, 1000);
                    }
                    else
                    {
                        rndNumber1 = rndNumber.Next(1, 10);
                        rndNumber2 = rndNumber.Next(1, 10);
                    }
                    Console.WriteLine("What is {0} times {1} equal to?", rndNumber1, rndNumber2);
                    pointsTotal = difficulty1 + difficulty2 + difficulty3;
                    answer = Convert.ToInt32(Console.ReadLine());
                }

                int answerHelp = rndNumber1 * rndNumber2;
                if (answer == rndNumber1 * rndNumber2)
                {
                    if (difficulty == 1)
                    {
                        difficulty1 = difficulty1 + 1;
                    }
                    else if (difficulty == 2)
                    {
                        difficulty2 = difficulty2 + 10;
                    }
                    else if (difficulty == 3)
                    {
                        difficulty3 = difficulty3 + 100;
                    }
                    wrongNumber = false;
                    Console.Clear();
                    Console.WriteLine("You are correct\n");
                    score++;
                    pointsTotal = difficulty1 + difficulty2 + difficulty3;
                }
                else if (wrongCounter == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Incorrect for the 3rd time!!!\n");
                    Console.WriteLine("Svaret er: {0}\n", answerHelp);
                    wrongNumber = false;
                    wrongCounter = 0;
                }
                else
                {
                    Console.WriteLine("Incorrect try again!\n");
                    wrongNumber = true;
                    wrongCounter++;
                    answer = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("\nYour total points is {0}", pointsTotal);
        }
        #endregion

        #region GetDivision method  
        static void GetDivision()
        {
            Random rndNumber = new Random();
            int score = 0;
            int wrongCounter = 0;
            bool wrongNumber = false;
            float rndNumber1 = 0;
            float rndNumber2 = 0;
            float rightCount = 0;
            Console.WriteLine("Choose a difficulty from (1-3)");
            int difficulty = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            float answer = 0;
            int difficulty1 = 0;
            int difficulty2 = 0;
            int difficulty3 = 0;
            int pointsTotal = difficulty1 + difficulty2 + difficulty3;
            while (rightCount < 10)
            {
                if (wrongNumber == false)
                {
                    rightCount++;
                    if (difficulty == 1)
                    {
                        rndNumber1 = rndNumber.Next(1, 10);
                        rndNumber2 = rndNumber.Next(1, 4);
                    }
                    else if (difficulty == 2)
                    {
                        rndNumber1 = rndNumber.Next(10, 100);
                        rndNumber2 = rndNumber.Next(10, 100);
                    }
                    else if (difficulty == 3)
                    {
                        rndNumber1 = rndNumber.Next(100, 1000);
                        rndNumber2 = rndNumber.Next(100, 1000);
                    }
                    else
                    {
                        rndNumber1 = rndNumber.Next(1, 10);
                        rndNumber2 = rndNumber.Next(1, 10);
                    }
                    Console.WriteLine("What is {0} divided by {1} equal to?", rndNumber1, rndNumber2);
                    pointsTotal = difficulty1 + difficulty2 + difficulty3;
                    answer = Convert.ToInt32(Console.ReadLine());
                }

                float answerHelp = rndNumber1 / rndNumber2;
                if (answer == rndNumber1 / rndNumber2)
                {
                    if (difficulty == 1)
                    {
                        difficulty1 = difficulty1 + 1;
                    }
                    else if (difficulty == 2)
                    {
                        difficulty2 = difficulty2 + 10;
                    }
                    else if (difficulty == 3)
                    {
                        difficulty3 = difficulty3 + 100;
                    }
                    wrongNumber = false;
                    Console.Clear();
                    Console.WriteLine("You are correct\n");
                    score++;
                    pointsTotal = difficulty1 + difficulty2 + difficulty3;
                }
                else if (wrongCounter == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Incorrect for the 3rd time!!!\n");
                    Console.WriteLine("Svaret er: {0}\n", answerHelp);
                    wrongNumber = false;
                    wrongCounter = 0;
                }
                else
                {
                    Console.WriteLine("Incorrect try again!\n");
                    wrongNumber = true;
                    wrongCounter++;
                    answer = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("\nYour total points is {0}", pointsTotal);
        }
        #endregion

        #region Main Menu 
        static void ShowMenu()
        {
            bool menuCon = true;

            while (menuCon)
            {
                Console.WriteLine("Addition (a)");
                Console.WriteLine("Subtraktion (s)");
                Console.WriteLine("Multiplikation (m)");
                Console.WriteLine("Division (d)");
                Console.WriteLine("Exit (e)");

                string menu = Console.ReadLine();

                switch (menu)
                {
                    case "a":
                        Console.Clear();
                        GetAddition();
                        Console.WriteLine("\n");
                        break;

                    case "s":
                        Console.Clear();
                        GetMinus();
                        Console.WriteLine("\n");
                        break;

                    case "m":
                        Console.Clear();
                        GetMultiplicaton();
                        Console.WriteLine("\n");
                        break;

                    case "d":
                        Console.Clear();
                        GetDivision();
                        Console.WriteLine("\n");
                        break;

                    case "e":

                    default:
                        menuCon = false;
                        break;
                }
            }
        }
        #endregion

    }
}
