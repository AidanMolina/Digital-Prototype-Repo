using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float playerHealth = 10f;
    public float blastDamage = 10f;
    
    // Start is called before the first frame update
    void Start()
    {
        DamagePlayer(blastDamage);   
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space")){
            RandomMove();
        }
    }

    public void DamagePlayer(float damage){
        playerHealth -= damage;
        print($"{playerHealth}");
    }

    public void RandomMove(){
        float x = transform.position.x;
        float y = transform.position.y;

        float rand = Random.Range(0f, 10f);
        
        x += rand;
        y += rand;

        transform.position = new Vector3(x,y,0f);

    }
}
