using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PROG2400A1NathanSaccon.Models
{
    public class InputData
    {

        public String Input = "";


        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public static string D2B(int dec)
        {
            string binary = Convert.ToString(dec, 2);

            return binary;
        }

        public static string D2B(string dec)
        {
            try
            {
                int number = Convert.ToInt32(dec);
                return D2B(number);
            }
            catch (Exception)
            {
                return "Non-valid D2B entry";
            }
            
        }

        public static string B2D(string bin)
        {
            try
            {
                return Convert.ToInt32(bin, 2).ToString();
            }
            catch (Exception)
            {
                return "Non-valid B2D entry";
            }
        }


    }
}
