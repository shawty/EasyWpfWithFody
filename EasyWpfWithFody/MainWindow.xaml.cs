using System.Linq;
using System.Windows;
using EasyWpfWithFody.Models;

namespace EasyWpfWithFody
{
  public partial class MainWindow : Window
  {
    public JobSheet CurrentJobSheet { get; private set; }

    public MainWindow()
    {
      CurrentJobSheet = new JobSheet();
      InitializeComponent();
    }

    private void BtnAddNewClick(object sender, RoutedEventArgs e)
    {
      CurrentJobSheet.Jobs.Add(CurrentJobSheet.JobEntryToAdd);
    }


  }
}
