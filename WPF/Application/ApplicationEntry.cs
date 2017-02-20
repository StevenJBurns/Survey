using System;
using System.Windows;

namespace Survey
  {
  public class ApplicationEntry
    {
    [STAThread]
    public static void Main()
      {
      WindowMain win = new WindowMain();
      Application app = new Application();
      
      app.Run(win);
      }
    }
  }