namespace final.lib;

public abstract class PlayerID
{
     public PlayerID(string name)
     {
        Name = name;
    }

    public string Name {get;}
    public decimal Points {get; private set;}

}