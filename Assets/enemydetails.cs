using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemydetails : MonoBehaviour
{
    public float MaxHP;
    float CurrentHP;

    public GameObject enemy;


    // Start is called before the first frame update
    void Start()
    {
        CurrentHP = MaxHP;
    }

    // Update is called once per frame
    void Update()
    {
        if(CurrentHP <= 0 )
        {
            Die();
        }
    }

    public void TakeDamage(int damage)
    {
        CurrentHP -= damage;
    }

    void Die()
    {
        Destroy(enemy);
    }
}
