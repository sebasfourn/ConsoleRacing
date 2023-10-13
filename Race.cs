public class Race
{
  public string Name { get; set; }
  public string Date { get; set; }
  public string City { get; set; }

  public Race(string name, string date, string city)
  {
    Name = name;
    Date = date;
    City = city;
  }

  public List<Driver> drivers = new List<Driver>();
  public Queue<Driver> waitingList = new Queue<Driver>();

  public void AddDriver(Driver driver)
  {
    if (drivers.Count < 5)
    {
      drivers.Add(driver);
      Console.WriteLine($"{driver.Name} was successfully added to the race");
    }
    else
    {
      waitingList.Enqueue(driver);
      Console.WriteLine($"{driver.Name} was successfully added to the waiting list");
    }
  }

  public void RemoveDriver(Driver driver)
  {
    drivers.Remove(driver);
    waitingList.Dequeue();
    foreach (Driver drive in drivers)
    {
      Console.WriteLine(drive.Name);
    }
  }
}

public class Driver
{
  public string Name { get; set; }

  public Driver(string name)
  {
    Name = name;
  }
}
