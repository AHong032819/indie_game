using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] int Hp;
    void Start()
    {
        Hp = 10;
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Spike")
        {
            Debug.Log("碰撞Spike");
            ModifyHp(-1);
        }
        if (other.gameObject.tag == "Ground")
        {
            Debug.Log("碰撞Ground");
        }

    }

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.tag == "DeathLine")
        {
            Debug.Log("碰撞DeathLine");
        }
    }
    void ModifyHp(int num)
    {
        Hp += num;
        if (Hp > 5)
        {
            Hp = 5;
        }
        else if (Hp < 0)
        {
            Hp = 0;
        }
    }
}
