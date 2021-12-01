using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Timers;
public class player : MonoBehaviour
{
   // private static System.Timers.Timer aTimer;
    public int maxhp = 92;
    public int currenthp;
    public hpbar healthbar;


    public bool damagetaker;


    public float delay;
    //private float timer;
    public int psnmxhp = 92;
    public double poisonDamage = 1;
    public hpbar psnbar;
    public int psnhp;
    bool poisonEffect;
    public int poisontickdmg = 1;

    // public int poisontimer = 10;


    // Start is called before the first frame update
    void Start()
    {
        currenthp = maxhp;
        healthbar.Setmaxhealth(maxhp);


        psnhp = psnmxhp;
        psnbar.SetMaxpsnHP(psnmxhp);
       // timer = 0;

    }

    // Update is called once per frame
    void Update()
    {

        if (damagetaker == true)
        {


        }

        if (poisonEffect == true)
        {
            //poisen activafte
        }

        if (damagetaker == true && currenthp > 1)
        {
            Debug.Log("weerkt");
            alwdmg();


        }

        if (Input.GetKeyUp(KeyCode.O))
        {
            damagetaker = false;
            poisonEffect = false;
            Debug.Log("ayo");
        }
        if (damagetaker == true)
        {
            Debug.Log("test");
        }

        if (currenthp == psnhp)
        {
            damagetaker = false;
            poisonEffect = false;
            StopCoroutine("poisoning");

        }

       
        Debug.Log(psnhp);

        alwdmg();
        dead();
    }

     void FixedUpdate()
    {
        if (poisonEffect == true)
        {
            StartCoroutine("poisoning");
            // psncontroll();
        }
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

    void psndmg(int psndamage)
    {
        psnhp -= psndamage;
        psnbar.SetpsnHealth(psnhp);
    }




    IEnumerator poisoning()
     {
         psnhp -= poisontickdmg;
         psnbar.SetpsnHealth(psnhp);
         poisonEffect = false;
         yield return new WaitForSeconds(2f);
         poisonEffect = true;
         poisoning();

     }


   /* public void psncontroll()
    {
        if (poisonEffect == true)
        {
            Debug.LogError("kutshitfucku");

            timer += Time.deltaTime;
            if (timer > delay)
            {
                //do iets
                timer = 0;
                psnhp -= poisontickdmg;
                psnbar.SetpsnHealth(psnhp);

                poisonEffect = true;
            }


            aTimer = new System.Timers.Timer(1000);




        }
    }

    */

    void alwdmg()
    {
        if (currenthp > 1)
        {
            if (Input.GetKey(KeyCode.O))
            {
                Takedmg(1);
                // Debug.Log(currenthp);
                poisonEffect = true;
                damagetaker = true;
            }

        }
        else if (currenthp == 1)
        {
            Debug.Log("working");
            if (Input.GetKey(KeyCode.O))
            {
                psndmg(1);

            }

        }

    }

}
