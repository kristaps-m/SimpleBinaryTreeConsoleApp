namespace HierarchicalStructure.Exceptions;

public class InvalidBranchException : Exception
{
    public InvalidBranchException() : base("Each list of branches must contain 3 Branches")
    {
    }
}