using HierarchicalStructure.Classes;

Console.WriteLine("Welcome to Binary Tree");

var branchTree = new Branch(new List<Branch>()
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
                        new (new List<Branch>()),
                        new (new List<Branch>()),
                      }),
                    new (new List<Branch>()),
                    new (new List<Branch>()),
                  }),
                new (new List<Branch>()),
                new (new List<Branch>()),
              }),
            new (new List<Branch>()),
            new (new List<Branch>()),
          }),
        new (new List<Branch>()),
        new (new List<Branch>()),
      })),
    new (new List<Branch>()),
    new (new List<Branch>())
  }),
  new (new List<Branch>()),
  new (new List<Branch>())
});

Console.WriteLine(DepthCalculator.CalculateMaxDepth(branchTree));
