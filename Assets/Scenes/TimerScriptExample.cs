using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerScriptExample : MonoBehaviour
{
    float tijdOver = 2.0f;
    bool loopentijd = true;
    private float NextFire = 0.0f;

    void Update()
    {


        if (Time.time > NextFire)
        {
            

            NextFire = Time.time + tijdOver;
            Debug.Log("kutzoi");
        }













        /*   tijdOver -= Time.deltaTime;
          if (tijdOver <= 0&& loopentijd )
          {
              Debug.Log("a");
              loopentijd = false;

          }
        */
    }
}
