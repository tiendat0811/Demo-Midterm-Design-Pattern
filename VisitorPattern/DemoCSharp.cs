using System;

internal interface Dog
{
    void hit(Cat cat);
}

internal interface Cat
{
    void hitBy(PitBull pitBull);
    void hitBy(Golden golden);
}

internal class PitBull : Dog
{
    public virtual void hit(Cat cat)
    {
        Console.WriteLine("Grrhhh! Pit Bull!!!");
        cat.hitBy(this);
    }
}

internal class Golden : Dog
{
    public virtual void hit(Cat cat)
    {
        Console.WriteLine("Gaw Gaw! Golden!!!");
        cat.hitBy(this);
    }
}

internal class Sphynx : Cat
{
    public virtual void hitBy(PitBull pitBull)
    {
        damaged(100);
    }

    public virtual void hitBy(Golden golden)
    {
        damaged(10);
    }

    public virtual void damaged(int hp)
    {
        Console.WriteLine("Meo meo Sphynx!!! - " + hp + " hp ~");
    }
}

internal class Munchkin : Cat
{
    public virtual void hitBy(PitBull pitBull)
    {
        damaged(25);
    }

    public virtual void hitBy(Golden golden)
    {
        damaged(50);
    }

    public virtual void damaged(int hp)
    {
        Console.WriteLine("Meo meo Munchkin!!! - " + hp + " hp ~");
    }
}

public class DemoCSharp
{
    public static void Main(string[] args)
    {

        Dog pitBull = new PitBull();
        Dog golden = new Golden();

        Cat sphynx = new Sphynx();
        Cat munchkin = new Munchkin();

        pitBull.hit(sphynx);
        golden.hit(sphynx);

        Console.WriteLine("\nChange turn!!!\n");

        pitBull.hit(munchkin);
        golden.hit(munchkin);
    }
}