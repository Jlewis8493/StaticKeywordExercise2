using System;

namespace StaticExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var celsius = TempConverter.FahrenheitToCelsius(68); // 20
            var fahrenheit = TempConverter.CelsiusToFahrenheit(20); // 68

            Console.WriteLine("After Conversion:");
            Console.WriteLine($"celsius {celsius}");
            Console.WriteLine($"fahrenheit {fahrenheit}");

        }
    }
}
