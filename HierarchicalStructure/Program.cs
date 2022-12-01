using HierarchicalStructure.Classes;

Console.WriteLine("Welcome to Binary Tree");


var branchTree = new Branch(new List<Branch>()
{
  // D1
  new (new List<Branch>()
  {
    // D2
    new (new List<Branch>(new List<Branch>()
      {
        // D3
        new (new List<Branch>()
          {
            // D4
            new (new List<Branch>()
              {
                // D3
                new (new List<Branch>()
                  {
                    // D3
                    new (new List<Branch>()
                      {
                        // D7
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
    // D2
    new (new List<Branch>()),
    // D2
    new (new List<Branch>())
  }),

  // D1
  new (new List<Branch>()),
  // D1
  new (new List<Branch>())
});

/*
 *  BRANCH [ BRANCH [
 *                         
 *                  ]
 *         ]
 */

Console.WriteLine(DepthCalculator.CalculateMaxDepth(branchTree));
