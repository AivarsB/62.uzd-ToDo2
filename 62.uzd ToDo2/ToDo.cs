using System;
using System.Collections.Generic;
using System.Text;

namespace _62.uzd_ToDo2
{
    class ToDo
    {
        public string Name { get; set; }
        public bool Done { get; private set; }

        public ToDo(string workName, bool done)
        {
            Name = workName;
            Done = done;
        }

        public void MarkAsDone(bool isDone)
        {
            Done = isDone;
        }
    }
}

// Izveidot klasi ToDo ar pēc jūsu domām vajadzīgajiem properties. Obligāti ir jābūt property Done (bool).
// Izveidot klasē metodi MarkAsDone, kura kā parametru saņem bool tipa mainīgo isDone (tā vērtība var būt true vai false). 
// Šī metode MarkAsDone ir vienīgā, kura drīkst samainīt properties Done vērtību.