using System;
using System.Collections.ObjectModel;
using System.Linq;
using PropertyChanged;

namespace EasyWpfWithFody.Models
{
  [ImplementPropertyChanged]
  public class JobSheet
  {
    public Double TaxRatePercentage { get; set; }
    public ObservableCollection<JobEntry> Jobs { get; private set; }

    public Double TotalCostBeforeTax
    {
      get { return Jobs.Sum(x => x.TotalCost); }
    }

    public Double TotalCostAfterTax
    {
      get
      {
        var temp = TotalCostBeforeTax/100;
        return TotalCostBeforeTax + (TaxRatePercentage*temp);
      }
    }

    public JobEntry JobEntryToAdd { get; set; }

    public JobSheet()
    {
      Jobs = new ObservableCollection<JobEntry>();
      TaxRatePercentage = 20;  // Default for UK is 20%
      SetUpDemoData();
    }

    private void SetUpDemoData()
    {
      Jobs.Add(new JobEntry
      {
        JobTitle = "Fix Roof",
        ClientName = "Joe Shmoe",
        CostPerHour = 30,
        NumberOfHours = 2
      });

      Jobs.Add(new JobEntry
      {
        JobTitle = "Unblock Sink",
        ClientName = "Fred Flintstone",
        CostPerHour = 20,
        NumberOfHours = 4
      });

      Jobs.Add(new JobEntry
      {
        JobTitle = "Mow Lawns",
        ClientName = "Mr Mansion Owner",
        CostPerHour = 40,
        NumberOfHours = 6
      });

      Jobs.Add(new JobEntry
      {
        JobTitle = "Sweep Path",
        ClientName = "Jane Doe",
        CostPerHour = 10,
        NumberOfHours = 1
      });
      
      JobEntryToAdd = new JobEntry();
    }

  }
}
