using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapBehavior : MonoBehaviour
{
    //player animations
    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        //para sa player to pre kimi lang
        anim = GetComponent<Animator>();
    }

    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            anim.SetBool("isActive", true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            anim.SetBool("isActive", false);
        }
    }
}
