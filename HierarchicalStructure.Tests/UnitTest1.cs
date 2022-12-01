using FluentAssertions;
using HierarchicalStructure.Classes;

namespace HierarchicalStructure.Tests;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void CalculateMaxDepth_return_minus1()
    {
        //Act
        var branchTree = new Branch(new List<Branch>());
        var calculateDepth = DepthCalculator.CalculateMaxDepth(branchTree);
        //Assert
        calculateDepth.Should().Be(-1);
    }
    
    [TestMethod]
    public void CalculateMaxDepth_DepthIs_0_ReturnCorrectNumber()
    {
        //Act
        var branchTree = new Branch(new List<Branch>()
        {
            new (new List<Branch>()),
            new (new List<Branch>()),
            new (new List<Branch>()),
        });
        var calculateDepth = DepthCalculator.CalculateMaxDepth(branchTree);
        //Assert
        calculateDepth.Should().Be(0);
    }
    
    [TestMethod]
    public void CalculateMaxDepth_DepthIs_1_ReturnCorrectNumber()
    {
        //Act
        var branchTree = new Branch(new List<Branch>()
        {
            new (new List<Branch>()
                {
                    new(new List<Branch>()),
                    new(new List<Branch>()),
                    new(new List<Branch>()),
                }),
            new (new List<Branch>()),
            new (new List<Branch>()),
        });
        var calculateDepth = DepthCalculator.CalculateMaxDepth(branchTree);
        //Assert
        calculateDepth.Should().Be(1);
    }
    
    [TestMethod]
    public void CalculateMaxDepth_DepthIs_2_ReturnCorrectNumber()
    {
        //Act
        var branchTree = new Branch(new List<Branch>()
        {
            new (new List<Branch>()
            {
                new(new List<Branch>()
                {
                    new(new List<Branch>()),
                    new(new List<Branch>()),
                    new(new List<Branch>()),
                }),
                new(new List<Branch>()),
                new(new List<Branch>()),
            }),
            new (new List<Branch>()),
            new (new List<Branch>()),
        });
        var calculateDepth = DepthCalculator.CalculateMaxDepth(branchTree);
        //Assert
        calculateDepth.Should().Be(2);
    }
}