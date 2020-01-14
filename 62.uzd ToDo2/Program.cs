using System;
using System.Collections.Generic;
using System.Linq;

namespace _62.uzd_ToDo2
{
    class Program
    {
        static void Main(string[] args)
        {
            ToDo job1 = new ToDo("Buy car", false);
            ToDo job2 = new ToDo("Sell car", false);
            ToDo job3 = new ToDo("Buy motorcycle", false);

            Console.WriteLine($"{job1.Name} {job1.Done}");

            // job1.Done = false; // nedarbojas, jo īpašība ir: private set

            job1.MarkAsDone(true);

            Console.WriteLine($"{job1.Name} {job1.Done}");
        }
    }
}
// Izveidot klasi ToDo ar pēc jūsu domām vajadzīgajiem properties. Obligāti ir jābūt property Done (bool).
// Izveidot klasē metodi MarkAsDone, kura kā parametru saņem bool tipa mainīgo isDone (tā vērtība var būt true vai false). 
// Šī metode MarkAsDone ir vienīgā, kura drīkst samainīt properties Done vērtību.
