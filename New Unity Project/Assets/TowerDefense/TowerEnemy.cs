using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerEnemy : MonoBehaviour
{
    private int loot = 1000;
    private float moveSpeed = 2f;
    private float health = 50f;

    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(moveSpeed * Time.deltaTime, 0f, 0f));
        
        if(transform.position.x > 10){
            player.GetComponent<TowerPlayer>().health -= 1;
            Debug.Log("Player Took Damage");
            Destroy(gameObject);
        }

        if(health <= 0){
            player.GetComponent<TowerPlayer>().money += loot;
            player.GetComponent<TowerPlayer>().XP += 1;
            Debug.Log("Player Money Went Up By:" + loot);
            Debug.Log("Player XP Went Up By: 1");
            Destroy(gameObject);
        }


    }

    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.tag == "Bullet"){
            health -= 10;
        }
    }
}
