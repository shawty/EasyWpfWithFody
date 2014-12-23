using System;
using PropertyChanged;

namespace EasyWpfWithFody.Models
{
  [ImplementPropertyChanged]
  public class JobEntry
  {
    public string JobTitle { get; set; }
    public string ClientName { get; set; }
    public Double CostPerHour { get; set; }
    public int NumberOfHours { get; set; }

    public Double TotalCost
    {
      get { return CostPerHour*NumberOfHours; }
    }

  }
}
