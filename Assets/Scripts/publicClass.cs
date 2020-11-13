using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// MonoBehaviour is the class by unity
// publicClass is a class we are creating in extension of this inherited class
public class publicClass : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("publicClass weapon cs");
        Weapon sword = new Weapon();
        sword.weaponName = "Sword";
        sword.setDamage(10);
        Debug.Log(sword.getDamage());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

class Weapon
{
    public string weaponName;
    private int damage;

    public void setDamage(int dam)
    {
        damage = dam;
        Debug.Log("Damage is now set to " + dam);
    }

    public int getDamage()
    {
        return damage;
    }
    // constructors...?
    // public Weapon(string a, int b)
    // {
    //     weaponName = a;
    //     damage = b;
    // }
}