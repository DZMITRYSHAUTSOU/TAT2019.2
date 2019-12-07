using System;
using System.Collections.Generic;
using System.Linq;

namespace Task_1
{
    /// <summary>
    /// Main class
    /// </summary>
    class EntryPoint
    {
        /// <summary>
        /// Entry point
        /// </summary>
        /// <param name="args">Command line arguments</param>
        static void Main(string[] args) 
        {
            SequenceCounter counter = new SequenceCounter(args[0]);
            int max = counter.Count();
        }
    }
}
