using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private int hp = 3;
    private int enemys;

    public GameObject enemyParent;

    public GameObject ad;

    [SerializeField] private float speed = 2f;
    public Transform[] movePoint;
    private int randomPoint;
    private float waitTime;
    private float startWaitTime;

    private void Start()
    {
        waitTime = startWaitTime;
        randomPoint = Random.Range(0, movePoint.Length);
        speed = Random.Range(1, speed);
    }

    private void Update()
    {
        Move();
        if(hp <= 0)
        {
            ad.SetActive(true);
            Invoke("Death", 0.5f);
        }
    }

    private void Move()
    {
        transform.position = Vector2.MoveTowards(transform.position, movePoint[randomPoint].position, speed * Time.deltaTime);
        if(Vector2.Distance(transform.position, movePoint[randomPoint].position) < 0.2f)
        {
            if(waitTime <= 0)
            {
                randomPoint = Random.Range(0, movePoint.Length);
                waitTime = startWaitTime;
            }
            else
            {
                waitTime -= Time.deltaTime;
            }
        }
    }
    private void Death()
    {
        ad.SetActive(false);
        Destroy(enemyParent);
    }
    public void Damage()
    {
        hp -= 1;
    }
}
