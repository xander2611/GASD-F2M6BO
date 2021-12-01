using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class hpbar : MonoBehaviour
{



    public Slider slider;
    public Slider slider2;

    public void Setmaxhealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;
        
    }
    public void SetHealth(int health)
    {
        slider.value = health;
       
    }
    public void SetMaxpsnHP(int health)
    {
        slider2.maxValue = health;
        slider2.value = health;
    }
    public void SetpsnHealth(int health)
    {
        
        slider2.value = health;
    }
}
