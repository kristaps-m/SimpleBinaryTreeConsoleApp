namespace HierarchicalStructure.Classes;

public class DepthCalculator
{
    public static int CalculateMaxDepth(Branch branch) // List<Branch> branch, int depth = 1
    {
        var depth = new List<int>();

        if (branch.Branches.Count == 0)
        {
            return 1;
        }
        else
        {
            branch.Branches.ForEach(b =>
            {
                depth.Add(CalculateMaxDepth(b) + 1);
            });
        }

        // foreach (var item in branch.Branches)
        // {
        //     depth.Add(CalculateMaxDepth(item) + 1);
        // }

        return depth.Max();
        
        
        
        // if (branch.Branches == null)
        // {
        //     return depth;
        // }
        // depth++;
        //
        // var depthResult = branch.Branches.Select(branch => CalculateMaxDepth(branch, depth));
        // return depthResult.Max();
        
        
        
        
        
        // if (branch.Branches.Count == 0)
        // {
        //     return 1;
        // }
        //
        // var test = new List<int>();
        // foreach (var B in branch.Branches)
        // {
        //     CalculateMaxDepth(B);
        // }
        //
        // return test.Max();

        // if (branch == null)
        // {
        //     return depth;
        // }
        // depth++;
        //
        // var depthResult = branch.Select(branch => CalculateMaxDepth(branch.Branches, depth)).ToList();
        // return depthResult.Max();


        // if (branch.Branches == null)
        // {
        //     return depth;
        // }
        //
        // depth++;
        //
        // var listOfDepths = new List<int>();
        // foreach (var b in branch.Branches)
        // {
        //     listOfDepths.Add(CalculateMaxDepth(b, depth));
        // }
        //
        // return listOfDepths.Max();
        
        
        
        
        //
        // for (int i = 0; i < branch.Branches.Count; i++)
        // {
        //     
        // }

        // if (branch.Branches.Count == 0)
        // {
        //     return 1;
        // }
        // else
        // {
        //     int leftDepth = CalculateMaxDepth(branch.Branches[2]);
        //     int rightDepth = CalculateMaxDepth(branch.Branches[0]);
        //     int centerDepth = CalculateMaxDepth(branch.Branches[1]);
        //
        //     if (leftDepth > rightDepth && leftDepth > centerDepth)
        //     {
        //         return (leftDepth + 1);
        //     }
        //     else if (rightDepth > centerDepth)
        //     {
        //         return (rightDepth + 1);
        //     }
        //     else
        //     {
        //         return (centerDepth + 1);
        //     }
        // }
    }
}