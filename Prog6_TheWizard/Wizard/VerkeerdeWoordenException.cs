using System;

namespace Wizard
{
    public class VerkeerdeWoordenException : Exception
    {
        public VerkeerdeWoordenException()
            : base("Er zijn de verkeerde woorden gebruikt voor deze spreuk!")
        {
        }
    }
}
