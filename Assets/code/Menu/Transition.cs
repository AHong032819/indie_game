using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Transition : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
         
    }

    // Update is called once per frame
     void Update()
    {
       
{
    
    if(Input.GetKeyDown(KeyCode.N))
    {
        
        SceneManager.LoadScene("ahong");
    }
}
     
    }

   void OnCollisionEnter2D(Collision2D other)
{
    
    if(other.gameObject.tag == "Player")
    {
        
        SceneManager.LoadScene("ahong");
    }
}
}
