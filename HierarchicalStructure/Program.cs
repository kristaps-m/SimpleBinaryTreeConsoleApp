Console.WriteLine("Welcome to Binary Tree");

BinaryTree tree = new BinaryTree();

tree.Root = new Branch(1);
tree.Root.Left = new Branch(2);
tree.Root.Right = new Branch(3);
tree.Root.Left.Left = new Branch(4);
tree.Root.Right.Left = new Branch(5);
tree.Root.Right.Center = new Branch(6);
tree.Root.Right.Right = new Branch(7);
tree.Root.Right.Left.Left = new Branch(8);
tree.Root.Right.Center.Left = new Branch(9);
tree.Root.Right.Center.Right = new Branch(10);
tree.Root.Right.Center.Left.Center = new Branch(11);
tree.Root.Right.Center.Left.Center.Right = new Branch(12);
tree.Root.Right.Center.Left.Center.Center = new Branch(13);
tree.Root.Right.Center.Left.Center.Left = new Branch(14);
tree.Root.Right.Center.Left.Center.Left.Center = new Branch(15);

Console.WriteLine($"Depth of tree is : {tree.CalculateMaxDepth(tree.Root)}");

public class Branch {
    public int Data;
    public Branch Left, Right, Center;
  
    public Branch(int item)
    {
        Data = item;
        Left = Right = Center = null;
    }
}

public class BinaryTree
{
    public Branch Root;
    
    public int CalculateMaxDepth(Branch branch)
    {
        if (branch == null)
            return -1;
        else
        {
            int leftDepth = CalculateMaxDepth(branch.Left);
            int rightDepth = CalculateMaxDepth(branch.Right);
            int centerDepth = CalculateMaxDepth(branch.Center);

           if (leftDepth > rightDepth && leftDepth > centerDepth)
                return (leftDepth + 1);
            else if (rightDepth > centerDepth) 
                return (rightDepth + 1);
            else
                return (centerDepth + 1);
        }
    }
}