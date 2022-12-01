using System.Threading.Channels;
using HierarchicalStructure.Classes;

Console.WriteLine("Welcome to Binary Tree");

// var baseOfTree = new Branch();
// baseOfTree.AddBranch();
// baseOfTree.AddBranch();
// baseOfTree.AddBranch();
// baseOfTree.Branches[0].AddBranch();
// baseOfTree.Branches[0].AddBranch();
// baseOfTree.Branches[0].AddBranch();
// baseOfTree.Branches[0].Branches[0].AddBranch();
// Console.WriteLine("PLEASE WORK !!!!----------------------");

// baseOfTree.Branches.Add(new Branch());
// baseOfTree.Branches.Add(new Branch());
// baseOfTree.Branches.Add(new Branch());
// baseOfTree.Branches[0].Branches.Add(new Branch());

var baseOfTree = new Branch(new List<Branch>()
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
                        // new (new List<Branch>()),
                        // new (new List<Branch>()),
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

Console.WriteLine(string.Join(",",baseOfTree.Branches));
Console.WriteLine(DepthCalculator.CalculateMaxDepth(baseOfTree));
Console.WriteLine("-------------------");
