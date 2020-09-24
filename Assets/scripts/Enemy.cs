using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{ 
    public int health;
    public int damage;
    int defence;

    // Start is called before the first frame update
    void Start()
    {
        print("Hello! I'm "+ name);
    }

    // Update is called once per frame
    void Update()
    {
        

    }

    public void Attack(int damageParam)
    {
        health -= damageParam;
        if (health<=0)
        {
            print(name + " I'm dead :((");
        }
    }

    public int GetHealth()
    {
        health += 100;
        return health;
    }
}
