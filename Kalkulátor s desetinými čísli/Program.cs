internal class Program
{
    private static void Main(string[] args)
    {
        while (true)
        {

            Console.WriteLine("Kalkulátor is s desetinými čísli");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Jakou operaci si přejete provést?");
            Console.WriteLine("1) +");
            Console.WriteLine("2) -");
            Console.WriteLine("3) *");
            Console.WriteLine("4) /");
            Console.WriteLine("------------------------------------");

            Console.Write("Vyberte možnost: ");
            string vyber = Console.ReadLine();
            Console.Write("Zadejte první číslo: ");
            double cislo1 = double.Parse(Console.ReadLine());
            Console.Write("Zadejte druhý číslo: ");
            double cislo2 = double.Parse(Console.ReadLine());

            double vysledek = 0;

            if (vyber == "+")
            {
                vysledek = cislo1 + cislo2;
            }
            if (vyber == "-")
            {
                vysledek = cislo1 - cislo2;
            }
            if (vyber == "*")
            {
                vysledek = cislo1 * cislo2;
            }
            if (vyber == "/")
            {
                vysledek = cislo1 / cislo2;
            }

            Console.Write("Toto je váš výsledek: ");
            Console.WriteLine(vysledek);
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Chcete pokračovat?");
            Console.WriteLine("ano");
            Console.WriteLine("ne");
            Console.WriteLine("--------------------------------");
            string opakovani = Console.ReadLine();
            Console.Clear();
            if (opakovani == "ano")
            {
                continue;
            }
            if (opakovani == "ne")
            {
                break;
            }
            else if (opakovani != "ano")
            {
                break;
            }
              

        }
    }
}