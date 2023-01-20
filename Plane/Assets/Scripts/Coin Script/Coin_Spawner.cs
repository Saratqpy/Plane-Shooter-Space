using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin_Spawner : MonoBehaviour
{
    public GameObject coinPrefabs; 
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CoinSpawner());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void coinSpawn(){

        float rand = Random.Range(-3.946f,3.946f);
        Instantiate(coinPrefabs,new Vector3(transform.position.x,rand,transform.position.z),Quaternion.identity);
    }


    IEnumerator CoinSpawner(){
        while(true){

            int time = Random.Range(8,20);
            yield return new WaitForSeconds(2f);
            coinSpawn();
        }
    }
}
