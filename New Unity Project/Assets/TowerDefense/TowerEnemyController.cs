using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerEnemyController : MonoBehaviour
{
    [SerializeField] GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemy", 0, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnEnemy(){
        Instantiate(enemy, transform.position, Quaternion.identity);
    }
}
