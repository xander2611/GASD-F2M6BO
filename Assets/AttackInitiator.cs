using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackInitiator : MonoBehaviour
{
    //[SerializeField]
    //private Attack_BoneWave _attack_BoneWave;

    [SerializeField]
    private GameObject BoneWave;


    private void Start()
    {
        Setup();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            instansiateBoneWave();
        }
    }

    public void instansiateBoneWave()
    {
        GameObject boneWave = Instantiate(BoneWave, transform.position, transform.rotation);
        Destroy(boneWave, 5f);
    }

    private void Setup()
    {
        //_attack_BoneWave = FindObjectOfType<Attack_BoneWave>();
    }
}
