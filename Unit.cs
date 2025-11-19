using System.Globalization;

namespace MyProgram;

public class Unit
{
    
    private float _health;
    
    private float _armor;
    
    private int _damage;
    
    public string Name { get; }
    
    public int Damage => _damage;
    
    public float Armor => _armor;
    
    public float Health => _health;
    
    
    public Unit() : this("Unknown Unit")
    {
    }
    public Unit(string name)
    {
        Name = name;
        _health = 100f;   
        _armor = 0.6f;   
        _damage = 5;     
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