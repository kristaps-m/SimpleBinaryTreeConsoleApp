using HierarchicalStructure.Classes;

Console.WriteLine("Welcome to Hierarchical Structure");

var baseOfTree = GetOneHierarchicalStructure();

Console.WriteLine($"The depth of your branch tree is: {DepthCalculator.CalculateMaxDepth(baseOfTree)}");

Branch GetOneHierarchicalStructure()
{
  return new Branch(new List<Branch>()
  {
    new (new List<Branch>()
    {
      new (new List<Branch>(new List<Branch>()
      {
        new (new List<Branch>()
        {
          new (new List<Branch>()
          {
            new (new List<Branch>()
            {
              new (new List<Branch>()
              {
                new (new List<Branch>()),
              }),
              new (new List<Branch>()),
              new (new List<Branch>()),
            }),
            new (new List<Branch>()),
            new (new List<Branch>()),
            new (new List<Branch>())
          }),
          new (new List<Branch>()),
          new (new List<Branch>()),
        }),
        new (new List<Branch>()),
      })),
      new (new List<Branch>()),
      new (new List<Branch>()),
      new (new List<Branch>()
      {
        new (new List<Branch>()),
        new (new List<Branch>()),
      })
    }),
    new (new List<Branch>()),
    new (new List<Branch>()),
  });
}