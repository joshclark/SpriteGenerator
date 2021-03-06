﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SpriteGenerator
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                GenerateFromConfigFile(args[0]);
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SpritesForm());
        }

        private static void GenerateFromConfigFile(string configFile)
        {
            try
            {
                var config = new SpriteConfigFile(configFile);
                var layoutProp = config.GenerateLayoutProperties();
                var sprite = new Sprite(layoutProp);
                sprite.Create();
            }
            catch (Exception ex)
            {
                var fullError = ex.ToString().Replace("\n", "\n    ");
                Console.WriteLine("ERROR: {0}\n\n    {1}", ex.Message, fullError);
                Environment.ExitCode = 1;
            }
        }
    }
}
