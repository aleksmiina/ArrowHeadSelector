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
• Add a GetCost method that returns its cost as a float based on the numbers above, and use this
to display the arrow’s cost.
*/

public class Arrow
{
//Fields
    int shaftLengthLong = 100;
    int shaftLengthShort = 60;

    int steelArrowHeadCost = 10;
    int woodArrowHeadCost = 3;
    int obsidianArrowHeadCost = 5;

    double shaftLengthPricePerCm = 0.05;


    enum ArrowHeadType
    {
        steel,
        wood,
        obsidian
    }

    enum ArrowHeadFletching
    {
        plastic,
        turkeyFeathers,
        gooseFeathers
    }

    ArrowHeadType Head { get;}
    ArrowHeadType Fletching { get;}

    public Arrow(ArrowHeadType head, ArrowHeadType fletching)
    {
        Head = head;
        Fletching = fletching;
    }

public class UserInput
{
    string userSelectedArrow;
    public UserInput()
    {
        // constructor could be left empty?
    }

    public string arrowTypeSelector()
    {
        Console.WriteLine("Please select the type of your arrow head.");
        Console.WriteLine("Please now select the fletching.");
        Console.WriteLine("Finally, please select the length.");

        string? userSelectedArrow = Console.ReadLine();
        return userSelectedArrow;

    }
public class ArrowCostCalculator
{
    public ArrowCostCalculator()
    {

    }


}
}
