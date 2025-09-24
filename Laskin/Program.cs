using System.Runtime.InteropServices;

namespace Laskin
{
    internal class Program
    {
        // Kysyy Laskutoimitusta
        static string ValitseLaskutoimitus()
        {
            while (true)
            {
                Console.WriteLine("Valitse laskutoimitus:");
                Console.WriteLine("1: Yhteenlasku (+)");
                Console.WriteLine("2: Vähennyslasku (-)");
                Console.WriteLine("3: Kertolasku (*)");
                Console.WriteLine("4: Jakolasku (/)");
                Console.Write("Syötä valintasi (1-4): ");
                string syote = Console.ReadLine();

                if (syote == "1" || syote == "2" || syote == "3" || syote == "4")
                {
                    return syote;
                }
                else
                {
                    Console.WriteLine("Virheellinen valinta. Yritä uudelleen.");
                } 
            }
        }

        // Syötä luvut 
        static int KysyLuku()
        {
            while (true)
            {
                Console.Write("Syötä luku: ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out int luku))
                    return luku;
                Console.WriteLine("Virheellinen syöte. Yritä uudelleen.");

            }
            
        }


        //Yhteenlasku
        static int Yhteenlasku(int a, int b)
        {
            return a + b;
        }

        //Vähennyslasku
        static int Vähennyslasku(int a, int b)
        {
            return a - b;
        }

        //kertolasku 
        static int kertolasku(int a, int b)
        {
            return a * b;
        }

        //Jakolasku
        static double Jakolasku(int a, int b)
        {
            if (b == 0)
                throw new DivideByZeroException("Nollalla ei voi jakaa.");
            return (double)a / b;
        }

        static void TulostaTulos(string symboli, int luku1, int luku2, double tulos)
        {

            Console.WriteLine($"Tulos: {luku1} {symboli} {luku2} = {tulos}");
        }
        double calculateOperation(string syöte, int luku1, int luku2)
        {
            return syöte switch
            {
                "1" => Yhteenlasku(luku1, luku2),
                "2" => Vähennyslasku(luku1, luku2),
                "3" => kertolasku(luku1, luku2),
                "4" => Jakolasku(luku1, luku2),
                _ => throw new InvalidOperationException("Tuntematon laskutoimitus"),
            };  
        }

        static string GetOperationSymbol(string syöte)
        {
            return syöte switch
            {
                "1" => "+",
                "2" => "-",
                "3" => "*",
                "4" => "/",
                _ => throw new InvalidOperationException("Tuntematon laskutoimitus"),
            };
        }


        static void Main(string[] args)
        {

            string syöte = ValitseLaskutoimitus();
            int luku1 = KysyLuku();
            int luku2 = KysyLuku();
            string symbol = GetOperationSymbol(syöte);

            //double tulos = CalculateOperation(syöte, luku1, luku2); 

            //string symbol = GetOperationSymbol(syöte); <- Tämä palauttaa esim jos on 1 niin palauttaa +
            
            try
            {
                double tulos = new Program().calculateOperation(syöte, luku1, luku2);
                TulostaTulos(symbol, luku1, luku2, tulos);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Virhe: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Tapahtui virhe: {ex.Message}");
            }





















        }
    }
}
