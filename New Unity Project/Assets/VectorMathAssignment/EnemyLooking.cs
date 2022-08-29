using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLooking : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnDrawGizmos(){
        Gizmos.color = Color.red;
        Vector3 direction = transform.TransformDirection(Vector3.right) * 5;
        Gizmos.DrawRay(transform.position, direction);
    }
}
