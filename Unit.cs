using System.Numerics;

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
    private int minValue;
    private int maxValue;

    public int Min => minValue;
    public int Max => maxValue;

    public Interval(int minValue, int maxValue)
    {
        bool incorrect = false;

       
        if (minValue < 0)
        {
            minValue = 0;
        }

        if (maxValue < 0)
        {
            maxValue = 0;
        }
        
        if (minValue > maxValue)
        {
            minValue = maxValue;
            maxValue = minValue;
        }
        
        if (minValue == maxValue)
        {
            maxValue += 10;
        }

        this.minValue = minValue;
        this.maxValue = maxValue;

    }

    public int Get()
    {
        return _random.Next(minValue, maxValue + 1);
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
    private Unit Unit;
    private Weapon Weapon;
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