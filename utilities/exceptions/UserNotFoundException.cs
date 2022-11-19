using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SR38_2021_POP2022.utilities.exceptions
{
    class UserNotFoundException : Exception
    {

        public UserNotFoundException()
        {

        }

        public UserNotFoundException(string message) : base(message)
        {

        }

        public UserNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
