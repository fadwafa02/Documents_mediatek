﻿using MediaTekDocuments.view;
using System;
using System.Windows.Forms;
<<<<<<< HEAD
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MediaTekDocuments.controller;
=======
>>>>>>> 92022dd655b811bce0b9f8f1e59544695ace3576

namespace MediaTekDocuments
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
<<<<<<< HEAD
            Application.Run(new FrmAuthentification());
=======
            Application.Run(new FrmMediatek());
>>>>>>> 92022dd655b811bce0b9f8f1e59544695ace3576
        }
    }
}
