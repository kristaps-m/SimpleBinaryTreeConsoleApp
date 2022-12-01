namespace HierarchicalStructure.Classes;

public class DepthCalculator
{
    public Branch Root;

    public static int CalculateMaxDepth(Branch branch)
    {
        if (branch.branches.Count == 0)
        {
            return -1;
        }
        else
        {
            int leftDepth = CalculateMaxDepth(branch.branches[2]);
            int rightDepth = CalculateMaxDepth(branch.branches[0]);
            int centerDepth = CalculateMaxDepth(branch.branches[1]);

            if (leftDepth > rightDepth && leftDepth > centerDepth)
            {
                return (leftDepth + 1);
            }
            else if (rightDepth > centerDepth)
            {
                return (rightDepth + 1);
            }
            else
            {
                return (centerDepth + 1);
            }
        }
    }
}