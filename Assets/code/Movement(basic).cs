using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ezmovement : MonoBehaviour
{
    //Serializefield代表可以直接在Inspector調整
    [SerializeField]float movespeed =5f;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //取得用戶輸入
        if(Input.GetKey(KeyCode.A))
        {
            //移動速度→movespeed(5f)
             transform.Translate(-movespeed*Time.deltaTime,0f,0f);
             GetComponent<SpriteRenderer>().flipX=true;
        }
        if(Input.GetKey(KeyCode.D))
        {
             transform.Translate(movespeed*Time.deltaTime,0f,0f);
             GetComponent<SpriteRenderer>().flipX=false;
        }
        else if(Input.GetKey(KeyCode.Space))
      {
        transform.Translate(0, movespeed * Time.deltaTime, 0);
      }
        
    }
}