using System;
using System.Security.Cryptography;

namespace Metodes
{
    public class Class1
    {
        public static bool Validacio()
        {
            int num;
            Console.WriteLine("Introdueix un numero");
            num =Convert.ToInt32(Console.ReadLine());
              
            if (num%2==0) {return false;} 
            else { return true;}
        }
        public static int Potencia() 
        {
            int num, exp;
            Console.WriteLine("Introdueix un numero");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introdueix l'exponent");
            exp = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < exp; i++)
            {
                num = num * num;
            }
            return num;

        }
        public static string Random()
        {
            string s = "No l'he fet";
            return s;

        }


        public static string Contador()
        {
            string Text = "";
            int vocals = 0, consonants=0;
            
            Text = Console.ReadLine();
            foreach (char c in Text.ToCharArray() ) 
            {
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                {
                    vocals++;
                }
                else { consonants++; }

            }
            string retorn = $"El nombre de vocals és {vocals} i el de consonants és {consonants}";
            return retorn;

        }


        public static string Adeu()
        {
            const string MsgAdeu = "Fins aviat!";
            return MsgAdeu; 

        }


    }
}