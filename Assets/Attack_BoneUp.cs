using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack_BoneUp : MonoBehaviour
{
    [SerializeField]
    private int _speed;

    private void Update()
    {
        MoveAttack();
    }

    public void MoveAttack()
    {
        transform.position += new Vector3(0, _speed, 0) * Time.deltaTime;
    }
}
