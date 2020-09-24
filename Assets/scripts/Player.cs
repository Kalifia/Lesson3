using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int health;
    public int damage;
    public Enemy enemy;

    // Start is called before the first frame update
    void Start()
    {
        print("Hello! I'm Player!!");
        //enemy.health -= damage;
        //enemy.Attack(damage);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            print("Attack!");
            enemy.Attack(damage);
        }

        if (Input.GetKeyDown(KeyCode.Return)||Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            print("How much health do you have?");
            int enemyHealth = enemy.GetHealth();
            print("I have " + enemyHealth);
            if (enemyHealth > 0)
            {
                enemy.Attack(damage);
            }
        }
    }

    public void Attack()
    {

    }
}
