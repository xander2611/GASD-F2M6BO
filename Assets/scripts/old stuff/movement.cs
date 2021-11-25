using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace movement
{
    public class movement : MonoBehaviour
    {


        
        [SerializeField] Rigidbody2D test;
        bool a = false;
        [SerializeField] public float speed; //6.7 is close

        // Start is called before the first frame update
        void Start()
        {
           
        }

        // Update is called once per frame
        void Update()
        {


            if (Input.GetKey(KeyCode.A))
            {

                transform.position += new Vector3(-1, 0, 0) * speed * Time.deltaTime;


            }


            if (Input.GetKey(KeyCode.D))
            {

                transform.position += new Vector3(1, 0, 0) * speed * Time.deltaTime;

            }
            if (Input.GetKey(KeyCode.W))
            {
                transform.position += new Vector3(0, 1, 0) * speed * Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.S))
            {
                transform.position += new Vector3(0, -1, 0) * speed * Time.deltaTime;
            }

            if (Input.GetKeyDown(KeyCode.P))
            {
                if (a == false)
                {
                    Debug.Log("turned off");
                    a = true;
                    test.simulated = false;
                }
                else if (a == true)
                {
                    Debug.Log("turned onn");
                    a = false;
                    test.simulated = true;
                }

            }




        }
    }
}