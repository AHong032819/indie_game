using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class AudioManager : MonoBehaviour
{
    // Start is called before the first frame update
    private AudioManager audioManager;
    private AudioSource audioSource;
    void Start()
    {

        if (audioManager == null)
        {
            Debug.LogError("AudioManager not found in scene!");
        }
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag=="Player")
        {
            
        }
    }
}
