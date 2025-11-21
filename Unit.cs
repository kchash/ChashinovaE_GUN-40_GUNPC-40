namespace MyProgram;

using System;

public class Unit
{
    private float _health;
    private float _armor;
    private Interval _damage;

    public string Name { get; }
    public float Armor => _armor;
    public float Health => _health;
    public Interval Damage => _damage;

    public Unit() : this("Unknown Unit", 0, 5) { }

    public Unit(string name, int minDamage, int maxDamage)
    {
        Name = name;
        _health = 100f;
        _armor = 0.6f;
        _damage = new Interval(minDamage, maxDamage);
    }

    public float GetRealHealth()
    {
        return Health * (1f + Armor);
    }

    public bool SetDamage(float value)
    {
        _health -= value * Armor;
        return _health <= 0f;
    }
}
public struct Interval
{
    private static Random _random = new Random();
    private int _min;
    private int _max;
    public int Min => _min;
    public int Max => _max;
    public Interval(int min, int max)
    {
        _min = min;
        _max = max;
    }
    public int Get()
    {
        return _random.Next(_min, _max + 1);
    }
}
public class Weapon
{
    private Interval _damage;
    private string _name;
    public string Name => _name;
    public Interval Damage => _damage;
    public Weapon(string name, int minDamage, int maxDamage)
    {
        _name = name;
        _damage = new Interval(minDamage, maxDamage);
    }
}
public struct Room
{
    public Unit Unit;
    public Weapon Weapon;
    public Room(Unit unit, Weapon weapon)
    {
        Unit = unit;
        Weapon = weapon;
    }
}
public class Dungeon
{
    private Room[] _rooms;
    public Room[] Rooms => _rooms;

    public Dungeon()
    {
        _rooms = new Room[]
        {
            new Room(new Unit("Unit1", 0, 10), new Weapon("Weapon1", 0, 10)),
            new Room(new Unit("Unit2", 0, 10), new Weapon("Weapon2", 0, 10)),
            new Room(new Unit("Unit3", 0, 10), new Weapon("Weapon3", 0, 10))
        };
    }
}