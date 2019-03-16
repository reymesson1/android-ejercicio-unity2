using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Init(bool isRightPaddle){

        if(isRightPaddle){            

            pos = new Vecto2(GameManager.topRight.x,0);
            pos += Vector2.right * transform.localScale.x;
        }else{

            pos = new Vector2(GameManager.bottomLeft.x,0);            
            pos += Vector2.right * transform.localScale.x;
        }

        transform.position = pos;


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
