namespace API.Domain;

public class Sensor<T> where T : IMeasurement
{
 public Guid Id { get; init; }
 public IList<(DateTime, T)> Data { get; } = new List<(DateTime, T)>();
}