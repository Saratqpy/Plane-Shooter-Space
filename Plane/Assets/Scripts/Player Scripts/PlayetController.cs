using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayetController : MonoBehaviour
{
    public float speed = 5f;

    public float min_Y , max_Y; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      MovePlayer();  
    }

    void MovePlayer()
    {
        if(Input.GetAxisRaw("Vertical") > 0f)
        {
            Vector3 temp = transform.position;
            temp.y += speed * Time.deltaTime;
            
            if(temp.y > max_Y)
            {
                temp.y = max_Y;
            }

            transform.position = temp;
        }
        else if(Input.GetAxisRaw("Vertical") < 0f)
        {
            Vector3 temp = transform.position;
            temp.y -= speed * Time.deltaTime;

            if(temp.y < min_Y)
            {
                temp.y = min_Y;
            } 
            transform.position = temp;
        }
    }
}
