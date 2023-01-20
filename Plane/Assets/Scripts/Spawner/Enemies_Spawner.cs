using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemies_Spawner : MonoBehaviour
{
    public GameObject[] Enemy;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnEnemies());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Enemies(){
        int rand = Random.Range(0,Enemy.Length);
        float randYPos = Random.Range(-3.946f,3.946f);
        Instantiate(Enemy[rand],new Vector3(transform.position.x,randYPos,transform.position.z),Quaternion.Euler(0,0,0));
    }

    IEnumerator SpawnEnemies(){
        while(true){
        yield return new WaitForSeconds(3);
        Enemies();
        }
    }
}
