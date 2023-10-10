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

  // public void AddDriver(Driver driver)
  // {
  //   Race.add(driver);
  // }
}

public class Driver
{
  public string Name { get; set; }

  public Driver(string name)
  {
    Name = name;
  }
}
