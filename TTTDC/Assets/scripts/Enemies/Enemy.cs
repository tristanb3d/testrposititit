using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.AI;
[RequireComponent(typeof(NavMeshAgent))]
public class Enemy : MonoBehaviour
{
    // set health to max health at start
    public int maxHealth = 100;
    public Transform target;
    //
    private NavMeshAgent agent;
    private int health = 0;

    void Start()
    {
        health = maxHealth;
        agent = GetComponent<NavMeshAgent>();
        agent.SetDestination(target.position);
    }

    public void damagegiven(int givdamage)
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other)
        {
            Debug.Log("entered");
            Destroy(gameObject);
        }
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
