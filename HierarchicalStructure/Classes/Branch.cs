namespace HierarchicalStructure.Classes;

public class Branch
{
    public List<Branch> branches { get; set; }

    public Branch(List<Branch> branches)
    {
        this.branches = branches;
    }
}