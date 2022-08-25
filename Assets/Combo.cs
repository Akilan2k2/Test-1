using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combo : MonoBehaviour
{
    public Animator anim;
    public int combo;
    public bool iscomboenable;


    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            combo+=1;
            attack();
            if(Time.unscaledTime<0.5&& Input.GetKeyDown(KeyCode.A))
            {
                combo += 1;
            }
        
        
        
        }
    }

    void attack()
    {
        if(combo==1)
        {
            anim.SetTrigger("attack1");
        }
    
        if(combo==2)
        {
            anim.SetTrigger("attack2");
            combo = 0;
        }
    
    }
      


}
