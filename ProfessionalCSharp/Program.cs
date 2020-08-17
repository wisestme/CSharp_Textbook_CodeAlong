﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProfessionalCSharp.Services;

namespace ProfessionalCSharp
{
    class Program
    {
        static void Main()
        {
            Loops loops = new Loops();
            loops.ImplementForLoop();
            loops.NestedForLoop();
            loops.ImplementWhileLoop();

            Conditionals conditionals = new Conditionals();
            conditionals.ImplementIfElse();
            conditionals.ImplementIfElseIf();
            conditionals.ImplementSwitch();
            conditionals.InteractiveSwitch();

            snippet1.variables();

            ScopeClashes.TestScoping();

        }
    }
}
