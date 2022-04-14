//SHANMUKH GOPINATH MANDAVA
// UMID:13136658
// CIS 297 - C SHARP
// GUI - CALCULATOR﻿


using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CalculatorGUI
{
   static class Program
   {
      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main()
      {
         Application.EnableVisualStyles();
         Application.SetCompatibleTextRenderingDefault( false );
         Application.Run( new CalculatorGUIForm() );
      }
   }
}
