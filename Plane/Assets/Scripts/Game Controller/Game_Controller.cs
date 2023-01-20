using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Game_Controller : MonoBehaviour
{
    

    public Score_Script score_manager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
          
         
    }

    public void Restart(){
        SceneManager.LoadScene("Gameplay");
    }
}
