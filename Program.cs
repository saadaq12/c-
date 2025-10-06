class Program
{
    static void Main(string[] args)
    {
        bool forsätt = true;
        while (forsätt)
        {
            Console.Clear();
            Console.WriteLine("Välkommen till min kalkylator");
            Console.WriteLine("skriv in första talet");
            double tal1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("välj en operator + - * /");
            string? opInput = Console.ReadLine();
            string op = opInput ?? "";

            Console.WriteLine("skriv in andra talet");
            string? tal2Input = Console.ReadLine();
            double tal2 = 0;
            if (!string.IsNullOrEmpty(tal2Input))
            {
                tal2 = Convert.ToDouble(tal2Input);
            }
            else
            {
                Console.WriteLine("Ogiltigt tal, använder 0.");
            }

            double resultat = 0;
            switch (op)
            {
                case "+":
                    resultat = tal1 + tal2;
                    break;
                case "-":
                    resultat = tal1 - tal2;
                    break;
                case "*":
                    resultat = tal1 * tal2;
                    break;
                case "/":
                    if (tal2 != 0)
                    {
                        resultat = tal1 / tal2;
                    }
                    else
                    {
                        Console.WriteLine("Kan inte dividera med 0!");
                    }
                    break;
                default:
                    Console.WriteLine("Ogiltig operator!");
                    break;
            }

            Console.WriteLine("Resultat: " + resultat);
            Console.WriteLine("Vill du fortsätta? (j/n)");
            string? svarInput = Console.ReadLine();
            string svar = svarInput ?? "";
            if (svar.ToLower() != "j")
                forsätt = false;
            if (!string.Equals(svar, "j", StringComparison.OrdinalIgnoreCase))
                forsätt = false;
        }
    }
}