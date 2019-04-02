using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.AI;
[RequireComponent(typeof(NavMeshAgent))]
public class frenimy : MonoBehaviour
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
      //  agent = GetComponent<NavMeshAgent>();
       // agent.SetDestination(target.position);
    }

    public void damagegiven(int givdamage)
    {
        Destroy(gameObject);
    }

    private void OnCollision(Collider other)
    {
        if (other.gameObject.tag == "enemy")
        {
            Debug.Log("enndhit");
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
