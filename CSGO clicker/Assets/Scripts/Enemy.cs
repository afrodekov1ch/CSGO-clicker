using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private int hp = 10;
    private int enemys;

    private void Update()
    {
        PlayerPrefs.GetInt("enemyHP");
        if(hp <= 0)
        {
            Destroy(gameObject,1);
        }
    }
    public void Damage()
    {
        hp -= 1;
    }
}
