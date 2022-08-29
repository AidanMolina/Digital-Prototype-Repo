using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadialTrigger : MonoBehaviour
{
    public float radius = 3f;

    public GameObject player;

    private void OnDrawGizmos(){

        Gizmos.DrawLine(transform.position, player.transform.position);

        float distanceToPlayer = (transform.position - player.transform.position).magnitude;

        if(Mathf.Abs(distanceToPlayer) > radius){
            Gizmos.color = Color.green;
            Gizmos.DrawWireSphere(transform.position, radius);
        }
        else{
            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere(transform.position, radius);
        }
        
    }
}
