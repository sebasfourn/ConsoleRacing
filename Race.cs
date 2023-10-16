public class Race
{
  public string Name { get; set; }
  public List<Driver> Drivers { get; set; }
  public Queue<Driver> WaitingList { get; set; }

  public Race(string name, string date, string city)
  {
    Name = name;
    Drivers = new List<Driver>();
    WaitingList = new Queue<Driver>();
  }

  public void AddDriver(Driver driver)
  {
    if (Drivers.Count < 2)
    {
      Drivers.Add(driver);
      Console.WriteLine($"{driver.Name} was successfully added to the race");
    }
    else
    {
      WaitingList.Enqueue(driver);
      Console.WriteLine($"{driver.Name} was successfully added to the waiting list");
    }
  }

  public void RemoveDriver(Driver driver)
  {
    Drivers.Remove(driver);
    WaitingList.Dequeue();
  }
}
