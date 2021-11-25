using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class textchange : MonoBehaviour
{
    public Text hpdate;
    public player player;
  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        nmbrlives();
    }

    public void nmbrlives()
    {
        hpdate.text = "KR   " + player.currenthp + " / 92";
    }
}
