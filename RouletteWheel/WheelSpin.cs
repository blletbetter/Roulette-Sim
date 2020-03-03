using System;
using System.Collections.Generic;
using System.Text;

namespace RouletteWheel
{
    class WheelSpin
    {
        public int[] WheelNum = new int[36]
            {
                1, 13, 36, 24, 3, 15, 34, 22, 5, 17, 32, 20, 7, 11, 30, 26, 9, 28,
                2, 14, 35, 23, 4, 16, 33, 21, 6, 18, 31, 19, 8, 12, 29, 25, 10, 27
            };
        public string[] Wheel = new string[38]
            {
                "00", "1", "13", "36", "24", "3", "15", "34", "22", "5", "17", "32", "20", "7", "11", "30", "26", "9", "28",
                "0", "2", "14", "35", "23", "4", "16", "33", "21", "6", "18", "31", "19", "8", "12", "29", "25", "10", "27"
            };
        public void Run()
        {
            
            Random random = new Random();
            int index = random.Next(Wheel.Length);
            Console.WriteLine("Welcome to the roulette wheel! \n \npress enter to continue...");
            Console.ReadKey();
            Console.WriteLine($"The ball landed on {Wheel[index]}");
            Console.WriteLine($"{Wheel[index]} is a winning bet!");
            if (Red(index) == true)
            {
                Console.WriteLine("Reds is a winning bet!");
            }
            if (Black(index) == true)
            {
                Console.WriteLine("Blacks is a winning bet!");
            }
            if (Low(index) == true)
            {
                Console.WriteLine("Lows is a winning bet!");
            }
            if (High(index) == true)
            {
                Console.WriteLine("Highs is a winning bet!");
            }
            if (Odd(index) == true)
            {
                Console.WriteLine("Odds is a winning bet!");
            }
            if (Even(index) == true)
            {
                Console.WriteLine("Evens is a winning bet!");
            }
            if (FirstThird(index) == true)
            {
                Console.WriteLine("First Third is a winning bet!");
            }
            if (SecondThird(index) == true)
            {
                Console.WriteLine("Second Third is a winning bet!");
            }
            if (FinalThird(index) == true)
            {
                Console.WriteLine("Final Third is a winning bet!");
            }
            if (Column1(index) == true)
            {
                Console.WriteLine("Column 1 is a winning bet!");
            }
            if (Column2(index) == true)
            {
                Console.WriteLine("Column 2 is a winning bet!");
            }
            if (Column3(index) == true)
            {
                Console.WriteLine("Column 3 is a winning bet!");
            }
            if (Row1(index) == true)
            {
                Console.WriteLine("Row 1 is a winning bet!");
            }
            if (Row2(index) == true)
            {
                Console.WriteLine("Row 2 is a winning bet!");
            }
            if (Row3(index) == true)
            {
                Console.WriteLine("Row 3 is a winning bet!");
            }
            if (Row4(index) == true)
            {
                Console.WriteLine("Row 4 is a winning bet!");
            }
            if (Row5(index) == true)
            {
                Console.WriteLine("Row 5 is a winning bet!");
            }
            if (Row6(index) == true)
            {
                Console.WriteLine("Row 6 is a winning bet!");
            }
            if (Row7(index) == true)
            {
                Console.WriteLine("Row 7 is a winning bet!");
            }
            if (Row8(index) == true)
            {
                Console.WriteLine("Row 8 is a winning bet!");
            }
            if (Row9(index) == true)
            {
                Console.WriteLine("Row 9 is a winning bet!");
            }
            if (Row10(index) == true)
            {
                Console.WriteLine("Row 10 is a winning bet!");
            }
            if (Row11(index) == true)
            {
                Console.WriteLine("Row 11 is a winning bet!");
            }
            if (Row12(index) == true)
            {
                Console.WriteLine("Row 12 is a winning bet!");
            }
            if (DoubleRow1(index) == true)
            {
                Console.WriteLine("Double Row 1 is a winning bet!");
            }
            if (DoubleRow2(index) == true)
            {
                Console.WriteLine("Double Row 2 is a winning bet!");
            }
            if (DoubleRow3(index) == true)
            {
                Console.WriteLine("Double Row 3 is a winning bet!");
            }
            if (DoubleRow4(index) == true)
            {
                Console.WriteLine("Double Row 4 is a winning bet!");
            }
            if (DoubleRow5(index) == true)
            {
                Console.WriteLine("Double Row 5 is a winning bet!");
            }
            if (DoubleRow6(index) == true)
            {
                Console.WriteLine("Double Row 6 is a winning bet!");
            }
            if (DoubleRow7(index) == true)
            {
                Console.WriteLine("Double Row 7 is a winning bet!");
            }
            if (DoubleRow8(index) == true)
            {
                Console.WriteLine("Double Row 8 is a winning bet!");
            }
            if (DoubleRow9(index) == true)
            {
                Console.WriteLine("Double Row 9 is a winning bet!");
            }
            if (DoubleRow10(index) == true)
            {
                Console.WriteLine("Double Row 10 is a winning bet!");
            }
            if (DoubleRow11(index) == true)
            {
                Console.WriteLine("Double Row 11 is a winning bet!");
            }
            for (int i = 1; i < 25; i++)
            {
                if (Split(index, i) == true)
                {
                    Console.WriteLine($"Split {i} is a winning bet!");
                }
            }
            for (int i = 1; i < 23; i++)
            {
                if (Corner(index, i) == true)
                {
                    Console.WriteLine($"Corner {i} is a winning bet!");
                }
            }
        }
        public bool Red(int i)
        {
            switch (i)
            {
                case 1:
                    return true;
                case 3:
                    return true;
                case 5:
                    return true;
                case 7:
                    return true;
                case 9:
                    return true;
                case 11:
                    return true;
                case 13:
                    return true;
                case 15:
                    return true;
                case 17:
                    return true;
                case 21:
                    return true;
                case 23:
                    return true;
                case 25:
                    return true;
                case 27:
                    return true;
                case 29:
                    return true;
                case 31:
                    return true;
                case 33:
                    return true;
                case 35:
                    return true;
                case 37:
                    return true;
                default:
                    return false;
            }
        }
        public bool Black(int i)
        {
            switch (i)
            {
                case 2:
                    return true;
                case 4:
                    return true;
                case 6:
                    return true;
                case 8:
                    return true;
                case 10:
                    return true;
                case 12:
                    return true;
                case 14:
                    return true;
                case 16:
                    return true;
                case 18:
                    return true;
                case 20:
                    return true;
                case 22:
                    return true;
                case 24:
                    return true;
                case 26:
                    return true;
                case 28:
                    return true;
                case 30:
                    return true;
                case 32:
                    return true;
                case 34:
                    return true;
                case 36:
                    return true;
                default:
                    return false;
            }
        }
        public bool Low(int i)
        {
            if (i == 0 || i == 19)
            {
                return false;
            }
            if (i < 19)
            {
                if (WheelNum[i - 1] <= 18)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            if (i > 19)
            {
                if (WheelNum[i - 2] <= 18)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public bool High(int i)
        {
            if (i == 0 || i == 19)
            {
                return false;
            }
            if (i < 19)
            {
                if (WheelNum[i - 1] > 18)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            if (i > 19)
            {
                if (WheelNum[i - 2] > 18)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public bool Odd(int i)
        {
            if (i == 0 || i == 19)
            {
                return false;
            }
            if (i < 19)
            {
                if (WheelNum[i - 1] % 2 > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            if (i > 19)
            {
                if (WheelNum[i - 2] % 2 > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

        }
        public bool Even(int i)
        {
            if (i == 0 || i == 19)
            {
                return false;
            }
            if (i < 19)
            {
                if (WheelNum[i - 1] % 2 > 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            if (i > 19)
            {
                if (WheelNum[i - 2] % 2 > 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }

        }
        public bool FirstThird(int i)
        {
            if (i == 0 || i == 19)
            {
                return false;
            }
            if (i < 19)
            {
                if (WheelNum[i - 1] <= 12)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            if (i > 19)
            {
                if (WheelNum[i - 2] <= 12)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public bool SecondThird(int i)
        {
            if (i == 0 || i == 19)
            {
                return false;
            }
            if (i < 19)
            {
                if (WheelNum[i - 1] > 12 && WheelNum[i - 1] <= 24)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            if (i > 19)
            {
                if (WheelNum[i - 2] > 12 && WheelNum[i - 2] <= 24)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public bool FinalThird(int i)
        {
            if (i == 0 || i == 19)
            {
                return false;
            }
            if (i < 19)
            {
                if (WheelNum[i - 1] > 24 && WheelNum[i - 1] <= 36)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            if (i > 19)
            {
                if (WheelNum[i - 2] > 24 && WheelNum[i - 2] <= 36)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public bool Column1(int i)
        {
            if (i == 0 || i == 19)
            {
                return false;
            }
            if (i < 19)
            {
                switch (WheelNum[i - 1])
                {
                    case 1:
                        return true;
                    case 4:
                        return true;
                    case 7:
                        return true;
                    case 10:
                        return true;
                    case 13:
                        return true;
                    case 16:
                        return true;
                    case 19:
                        return true;
                    case 22:
                        return true;
                    case 25:
                        return true;
                    case 28:
                        return true;
                    case 31:
                        return true;
                    case 34:
                        return true;
                    default:
                        return false;
                }

            }
            if (i > 19)
            {
                switch (WheelNum[i - 2])
                {
                    case 1:
                        return true;
                    case 4:
                        return true;
                    case 7:
                        return true;
                    case 10:
                        return true;
                    case 13:
                        return true;
                    case 16:
                        return true;
                    case 19:
                        return true;
                    case 22:
                        return true;
                    case 25:
                        return true;
                    case 28:
                        return true;
                    case 31:
                        return true;
                    case 34:
                        return true;
                    default:
                        return false;
                }
            }
            else
            {
                return false;
            }
        }
        public bool Column2(int i)
        {
            if (i == 0 || i == 19)
            {
                return false;
            }
            if (i < 19)
            {
                switch (WheelNum[i - 1])
                {
                    case 2:
                        return true;
                    case 5:
                        return true;
                    case 8:
                        return true;
                    case 11:
                        return true;
                    case 14:
                        return true;
                    case 17:
                        return true;
                    case 20:
                        return true;
                    case 23:
                        return true;
                    case 26:
                        return true;
                    case 29:
                        return true;
                    case 32:
                        return true;
                    case 35:
                        return true;
                    default:
                        return false;
                }

            }
            if (i > 19)
            {
                switch (WheelNum[i - 2])
                {
                    case 2:
                        return true;
                    case 5:
                        return true;
                    case 8:
                        return true;
                    case 11:
                        return true;
                    case 14:
                        return true;
                    case 17:
                        return true;
                    case 20:
                        return true;
                    case 23:
                        return true;
                    case 26:
                        return true;
                    case 29:
                        return true;
                    case 32:
                        return true;
                    case 35:
                        return true;
                    default:
                        return false;
                }
            }
            else
            {
                return false;
            }
        }
        public bool Column3(int i)
        {
            if (i == 0 || i == 19)
            {
                return false;
            }
            if (i < 19)
            {
                switch (WheelNum[i - 1])
                {
                    case 3:
                        return true;
                    case 6:
                        return true;
                    case 9:
                        return true;
                    case 12:
                        return true;
                    case 15:
                        return true;
                    case 18:
                        return true;
                    case 21:
                        return true;
                    case 24:
                        return true;
                    case 27:
                        return true;
                    case 30:
                        return true;
                    case 33:
                        return true;
                    case 36:
                        return true;
                    default:
                        return false;
                }

            }
            if (i > 19)
            {
                switch (WheelNum[i - 2])
                {
                    case 3:
                        return true;
                    case 6:
                        return true;
                    case 9:
                        return true;
                    case 12:
                        return true;
                    case 15:
                        return true;
                    case 18:
                        return true;
                    case 21:
                        return true;
                    case 24:
                        return true;
                    case 27:
                        return true;
                    case 30:
                        return true;
                    case 33:
                        return true;
                    case 36:
                        return true;
                    default:
                        return false;
                }
            }
            else
            {
                return false;
            }
        }
        public bool Row1(int i)
        {
            switch (Wheel[i])
            {
                case "1":
                    return true;
                case "2":
                    return true;
                case "3":
                    return true;
                default:
                    return false;
            }
        }
        public bool Row2(int i)
        {
            switch (Wheel[i])
            {
                case "4":
                    return true;
                case "5":
                    return true;
                case "6":
                    return true;
                default:
                    return false;
            }
        }
        public bool Row3(int i)
        {
            switch (Wheel[i])
            {
                case "7":
                    return true;
                case "8":
                    return true;
                case "9":
                    return true;
                default:
                    return false;
            }
        }
        public bool Row4(int i)
        {
            switch (Wheel[i])
            {
                case "10":
                    return true;
                case "11":
                    return true;
                case "12":
                    return true;
                default:
                    return false;
            }
        }
        public bool Row5(int i)
        {
            switch (Wheel[i])
            {
                case "13":
                    return true;
                case "14":
                    return true;
                case "15":
                    return true;
                default:
                    return false;
            }
        }
        public bool Row6(int i)
        {
            switch (Wheel[i])
            {
                case "16":
                    return true;
                case "17":
                    return true;
                case "18":
                    return true;
                default:
                    return false;
            }
        }
        public bool Row7(int i)
        {
            switch (Wheel[i])
            {
                case "19":
                    return true;
                case "20":
                    return true;
                case "21":
                    return true;
                default:
                    return false;
            }
        }
        public bool Row8(int i)
        {
            switch (Wheel[i])
            {
                case "22":
                    return true;
                case "23":
                    return true;
                case "24":
                    return true;
                default:
                    return false;
            }
        }
        public bool Row9(int i)
        {
            switch (Wheel[i])
            {
                case "25":
                    return true;
                case "26":
                    return true;
                case "27":
                    return true;
                default:
                    return false;
            }
        }
        public bool Row10(int i)
        {
            switch (Wheel[i])
            {
                case "28":
                    return true;
                case "29":
                    return true;
                case "30":
                    return true;
                default:
                    return false;
            }
        }
        public bool Row11(int i)
        {
            switch (Wheel[i])
            {
                case "31":
                    return true;
                case "32":
                    return true;
                case "33":
                    return true;
                default:
                    return false;
            }
        }
        public bool Row12(int i)
        {
            switch (Wheel[i])
            {
                case "34":
                    return true;
                case "35":
                    return true;
                case "36":
                    return true;
                default:
                    return false;
            }
        }
        public bool DoubleRow1(int i)
        {
            if (Row1(i) == true || Row2(i) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool DoubleRow2(int i)
        {
            if (Row2(i) == true || Row3(i) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool DoubleRow3(int i)
        {
            if (Row3(i) == true || Row4(i) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool DoubleRow4(int i)
        {
            if (Row4(i) == true || Row5(i) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool DoubleRow5(int i)
        {
            if (Row5(i) == true || Row6(i) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool DoubleRow6(int i)
        {
            if (Row6(i) == true || Row7(i) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool DoubleRow7(int i)
        {
            if (Row7(i) == true || Row8(i) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool DoubleRow8(int i)
        {
            if (Row8(i) == true || Row9(i) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool DoubleRow9(int i)
        {
            if (Row9(i) == true || Row10(i) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool DoubleRow10(int i)
        {
            if (Row10(i) == true || Row11(i) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool DoubleRow11(int i)
        {
            if (Row11(i) == true || Row12(i) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Split(int i, int input)
        {
            if (i == 0 || i == 19)
            {
                return false;
            }
            if (i < 19)
            {
                if ((WheelNum[i - 1] == 1 || WheelNum[i - 1] == 2) && input == 1)
                {
                    return true;
                }
                if ((WheelNum[i - 1] == 2 || WheelNum[i - 1] == 3) && input == 2)
                {
                    return true;
                }
                if ((WheelNum[i - 1] == 4 || WheelNum[i - 1] == 5) && input == 3)
                {
                    return true;
                }
                if ((WheelNum[i - 1] == 5 || WheelNum[i - 1] == 6) && input == 4)
                {
                    return true;
                }
                if ((WheelNum[i - 1] == 7 || WheelNum[i - 1] == 8) && input == 5)
                {
                    return true;
                }
                if ((WheelNum[i - 1] == 8 || WheelNum[i - 1] == 9) && input == 6)
                {
                    return true;
                }
                if ((WheelNum[i - 1] == 10 || WheelNum[i - 1] == 11) && input == 7)
                {
                    return true;
                }
                if ((WheelNum[i - 1] == 11 || WheelNum[i - 1] == 12) && input == 8)
                {
                    return true;
                }
                if ((WheelNum[i - 1] == 13 || WheelNum[i - 1] == 14) && input == 9)
                {
                    return true;
                }
                if ((WheelNum[i - 1] == 14 || WheelNum[i - 1] == 15) && input == 10)
                {
                    return true;
                }
                if ((WheelNum[i - 1] == 16 || WheelNum[i - 1] == 17) && input == 11)
                {
                    return true;
                }
                if ((WheelNum[i - 1] == 17 || WheelNum[i - 1] == 18) && input == 12)
                {
                    return true;
                }
                if ((WheelNum[i - 1] == 19 || WheelNum[i - 1] == 20) && input == 13)
                {
                    return true;
                }
                if ((WheelNum[i - 1] == 20 || WheelNum[i - 1] == 21) && input == 14)
                {
                    return true;
                }
                if ((WheelNum[i - 1] == 22 || WheelNum[i - 1] == 23) && input == 15)
                {
                    return true;
                }
                if ((WheelNum[i - 1] == 23 || WheelNum[i - 1] == 24) && input == 16)
                {
                    return true;
                }
                if ((WheelNum[i - 1] == 25 || WheelNum[i - 1] == 26) && input == 17)
                {
                    return true;
                }
                if ((WheelNum[i - 1] == 26 || WheelNum[i - 1] == 27) && input == 18)
                {
                    return true;
                }
                if ((WheelNum[i - 1] == 28 || WheelNum[i - 1] == 29) && input == 19)
                {
                    return true;
                }
                if ((WheelNum[i - 1] == 29 || WheelNum[i - 1] == 30) && input == 20)
                {
                    return true;
                }
                if ((WheelNum[i - 1] == 31 || WheelNum[i - 1] == 32) && input == 21)
                {
                    return true;
                }
                if ((WheelNum[i - 1] == 32 || WheelNum[i - 1] == 33) && input == 22)
                {
                    return true;
                }
                if ((WheelNum[i - 1] == 34 || WheelNum[i - 1] == 35) && input == 23)
                {
                    return true;
                }
                if ((WheelNum[i - 1] == 35 || WheelNum[i - 1] == 36) && input == 24)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            if (i > 19)
            {
                if ((WheelNum[i - 2] == 1 || WheelNum[i - 2] == 2) && input == 1)
                {
                    return true;
                }
                if ((WheelNum[i - 2] == 2 || WheelNum[i - 2] == 3) && input == 2)
                {
                    return true;
                }
                if ((WheelNum[i - 2] == 4 || WheelNum[i - 2] == 5) && input == 3)
                {
                    return true;
                }
                if ((WheelNum[i - 2] == 5 || WheelNum[i - 2] == 6) && input == 4)
                {
                    return true;
                }
                if ((WheelNum[i - 2] == 7 || WheelNum[i - 2] == 8) && input == 5)
                {
                    return true;
                }
                if ((WheelNum[i - 2] == 8 || WheelNum[i - 2] == 9) && input == 6)
                {
                    return true;
                }
                if ((WheelNum[i - 2] == 10 || WheelNum[i - 2] == 11) && input == 7)
                {
                    return true;
                }
                if ((WheelNum[i - 2] == 11 || WheelNum[i - 2] == 12) && input == 8)
                {
                    return true;
                }
                if ((WheelNum[i - 2] == 13 || WheelNum[i - 2] == 14) && input == 9)
                {
                    return true;
                }
                if ((WheelNum[i - 2] == 14 || WheelNum[i - 2] == 15) && input == 10)
                {
                    return true;
                }
                if ((WheelNum[i - 2] == 16 || WheelNum[i - 2] == 17) && input == 11)
                {
                    return true;
                }
                if ((WheelNum[i - 2] == 17 || WheelNum[i - 2] == 18) && input == 12)
                {
                    return true;
                }
                if ((WheelNum[i - 2] == 19 || WheelNum[i - 2] == 20) && input == 13)
                {
                    return true;
                }
                if ((WheelNum[i - 2] == 20 || WheelNum[i - 2] == 21) && input == 14)
                {
                    return true;
                }
                if ((WheelNum[i - 2] == 22 || WheelNum[i - 2] == 23) && input == 15)
                {
                    return true;
                }
                if ((WheelNum[i - 2] == 23 || WheelNum[i - 2] == 24) && input == 16)
                {
                    return true;
                }
                if ((WheelNum[i - 2] == 25 || WheelNum[i - 2] == 26) && input == 17)
                {
                    return true;
                }
                if ((WheelNum[i - 2] == 26 || WheelNum[i - 2] == 27) && input == 18)
                {
                    return true;
                }
                if ((WheelNum[i - 2] == 28 || WheelNum[i - 2] == 29) && input == 19)
                {
                    return true;
                }
                if ((WheelNum[i - 2] == 29 || WheelNum[i - 2] == 30) && input == 20)
                {
                    return true;
                }
                if ((WheelNum[i - 2] == 31 || WheelNum[i - 2] == 32) && input == 21)
                {
                    return true;
                }
                if ((WheelNum[i - 2] == 32 || WheelNum[i - 2] == 33) && input == 22)
                {
                    return true;
                }
                if ((WheelNum[i - 2] == 34 || WheelNum[i - 2] == 35) && input == 23)
                {
                    return true;
                }
                if ((WheelNum[i - 2] == 35 || WheelNum[i - 2] == 36) && input == 24)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public bool Corner(int i, int input)
        {
            if (i == 0 || i == 19)
            {
                return false;
            }
            if (i < 19)
            {
                if ((WheelNum[i - 1] == 1 || WheelNum[i - 1] == 2 || WheelNum[i - 1] == 4 || WheelNum[i - 1] == 5) && input == 1)
                    return true;
                if ((WheelNum[i - 1] == 3 || WheelNum[i - 1] == 6 || WheelNum[i - 1] == 2 || WheelNum[i - 1] == 5) && input == 2)
                    return true;
                if ((WheelNum[i - 1] == 7 || WheelNum[i - 1] == 8 || WheelNum[i - 1] == 4 || WheelNum[i - 1] == 5) && input == 3)
                    return true;
                if ((WheelNum[i - 1] == 6 || WheelNum[i - 1] == 8 || WheelNum[i - 1] == 9 || WheelNum[i - 1] == 5) && input == 4)
                    return true;
                if ((WheelNum[i - 1] == 7 || WheelNum[i - 1] == 8 || WheelNum[i - 1] == 10 || WheelNum[i - 1] == 11) && input == 5)
                    return true;
                if ((WheelNum[i - 1] == 11 || WheelNum[i - 1] == 8 || WheelNum[i - 1] == 9 || WheelNum[i - 1] == 12) && input == 6)
                    return true;
                if ((WheelNum[i - 1] == 10 || WheelNum[i - 1] == 11 || WheelNum[i - 1] == 13 || WheelNum[i - 1] == 14) && input == 7)
                    return true;
                if ((WheelNum[i - 1] == 12 || WheelNum[i - 1] == 11 || WheelNum[i - 1] == 15 || WheelNum[i - 1] == 14) && input == 8)
                    return true;
                if ((WheelNum[i - 1] == 13 || WheelNum[i - 1] == 16 || WheelNum[i - 1] == 17 || WheelNum[i - 1] == 14) && input == 9)
                    return true;
                if ((WheelNum[i - 1] == 18 || WheelNum[i - 1] == 15 || WheelNum[i - 1] == 17 || WheelNum[i - 1] == 14) && input == 10)
                    return true;
                if ((WheelNum[i - 1] == 16 || WheelNum[i - 1] == 19 || WheelNum[i - 1] == 17 || WheelNum[i - 1] == 20) && input == 11)
                    return true;
                if ((WheelNum[i - 1] == 18 || WheelNum[i - 1] == 21 || WheelNum[i - 1] == 17 || WheelNum[i - 1] == 20) && input == 12)
                    return true;
                if ((WheelNum[i - 1] == 20 || WheelNum[i - 1] == 19 || WheelNum[i - 1] == 23 || WheelNum[i - 1] == 20) && input == 13)
                    return true;
                if ((WheelNum[i - 1] == 24 || WheelNum[i - 1] == 21 || WheelNum[i - 1] == 23 || WheelNum[i - 1] == 20) && input == 14)
                    return true;
                if ((WheelNum[i - 1] == 22 || WheelNum[i - 1] == 25 || WheelNum[i - 1] == 23 || WheelNum[i - 1] == 26) && input == 15)
                    return true;
                if ((WheelNum[i - 1] == 24 || WheelNum[i - 1] == 27 || WheelNum[i - 1] == 23 || WheelNum[i - 1] == 26) && input == 16)
                    return true;
                if ((WheelNum[i - 1] == 25 || WheelNum[i - 1] == 28 || WheelNum[i - 1] == 29 || WheelNum[i - 1] == 26) && input == 17)
                    return true;
                if ((WheelNum[i - 1] == 27 || WheelNum[i - 1] == 30 || WheelNum[i - 1] == 29 || WheelNum[i - 1] == 26) && input == 18)
                    return true;
                if ((WheelNum[i - 1] == 28 || WheelNum[i - 1] == 31 || WheelNum[i - 1] == 29 || WheelNum[i - 1] == 32) && input == 19)
                    return true;
                if ((WheelNum[i - 1] == 30 || WheelNum[i - 1] == 33 || WheelNum[i - 1] == 29 || WheelNum[i - 1] == 32) && input == 20)
                    return true;
                if ((WheelNum[i - 1] == 34 || WheelNum[i - 1] == 31 || WheelNum[i - 1] == 35 || WheelNum[i - 1] == 32) && input == 21)
                    return true;
                if ((WheelNum[i - 1] == 36 || WheelNum[i - 1] == 33 || WheelNum[i - 1] == 35 || WheelNum[i - 1] == 32) && input == 22)
                    return true;
                else
                    return false;
            }
            if (i > 19)
            {
                if ((WheelNum[i - 2] == 1 || WheelNum[i - 2] == 2 || WheelNum[i - 2] == 4 || WheelNum[i - 2] == 5) && input == 1)
                    return true;
                if ((WheelNum[i - 2] == 3 || WheelNum[i - 2] == 6 || WheelNum[i - 2] == 2 || WheelNum[i - 2] == 5) && input == 2)
                    return true;
                if ((WheelNum[i - 2] == 7 || WheelNum[i - 2] == 8 || WheelNum[i - 2] == 4 || WheelNum[i - 2] == 5) && input == 3)
                    return true;
                if ((WheelNum[i - 2] == 6 || WheelNum[i - 2] == 8 || WheelNum[i - 2] == 9 || WheelNum[i - 2] == 5) && input == 4)
                    return true;
                if ((WheelNum[i - 2] == 7 || WheelNum[i - 2] == 8 || WheelNum[i - 2] == 10 || WheelNum[i - 2] == 11) && input == 5)
                    return true;
                if ((WheelNum[i - 2] == 11 || WheelNum[i - 2] == 8 || WheelNum[i - 2] == 9 || WheelNum[i - 2] == 12) && input == 6)
                    return true;
                if ((WheelNum[i - 2] == 10 || WheelNum[i - 2] == 11 || WheelNum[i - 2] == 13 || WheelNum[i - 2] == 14) && input == 7)
                    return true;
                if ((WheelNum[i - 2] == 12 || WheelNum[i - 2] == 11 || WheelNum[i - 2] == 15 || WheelNum[i - 2] == 14) && input == 8)
                    return true;
                if ((WheelNum[i - 2] == 13 || WheelNum[i - 2] == 16 || WheelNum[i - 2] == 17 || WheelNum[i - 2] == 14) && input == 9)
                    return true;
                if ((WheelNum[i - 2] == 18 || WheelNum[i - 2] == 15 || WheelNum[i - 2] == 17 || WheelNum[i - 2] == 14) && input == 10)
                    return true;
                if ((WheelNum[i - 2] == 16 || WheelNum[i - 2] == 19 || WheelNum[i - 2] == 17 || WheelNum[i - 2] == 20) && input == 11)
                    return true;
                if ((WheelNum[i - 2] == 18 || WheelNum[i - 2] == 21 || WheelNum[i - 2] == 17 || WheelNum[i - 2] == 20) && input == 12)
                    return true;
                if ((WheelNum[i - 2] == 20 || WheelNum[i - 2] == 19 || WheelNum[i - 2] == 23 || WheelNum[i - 2] == 20) && input == 13)
                    return true;
                if ((WheelNum[i - 2] == 24 || WheelNum[i - 2] == 21 || WheelNum[i - 2] == 23 || WheelNum[i - 2] == 20) && input == 14)
                    return true;
                if ((WheelNum[i - 2] == 22 || WheelNum[i - 2] == 25 || WheelNum[i - 2] == 23 || WheelNum[i - 2] == 26) && input == 15)
                    return true;
                if ((WheelNum[i - 2] == 24 || WheelNum[i - 2] == 27 || WheelNum[i - 2] == 23 || WheelNum[i - 2] == 26) && input == 16)
                    return true;
                if ((WheelNum[i - 2] == 25 || WheelNum[i - 2] == 28 || WheelNum[i - 2] == 29 || WheelNum[i - 2] == 26) && input == 17)
                    return true;
                if ((WheelNum[i - 2] == 27 || WheelNum[i - 2] == 30 || WheelNum[i - 2] == 29 || WheelNum[i - 2] == 26) && input == 18)
                    return true;
                if ((WheelNum[i - 2] == 28 || WheelNum[i - 2] == 31 || WheelNum[i - 2] == 29 || WheelNum[i - 2] == 32) && input == 19)
                    return true;
                if ((WheelNum[i - 2] == 30 || WheelNum[i - 2] == 33 || WheelNum[i - 2] == 29 || WheelNum[i - 2] == 32) && input == 20)
                    return true;
                if ((WheelNum[i - 2] == 34 || WheelNum[i - 2] == 31 || WheelNum[i - 2] == 35 || WheelNum[i - 2] == 32) && input == 21)
                    return true;
                if ((WheelNum[i - 2] == 36 || WheelNum[i - 2] == 33 || WheelNum[i - 2] == 35 || WheelNum[i - 1] == 32) && input == 22)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }
    }
}
