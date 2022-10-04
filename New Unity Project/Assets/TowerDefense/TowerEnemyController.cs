using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EnemyType
{
    Normal,

    Fortified,

    Barrier
}

public class TowerEnemyController : MonoBehaviour
{
    [SerializeField] TowerEnemy enemy;
    public EnemyType type = EnemyType.Normal;
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
        int picker = Random.Range(1, 4);
        switch(picker){
            case 1:
                type = EnemyType.Normal;
                break;
            case 2:
                type = EnemyType.Fortified;
                break;
            case 3:
                type = EnemyType.Barrier;
                break;        
        }
        enemy.createEnemy(transform.position, type);
    }
}
