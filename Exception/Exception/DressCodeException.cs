using System;
using System.Collections.Generic;
using System.Text;

namespace Exception
{
    class DressCodeException:ApplicationException
    {
        private string message = "You are not wering an Elf costume, and you are underage!";

        public DressCodeException()
        {
            Console.WriteLine(message);
        }
    }
}
