using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TowerType
{
    None,

    Normal,

    Artillery,

    Magic
}

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

    [SerializeField] GameObject bullet;
    public TowerType type = TowerType.Normal;

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

        if(Input.GetKeyDown("up")){
            type = TowerType.Normal;
            Debug.Log("tower type changed.");
        }
        if(Input.GetKeyDown("down")){
            type = TowerType.Artillery;
            Debug.Log("tower type changed.");
        }
        if(Input.GetKeyDown("right")){
            type = TowerType.Magic;
            Debug.Log("tower type changed.");
        }
    }

    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.tag == "Enemy"){
            target = other.gameObject;
        }
    }

    void Shoot(){
        bullet.GetComponent<TowerBullet>().createBullet(type, target.transform.position, gameObject.transform.position);
    }
}
