using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_Application.PossibleExceptions.Common
{
    public class EntityNotFound: Exception
    {
        public EntityNotFound()
        {
            

        }

        public EntityNotFound(string? message) : base(message)
        {
        }
    }
}
