using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Validation
    {
        private static CatchErr err = new CatchErr();
        public static string CheckEmpty(string n)
        {
            while (true)
            {
                try
                {
                    n = Console.ReadLine();
                    if (n == null || n == "")
                    {
                        err.CatchEmpty = "Fill all information !";
                    }
                    else
                    {
                        break;
                    }
                }
                catch (Exception e)
                {
                    e.ToString();
                    err.CatchEmpty = "Please Try Again !";
                }
            }
            return n;
        }

        public static int CheckValidNumber(int n)
        {
            while (true)
            {
                try
                {
                    n = Convert.ToInt32(Console.ReadLine());
                    if (n < 0)
                    {
                        err.CatchInValidNumber = "Invalid Number !";
                    }
                    else
                    {
                        break;
                    }
                }
                catch (FormatException e)
                {
                    err.CatchInValidNumber = "Input number only !";
                }
            }
            return n;
        }

        public static float CheckValidPrice(float n)
        {
            while (true)
            {
                try
                {
                    n = float.Parse(Console.ReadLine());
                    if (n < 0)
                    {
                        err.CatchInValidNumber = "Invalid Number !";
                    }
                    else
                    {
                        break;
                    }
                }
                catch (FormatException e)
                {
                    err.CatchInValidNumber = "Input number only !";
                }
            }
            return n;
        }
    }
}
