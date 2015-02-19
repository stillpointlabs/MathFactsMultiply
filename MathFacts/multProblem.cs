using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MathFacts
{
    public enum OperationTypeEnum
    {
        Add,
        Subtract,
        Multiply,
        Divide
    }
        
    static class MultProblem
    {
        public static int SecondFactorLimit {get; set; } // Upper limit of the second factor
        
        public static int[] SpecFactors;

        public static int SessionScore { get; set; }

        public static int SessionTotal { get; set; }

        public static int MultFactor1 { get; set; }

        public static int MultFactor2 { get; set; }

        public static int MultAnswer { get; set; }

    }
}
