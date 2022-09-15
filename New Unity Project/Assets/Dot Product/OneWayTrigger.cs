using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneWayTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<SpriteRenderer>().color = Color.red;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other) {
        Vector3 direction = other.transform.position - transform.position;
        if (Vector3.Dot (transform.up, direction) > 0) {
            Debug.Log("Bottom");
        } 
        if (Vector3.Dot (transform.up, direction) < 0) {
            Debug.Log("Top");
            GetComponent<SpriteRenderer>().color = Color.green;
        } 
        if (Vector3.Dot (transform.up, direction) == 0) {
            Debug.Log("Side");
        }
    }

    private void OnTriggerExit2D(Collider2D other){
        GetComponent<SpriteRenderer>().color = Color.red;
    }
}
