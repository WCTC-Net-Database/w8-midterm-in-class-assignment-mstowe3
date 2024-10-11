using W8_assignment_template.Interfaces;

namespace W8_assignment_template.Models.Characters;

public class Skeleton : CharacterBase, ILootable
{
    public string Treasure { get; set; }

    public Skeleton()
    {
    }

    public Skeleton(string name, string type, int level, int hp, string treasure, IRoom startingRoom) : base(name, type, level, hp, startingRoom)
    {
        Treasure = treasure;
    }

    public override void UniqueBehavior()
    {
        throw new NotImplementedException();
    }
}
