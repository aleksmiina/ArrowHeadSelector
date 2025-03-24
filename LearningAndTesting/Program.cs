/*
Each arrow has three parts: the arrowhead (steel, wood, or obsidian), the shaft (a length between 60 and
100 cm long), and the fletching (plastic, turkey feathers, or goose feathers).

His costs are as follows: For arrowheads, steel costs 10 gold, wood costs 3 gold, and obsidian costs 5 gold.
For fletching, plastic costs 10 gold, turkey feathers cost 5 gold, and goose feathers cost 3 gold. For the
shaft, the price depends on the length: 0.05 gold per centimeter.

Objectives:
• Define a new Arrow class with fields for arrowhead type, fletching type, and length.

 (Hint: arrowhead types and fletching types might be good enumerations.)

• Allow a user to pick the arrowhead, fletching type, and length and then create a new Arrow instance. 
// 
• Add a GetCost method that returns its cost as a float based on the numbers above, and use this
to display the arrow’s cost.
*/

public class Arrow
{

private int shaftLengthLong = 100;
private int shaftLengthShort = 60;

private int steelArrowHeadCost = 10;
private int woodArrowHeadCost = 3;
private int obsidianArrowHeadCost = 5;

private double shaftLengthPricePerCm = 0.05;

private ArrowHeadType arrowHeadType; //oddly enough I am declaring an enum field here
private ArrowHeadFletching arrowHeadFletching; // the same here



public enum ArrowHeadType {steel, wood, obsidian} 

public enum ArrowHeadFletching {plastic, turkeyFeathers, gooseFeathers}

public Arrow (int shaftLengthLong, int shaftLengthShort, ArrowHeadType arrowHeadType, ArrowHeadFletching arrowHeadFletching)
{
    this.shaftLengthLong = shaftLengthLong;
    this.shaftLengthShort = shaftLengthShort;
    this.arrowHeadType = arrowHeadType;
    this.arrowHeadFletching = arrowHeadFletching;
}
}

public class UserInput //I forgot how to create an instance of a class, in this case of an Arrow class. 
{
    string userSelectedArrowHead;
    string userSelectedFletching;
    string userSelectedLength;

    public UserInput()
    {
        // constructor could be left empty?
    }

    public string () // looks like here I was going to ask a user to select an arrow type
    {
        Console.WriteLine("Please select your arrow head type from the following options: steel, wood, obsidian.");
        Console.WriteLine("Please select your arrow head fletching from the following options: plastic, turkey feathers, goose feathers.");
        Console.WriteLine("Please select the length of your arrow. It could be either 60 cm or 100 cm.");
        string userSelectedArrow = Console.ReadLine()
    }
}
