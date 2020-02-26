using System;
using System.Collections.Generic;
using System.Linq;

namespace Practical6
{
    class Digit
    {
        //SeperateDigit from given Number
        public static int[] seperateDigit(int number, int[] n, int i)
        {
            while (number > 0 && i >= 0)
            {
                n[i] = number % 10;
                number /= 10;
                i--;
            }
            return n;
        }

        //PopAll Data From Stack
        public static String popalldata_Stack(Stack<String> s)
        {
            String temp = "";
            while (s.Count() > 0)
            {
                temp = temp + s.Pop() + " ";
            }
            temp = temp.Remove((temp.Length) - 1);
            return temp;
        }

        //Generate for One Digit
        public static String onedigit(int number)
        {

            switch (number)
            {
                case 1:
                    return ("One");
                case 2:
                    return ("Two");
                case 3:
                    return ("Three");
                case 4:
                    return ("Four");
                case 5:
                    return ("Five");
                case 6:
                    return ("Six");
                case 7:
                    return ("Seven");
                case 8:
                    return ("Eight");
                case 9:
                    return ("Nine");
                case 0:
                    return ("Zero");
            }
            return null;
        }

        //Generate for Two Digit
        public static String twodigit(int number)
        {
            if (number < 20)
            {
                switch (number)
                {
                    case 10:
                        return "Ten";
                    case 11:
                        return "Eleven";
                    case 12:
                        return "Twelve";
                    case 13:
                        return "Thirteen";
                    case 14:
                        return "Fourteen";
                    case 15:
                        return "Fifteen";
                    case 16:
                        return "Sixteen";
                    case 17:
                        return "Seventeen";
                    case 18:
                        return "Eighteen";
                    case 19:
                        return "Nineteen";
                }
            }
            else if (number >= 20)
            {
                String[] prefixname_twodigit = { "", "", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
                int[] n = new int[2];
                int i = 1;
                String temp;
                Stack<String> s = new Stack<String>();
                n = seperateDigit(number, n, i);
                if (n[1] == 0)
                {
                    temp = prefixname_twodigit[n[0]];
                    s.Push(temp);
                }
                else
                {
                    temp = Digit.onedigit(n[1]);
                    s.Push(temp);
                    temp = prefixname_twodigit[n[0]];
                    s.Push(temp);
                }
                temp = popalldata_Stack(s);
                return temp;
            }
            return null;
        }

        //Generate for Three Digit
        public static String threedigit(int number)
        {
            int[] n = new int[3];
            int i = 2;
            String temp;
            Stack<String> s = new Stack<String>();

            n = seperateDigit(number, n, i);

            if (n[2] == 0 && n[1] == 0)
            {
                s.Push("Hundred");
                temp = Digit.onedigit(n[0]);
                s.Push(temp);
            }
            else if (0 == n[1] && 0 != n[2])
            {
                temp = Digit.onedigit(n[2]);
                s.Push(temp);
                s.Push("Hundred");
                temp = Digit.onedigit(n[0]);
                s.Push(temp);
            }
            else
            {
                int t = (n[1] * 10) + n[2];
                temp = Digit.twodigit(t);
                s.Push(temp);
                s.Push("Hundred");
                temp = Digit.onedigit(n[0]);
                s.Push(temp);
            }

            temp = popalldata_Stack(s);
            return temp;
        }

        //Generate for Four Digit
        public static String fourdigit(int number)
        {
            int[] n = new int[4];
            int i = 3;
            String temp;
            Stack<String> s = new Stack<String>();

            n = seperateDigit(number, n, i);

            if (0 == n[1] && 0 == n[2] && 0 == n[3])
            {
                s.Push("Thousand");
                temp = Digit.onedigit(n[0]);
                s.Push(temp);
            }
            else if (0 == n[1] && 0 != n[2] && 0 != n[3])
            {
                int t = (n[2] * 10) + n[3];
                temp = Digit.twodigit(t);
                s.Push(temp);
                s.Push("Thousand");
                temp = Digit.onedigit(n[0]);
                s.Push(temp);
            }
            else
            {
                int t = (n[1] * 100) + (n[2] * 10) + n[3];
                temp = Digit.threedigit(t);
                s.Push(temp);
                s.Push("Thousand");
                temp = Digit.onedigit(n[0]);
                s.Push(temp);
            }

            temp = popalldata_Stack(s);
            return temp;
        }

        //Generate for five Digit
        public static String fivedigit(int number)
        {
            int[] n = new int[5];
            int i = 4;
            String temp;
            Stack<String> s = new Stack<String>();

            n = seperateDigit(number, n, i);

            if (0 == n[2] && 0 == n[3] && 0 == n[4])
            {
                s.Push("Thousand");
                int t = (n[0] * 10) + n[1];
                temp = Digit.twodigit(t);

            }
            else if (0 == n[1] && 0 == n[2] && 0 == n[3] && 0 != n[4])
            {
                int t;
                temp = Digit.onedigit(n[4]);
                s.Push(temp);
                s.Push("Thousand");
                t = (n[0] * 10) + n[1];
                temp = Digit.twodigit(t);
                s.Push(temp);
            }
            else if (0 == n[2] && 0 != n[3] && 0 != n[4])
            {
                int t = (n[3] * 10) + n[4];
                temp = Digit.twodigit(t);
                s.Push(temp);
                s.Push("Thousand");
                t = (n[0] * 10) + n[1];
                temp = Digit.twodigit(t);
                s.Push(temp);
            }
            else
            {
                int t = (n[2] * 100) + (n[3] * 10) + n[4];
                temp = Digit.threedigit(t);
                s.Push(temp);
                s.Push("Thousand");
                t = (n[0] * 10) + n[1];
                temp = Digit.twodigit(t);
                s.Push(temp);
            }

            temp = popalldata_Stack(s);
            return temp;
        }

        //Generate for six digit
        public static String sixdigit(int number)
        {
            int[] n = new int[6];
            int i = 5;
            String temp;
            Stack<String> s = new Stack<String>();

            n = seperateDigit(number, n, i);

            if (0 == n[1] && 0 == n[2] && 0 == n[3] && 0 == n[4] && 0 == n[5])
            {
                s.Push("Lakh");
                temp = Digit.onedigit(n[0]);
                s.Push(temp);
            }
            else if (0 == n[1] && 0 != n[2] && 0 != n[3] && 0 != n[4] && 0 != n[5])
            {
                int t;
                t = (n[2] * 1000) + (n[3] * 100) + (n[4] * 10) + n[5];
                temp = Digit.fourdigit(t);
                s.Push(temp);
                s.Push("Lakh");
                temp = Digit.onedigit(n[0]);
                s.Push(temp);
            }
            else if (0 == n[1] && 0 == n[2] && 0 != n[3] && 0 != n[4] && 0 != n[5])
            {
                int t;
                t = (n[3] * 100) + (n[4] * 10) + n[5];
                temp = Digit.threedigit(t);
                s.Push(temp);
                s.Push("Lakh");
                temp = Digit.onedigit(n[0]);
                s.Push(temp);
            }
            else if (0 == n[1] && 0 == n[2] && 0 == n[3] && 0 != n[4] && 0 != n[5])
            {
                int t;
                t = (n[4] * 10) + n[5];
                temp = Digit.twodigit(t);
                s.Push(temp);
                s.Push("Lakh");
                temp = Digit.onedigit(n[0]);
                s.Push(temp);
            }
            else if (0 != n[0] && 0 == n[1] && 0 == n[2] && 0 == n[3] && 0 == n[4] && 0 != n[5])
            {
                temp = Digit.onedigit(n[5]);
                s.Push(temp);
                s.Push("Lakh");
                temp = Digit.onedigit(n[0]);
                s.Push(temp);
            }
            else
            {
                int t;
                t = (n[1] * 10000) + (n[2] * 1000) + (n[3] * 100) + (n[4] * 10) + n[5];
                temp = Digit.fivedigit(t);
                s.Push(temp);
                s.Push("Lakh");
                temp = Digit.onedigit(n[0]);
                s.Push(temp);
            }

            temp = popalldata_Stack(s);
            return temp;
        }
    }
}