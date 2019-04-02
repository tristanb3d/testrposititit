using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canon : Tower
{
    public Transform orb;
    public float lineDelay = 0.2f;
    public LineRenderer line;

    void Reset()
    {
        line = GetComponent<LineRenderer>();
    }

    protected override void Update()
    {
        base.Update();
        // If currentEnemy is null
        if (currentEnemy == null)
        {
            // Disable the line
            line.enabled = false;
        }
    }
    IEnumerator DisableLine()
    {
        yield return new WaitForSeconds(lineDelay);
        line.enabled = false;
    }

    protected override void Aim(Enemy e)
    {
        orb.LookAt(e.transform);
        //get orb to aim at enm
        //create line from orb to enemy 
        line.SetPosition(0, orb.position);
        line.SetPosition(1, e.transform.position);
    }

    public override void Attack(Enemy e)
    {
        line.enabled = true;

        e.TakeDamage(damage);
        StartCoroutine(DisableLine());
    }
}