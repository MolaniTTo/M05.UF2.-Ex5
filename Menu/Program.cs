using Metodes;

namespace M03.UF2.Ex2
{
    public class Ex2Project
    {
        public static void Main()
        {
            const string Validar = "1-Si vols validar un nombre senar";
            const string Potencia = "2-Si vols Calcular la potencia d'un nombre";
            const string Random = "3-Si vols un valor aleatori";
            const string ConsVocal = "4-Si vols comptar el nombre de vocals i consonants d'un text";
            const string Sortir = "5-Si vols sortir";

            Console.WriteLine(Validar);
            Console.WriteLine(Potencia);
            Console.WriteLine(Random);
            Console.WriteLine(ConsVocal);
            Console.WriteLine(Sortir);



            int funcionalitat;
            funcionalitat = Convert.ToInt32(Console.ReadLine());
            switch (funcionalitat)
            {
                case 1:
                    Console.WriteLine(Class1.Validacio());
                    break;

                case 2:
                    Console.WriteLine(Class1.Potencia());
                    break;
                case 3:
                    Console.WriteLine(Class1.Random());
                    break;

                case 4:
                    Console.WriteLine(Class1.Contador());
                    break;
                case 5:
                    Console.WriteLine(Class1.Adeu());
                    break;


            }

        }

    }
}
