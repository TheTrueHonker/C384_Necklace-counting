using System;
using System.Collections.Generic;
using System.Text;

namespace C384_Necklace_counting.Exceptions
{
    public class LettersOutOfBoundsException : Exception
    {
        public LettersOutOfBoundsException() : base("Number of letters must be or be between 1 and 26") { }
    }
}
