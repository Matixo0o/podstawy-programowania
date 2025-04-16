using System;


class Program
{
    static void Kalkulator()
    {
        try
        {
            Console.Write("Podaj pierwszą liczbę: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj drugą liczbę: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Wybierz operację (+, -, *, /): ");
            string op = Console.ReadLine();

            switch (op)
            {
                case "+":
                    Console.WriteLine($"Wynik: {a + b}");
                    break;
                case "-":
                    Console.WriteLine($"Wynik: {a - b}");
                    break;
                case "*":
                    Console.WriteLine($"Wynik: {a * b}");
                    break;
                case "/":
                    Console.WriteLine(b != 0 ? $"Wynik: {a / b}" : "Błąd: dzielenie przez zero.");
                    break;
                default:
                    Console.WriteLine("Nieznana operacja.");
                    break;
            }
        }
        catch
        {
            Console.WriteLine("Nieprawidłowe dane.");
        }
    }

    static void Konwerter()
    {
        Console.Write("Wybierz konwersję (C -> F wpisz 'C', F -> C wpisz 'F'): ");
        string kierunek = Console.ReadLine().ToUpper();

        try
        {
            Console.Write("Podaj temperaturę: ");
            double temp = Convert.ToDouble(Console.ReadLine());

            if (kierunek == "C")
                Console.WriteLine($"{temp}°C = {temp * 1.8 + 32:F2}°F");
            else if (kierunek == "F")
                Console.WriteLine($"{temp}°F = {(temp - 32) / 1.8:F2}°C");
            else
                Console.WriteLine("Nieznany kierunek.");
        }
        catch
        {
            Console.WriteLine("Nieprawidłowa temperatura.");
        }
    }

    static void SredniaOcen()
    {
        try
        {
            Console.Write("Ile ocen chcesz podać? ");
            int n = int.Parse(Console.ReadLine());
            List<double> oceny = new List<double>();

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Podaj ocenę {i + 1}: ");
                double ocena = double.Parse(Console.ReadLine());
                if (ocena >= 1 && ocena <= 6)
                    oceny.Add(ocena);
                else
                    Console.WriteLine("Ocena poza zakresem 1-6. Pomijam.");
            }

            if (oceny.Count > 0)
            {
                double srednia = 0;
                foreach (var ocena in oceny)
                    srednia += ocena;

                srednia /= oceny.Count;
                Console.WriteLine($"Średnia: {srednia:F2}");
                Console.WriteLine(srednia >= 3.0 ? "Uczeń zdał." : "Uczeń nie zdał.");
            }
            else
            {
                Console.WriteLine("Brak poprawnych ocen.");
            }
        }
        catch
        {
            Console.WriteLine("Nieprawidłowe dane.");
        }
    }

    static void Main(string[] args)
    {
        string wybor;
        do
        {
            Console.WriteLine("\nMENU:");
            Console.WriteLine("1 - Kalkulator");
            Console.WriteLine("2 - Konwerter temperatur");
            Console.WriteLine("3 - Średnia ocen");
            Console.WriteLine("0 - Wyjście");
            Console.Write("Wybierz opcję: ");
            wybor = Console.ReadLine();

            switch (wybor)
            {
                case "1":
                    Kalkulator();
                    break;
                case "2":
                    Konwerter();
                    break;
                case "3":
                    SredniaOcen();
                    break;
                case "0":
                    Console.WriteLine("Do widzenia!");
                    break;
                default:
                    Console.WriteLine("Nieprawidłowy wybór.");
                    break;
            }
        } while (wybor != "0");
    }
}
