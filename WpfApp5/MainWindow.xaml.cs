using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Diagnostics;

namespace WpfApp5
{
  /// <summary>
  /// Логика взаимодействия для MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    public MainWindow()
    {
      InitializeComponent();

      var allProcess =  Process.GetProcesses();
 
      int i = 0;
      foreach (var proc in allProcess)
      {
        i++;
        string infoproc = string.Format($"{proc.Id},{proc.StartTime},{proc.MachineName}");
        datagrid.ItemsSource = infoproc;
      }
 
    }

    private void button_Click(object sender, RoutedEventArgs e)
    {
      
    }
  }
}
