using HierarchicalStructure.Exceptions;

namespace HierarchicalStructure.Classes;

public class Branch
{
    public List<Branch> branches { get; set; }

    public Branch(List<Branch> branches)
    {
        if (branches.Count != 3)
        {
            throw new InvalidBranchException();
        }
        this.branches = branches;
    }
}