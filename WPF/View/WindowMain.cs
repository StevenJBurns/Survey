using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace Survey
  {
  partial class WindowMain : Window
    {
    Point mouse;
    Boolean hasCommandCenter;
    
    public WindowMain()
      {
      InitializeComponent();

      CompositionTarget.Rendering += AnimateGradient;
      }

    private void AnimateGradient(object sender, EventArgs e)
      {
      mouse = Mouse.GetPosition(this);
      }
    }
  }