﻿using System;

namespace Wizard
{
    public class VerkeerdeIngredientenException : Exception
    {
        public VerkeerdeIngredientenException()
            : base("Er zijn de verkeerde ingredienten gebruikt voor deze spreuk!")
        {
        }
    }
}
