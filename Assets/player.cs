using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public int maxhp = 92;
    public int currenthp;
    public hpbar healthbar;
    public hpbar psnbar;
    public int poisonDamage = 5;
    public bool damagetaker;
    // Start is called before the first frame update
    void Start()
    {
        currenthp = maxhp;
        healthbar.Setmaxhealth(maxhp);


    }

    // Update is called once per frame
    void Update()
    {
      
        if (Input.GetKeyUp(KeyCode.O))
        {
            damagetaker = false;
        }
        if(damagetaker == true)
        {
            Debug.Log("test");
        }
        

        alwdmg();
        dead();
    }
    

    void dead()
    {
        if (currenthp == 0)
        {

            Debug.Log("died");
        }
    }
    void Takedmg(int damage)
    {
        damagetaker = true;
        currenthp -= damage;
        healthbar.SetHealth(currenthp);
    }
    
    void alwdmg()
    {
        if (currenthp > 1)
        {
            if (Input.GetKey(KeyCode.O))
            {
                Takedmg(1);

            }
            
        }
        else if (currenthp == 1)
        {
            Debug.Log("working");
        }

    }

}
