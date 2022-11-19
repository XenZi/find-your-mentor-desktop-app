﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SR38_2021_POP2022.utilities.exceptions
{
    class SchoolNotFoundException : Exception
    {

        public SchoolNotFoundException()
        {

        }

        public SchoolNotFoundException(string message) : base(message)
        {

        }

        public SchoolNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
