using Modulo1.Ejercicio3.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetodoStatico4
{
    public class NamedConstructor
    {
        private Name Name;
        private Status Status;

        private NamedConstructor(Name name, Status status)
        {
            this.Name = name;
            this.Status = status;
        }

        public static NamedConstructor SingUpAgain(Name name)
        {
            Status status = new Status(Status.ACTIVED_STATUS);
            NamedConstructor CustomerStatus = new NamedConstructor(name, status);
            return CustomerStatus;
        }

    }
}
