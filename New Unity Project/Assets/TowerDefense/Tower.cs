using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    public int cost = 1000;
    private float speed = 5f;
    public int damage = 10;
    private float fireRate = 0.5f;
    private bool fired;
    private int range = 5;
    private bool shooting;
    private float distanceToTarget = 10000f;
    private GameObject target;

    // Start is called before the first frame update
    void Start()
    {
        shooting = false;
        fired = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(target){
            distanceToTarget = (transform.position - target.transform.position).magnitude;
        }

        if(Mathf.Abs(distanceToTarget) < range){
            shooting = true;
        }

        if(shooting && !fired){
            Shoot();
            fired = true;
        }

        if(fired){
            fireRate -= Time.deltaTime;
            if(fireRate <= 0.0f){
                fireRate = 0.5f;
                fired = false;
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.tag == "Enemy"){
            target = other.gameObject;
        }
    }

    void Shoot(){
        Debug.Log("Shot fired");
    }
}
