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
using System.Collections.ObjectModel;

namespace WpfApp5
{
  /// <summary>
  /// Логика взаимодействия для MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    private ObservableCollection<DZ> dzz = new ObservableCollection<DZ>();
    public MainWindow()
    {
      InitializeComponent();
      var processes = System.Diagnostics.Process.GetProcesses().OrderBy(process => process.ProcessName).ToList();
      DZ dz = new DZ();
      foreach (var process in processes)
      {
          dz.Name = process.ProcessName;
          dz.Id = process.Id;
          dzz.Add(dz);
      }
    
    }

    private void button_Click(object sender, RoutedEventArgs e)
    {
      
    }
  }
}
