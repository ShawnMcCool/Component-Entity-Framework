#region Using Statements
using System;
using System.Collections.Generic;
using System.Linq;
#endregion

namespace PunchGirl
{
    static class Program
    {
        private static ProtoType game;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            game = new ProtoType();
            game.Run();
        }
    }
}
