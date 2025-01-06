using System;


class Program
{
    static void Main(string[] args)
    {
        
        //ausführung der Überladene Methode
        double[] numbers = new double[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        Console.WriteLine($"{Sum(numbers)}");

        //ausführung der Methode
        Console.WriteLine(Sum(10,20));

    }
    
    //Methode
    static double Sum(double a, double b)
    {
        return a + b;
    }
    
    
    //Überladene Methode mit array als implementierung
    static double Sum(double[] numbers)
    {
        double sum = 0;

        //für jede "number" in "numbers"
        foreach (double number in numbers)
        {
            //gespeicherte nummer in "sum" + die durchlaufende array "number" dazuzählen
            sum += number;
        }
        
        //nach der foreach-schleife wird die gesammt summe zurückgegeben
        return sum;
    }
}