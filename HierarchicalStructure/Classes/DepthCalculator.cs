namespace HierarchicalStructure.Classes;

public class DepthCalculator
{
    public static int CalculateMaxDepth(Branch branch)
    {
        if (branch.Branches.Count == 0)
        {
            return -1;
        }
        else
        {
            int leftDepth = CalculateMaxDepth(branch.Branches[2]);
            int rightDepth = CalculateMaxDepth(branch.Branches[0]);
            int centerDepth = CalculateMaxDepth(branch.Branches[1]);

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