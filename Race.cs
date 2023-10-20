public class Race
{
  public string Name { get; set; }
  public List<Driver> Drivers { get; set; }
  public List<Driver> WaitingList { get; set; }

  public Race(string name)
  {
    Name = name;
    Drivers = new List<Driver>();
    WaitingList = new List<Driver>();
  }

  public void AddDriver(Driver driver)
  {
    if (Drivers.Count < 2)
    {
      Drivers.Add(driver);
      Console.WriteLine($"{driver.Name} was successfully added to the race!");
    }
    else
    {
      WaitingList.Add(driver);
      Console.WriteLine($"{driver.Name} was successfully added to the waiting list!");
    }
  }

  public void RemoveDriver(int driverIndex)
  {
    Driver driver = Drivers[driverIndex];
    Drivers.Remove(driver);
    Console.WriteLine($"{driver.Name} was successfully removed from the race!");

    if (Drivers.Any())
    {
      DequeueWaitingList();
    }
  }
  public void DequeueWaitingList()
  {
    Driver driver = WaitingList[0];
    WaitingList.Remove(driver);
    AddDriver(driver);
  }
}
