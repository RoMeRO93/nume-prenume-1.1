using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Introduceti cate nume si prenume doriti:");
        int numarNume = int.Parse(Console.ReadLine());
        string[] numeSiPrenume = new string[numarNume];

        
        for (int i = 0; i < numeSiPrenume.Length; i++)
        {
            Console.WriteLine("Introduceti numele si prenumele " + (i + 1) + ":");
            numeSiPrenume[i] = Console.ReadLine();
        }

        
        Console.WriteLine("Numele introduse sunt:");
        foreach (string nume in numeSiPrenume)
        {
            string[] cuvinte = nume.Split(' '); 
            Console.WriteLine(cuvinte[1] + " " + cuvinte[0]); 
        }

        Console.Read();
    }
}
