using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackInitiator : MonoBehaviour
{
    //[SerializeField]
    //private Attack_BoneWave _attack_BoneWave;

    [SerializeField]
    private GameObject BoneWave;
    [SerializeField]
    private GameObject BoneUp;


    private void Start()
    {
        Setup();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Keypad2) && BoneWave != null)
        {
            instansiateBoneWave();
        }
        if (Input.GetKeyDown(KeyCode.Keypad1) && BoneUp != null)
        {
            instansiateBoneUp();
        }
    }

    public void instansiateBoneWave()
    {
        GameObject boneWave = Instantiate(BoneWave, transform.position, transform.rotation);
        Destroy(boneWave, 5f);
    }
    public void instansiateBoneUp()
    {
        GameObject boneUp = Instantiate(BoneUp, transform.position, transform.rotation);
        Destroy(boneUp, 15f);


    }

    private void Setup()
    {
        //_attack_BoneWave = FindObjectOfType<Attack_BoneWave>();
    }
}
