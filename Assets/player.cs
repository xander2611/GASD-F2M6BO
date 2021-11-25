using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public int maxhp = 92;
    public int currenthp;
    public hpbar healthbar;
    public int poisonDamage = 5;
    // Start is called before the first frame update
    void Start()
    {
        currenthp = maxhp;
        healthbar.Setmaxhealth(maxhp);
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.O))
        {
            Takedmg(1);
            
        }
        void Takedmg(int damage)
        {

            currenthp -= damage;
            healthbar.SetHealth(currenthp);
        }

        dead();
    }
    void dead()
    {
        if(currenthp == 0)
        {
            
            Debug.Log("died"); 
        }
    }


}
