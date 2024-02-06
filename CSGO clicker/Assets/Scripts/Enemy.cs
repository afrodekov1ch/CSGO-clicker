using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private int hp = 3;
    private int enemys;


    private void Update()
    {
        PlayerPrefs.GetInt("enemyHP");
        if(hp <= 0)
        {
            Invoke("Death", 0.5f);
        }
    }
    private void Death()
    {
        Destroy(gameObject, 0.5f);
    }
    public void Damage()
    {
        hp -= 1;
    }
}
