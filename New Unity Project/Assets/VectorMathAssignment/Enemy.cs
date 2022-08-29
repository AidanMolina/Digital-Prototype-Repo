using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float radius = 3f;

    public GameObject player;

    private void OnDrawGizmos(){


        float distanceToPlayer = (transform.position - player.transform.position).magnitude;

        if(Mathf.Abs(distanceToPlayer) > radius){
            Gizmos.color = Color.green;
            Gizmos.DrawWireSphere(transform.position, radius);
        }
        else{
            Gizmos.DrawLine(transform.position, player.transform.position);
            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere(transform.position, radius);
        }
        
    }
}
