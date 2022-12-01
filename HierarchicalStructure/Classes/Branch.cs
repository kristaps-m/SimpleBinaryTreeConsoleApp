namespace HierarchicalStructure.Classes;

public class Branch
{
    public List<Branch> Branches { get; set; } = new List<Branch>();

    public Branch(List<Branch> branches)
    {
        this.Branches = branches;
    }

    public Branch()
    {
    }
    
    public void AddBranch()
    {
        Branches.Add(new Branch());
    }
}