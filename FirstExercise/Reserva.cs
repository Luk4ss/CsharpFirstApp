using System;
using System.Collections.Generic;
using System.Text;

namespace FirstExercise
{
    class Reserva
    {
        public String Name { get;  set; }
        public String Email { get;  set; }
        public int Room { get;  set; }

        public override string ToString()
        {
            return Room + ": " + Name + ", " + Email;
        }
    }
}
