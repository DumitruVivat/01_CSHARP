int Fact(int n)
{
  if (n == 1 || n == 0)
  {
      Console.WriteLine($"Stop: {n}");
    return 1;
  }
  Console.WriteLine(n);
  return n * Fact(n - 1);
}
Console.Write(Fact(5));