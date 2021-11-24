using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace movement2
{



     
    public class movement2 : MonoBehaviour
    {

        public float jumpforce;
        [SerializeField] Rigidbody2D rb;
        private bool isGrounded;
        [SerializeField] Rigidbody2D gravity;
        bool redmode = true;
        [SerializeField] public float speed;


        // Start is called before the first frame update
        void Start()
        {

        }
       
        // Update is called once per frame
        void Update()
        {
            sidewayy();
          
            if (redmode == true)
            {
                if (Input.GetKey(KeyCode.W))
                {
                    transform.position += new Vector3(0, 1, 0) * speed * Time.deltaTime;
                }
                if (Input.GetKey(KeyCode.S))
                {
                    transform.position += new Vector3(0, -1, 0) * speed * Time.deltaTime;
                }

            }

            if (redmode == false)
            {
                if (Input.GetKeyDown(KeyCode.W) && isGrounded)
                {
                    rb.AddForce(Vector2.up * jumpforce, ForceMode2D.Impulse);
                    isGrounded = false;
                    Debug.Log("Jumped");
                    //jump mech
                } 
               
            }



            if (Input.GetKeyDown(KeyCode.P))
            {
                Debug.Log("a");
                if (redmode == false)
                {
                    Debug.Log("Blue mode");
                    redmode = true;
                    gravity.simulated = false;


                }
                else if(redmode == true)
                {
                    Debug.Log("Normal");
                    redmode = false;
                    gravity.simulated = true;

                }



            }



        }



        void sidewayy()
        {
            if (Input.GetKey(KeyCode.A))
            {

                transform.position += new Vector3(-1, 0, 0) * speed * Time.deltaTime;


            }


            if (Input.GetKey(KeyCode.D))
            {

                transform.position += new Vector3(1, 0, 0) * speed * Time.deltaTime;

            }
        }
       
        private void OnCollisionEnter2D(Collision2D other)
        {
            if(other.gameObject.tag == "Border")
            {
                isGrounded = true;
            }
        }
    }
}