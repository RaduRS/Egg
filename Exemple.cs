using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exemple : MonoBehaviour
{

    private int enemyCount = 10;
    private string[] enemies = new string[5];
    private int weaponId = 0;

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            WeaponSearch();
        }
    }

    void EnemyDestruction()
    {
        while (enemyCount > 0)
        {
            print("Destroy enemy");
            enemyCount--;
        }
    }

    void EnemyScan()
    {
        bool isAlive = false;

        do
        {
            print("Scanning for enemies");
        }
        while (isAlive == true);
    }

    void EnemyRoster()
    {
        enemies[0] = "Orc";
        enemies[1] = "Dragon";
        enemies[2] = "Mage";
        enemies[3] = "Elf";
        enemies[4] = "Paladin";

        foreach(string enemy in enemies)
        {
            print(enemy);
        }
    }

    void WeaponSearch()
    {
        weaponId = Random.Range(1, 6);

        switch (weaponId)
        {
            case 1:
                print("sword");
                break;
            case 2:
                print("mage");
                break;
            case 3:
                print("staff");
                break;
            default:
                print("what is this");
                break;
        }
    }
}
