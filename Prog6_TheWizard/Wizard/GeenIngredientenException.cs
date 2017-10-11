using System;

namespace Wizard
{
    public class GeenIngredientenException : Exception
    {
        public GeenIngredientenException() : base("Er zijn geen ingredienten gebruikt voor deze spreuk!")
        {
        }
    }
}
