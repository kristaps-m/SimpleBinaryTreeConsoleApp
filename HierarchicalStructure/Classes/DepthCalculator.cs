namespace HierarchicalStructure.Classes;

public class DepthCalculator
{
    public static int CalculateMaxDepth(Branch branch)
    {
        var depthCount = new List<int>();

        if (branch.Branches.Count == 0)
        {
            return 1;
        }
        else
        {
            branch.Branches.ForEach(b =>
            {
                depthCount.Add(CalculateMaxDepth(b) + 1);
            });
        }

        return depthCount.Max();
    }
}