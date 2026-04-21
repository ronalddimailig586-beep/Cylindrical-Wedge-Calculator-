using System;

class Program
{
    static double CylindricalWedgeVolume(double r, double h)
    {
        // STANDARD FORMULA: V = (2/3) * r² * h
        return (2.0 / 3.0) * r * r * h;
    }

    static void Main()
    {
        char choice;  // ← ADDED for user choice

        do
        {
            double radius, height;  // ← MOVED inside loop

            Console.WriteLine("=== Right Circular Cylindrical Wedge Volume Calculator ===");
            Console.WriteLine("=========================================================");
            Console.WriteLine("📐 Formula: V = (2/3) × r² × h");

            // Input validation loop
            do
            {
                Console.Write("\nEnter radius (r) of cylinder (cm): ");
                if (double.TryParse(Console.ReadLine(), out radius) && radius > 0)
                    break;
                Console.WriteLine("❌ Radius must be positive!");
            } while (true);

            // Input validation loop
            do
            {
                Console.Write("Enter height (h) of wedge (cm): ");
                if (double.TryParse(Console.ReadLine(), out height) && height > 0)
                    break;
                Console.WriteLine("❌ Height must be positive!");
            } while (true);

            // Calculate volume
            double volume = CylindricalWedgeVolume(radius, height);

            // Display results
            Console.WriteLine("\n" + new string('=', 55));
            Console.WriteLine("RESULTS:");
            Console.WriteLine("--------");
            Console.WriteLine($"Radius (r)     = {radius,8:F4} cm");
            Console.WriteLine($"Height (h)     = {height,8:F4} cm");
            Console.WriteLine($"Volume         = {volume,8:F4} cm³");
            Console.WriteLine(new string('=', 55));

            // ← ADDED: Calculate again choice
            Console.Write("\nCalculate again? (y/n): ");
            choice = Console.ReadKey().KeyChar;
            Console.WriteLine("\n");  // Extra newline for clean screen

        } while (choice == 'y' || choice == 'Y');

        Console.WriteLine("👋 Thanks for using the calculator!");
        Console.ReadKey();  // Pause before exit
    }
}