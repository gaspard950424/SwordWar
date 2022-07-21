using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace pengu
{

    public class characterCtrl : MonoBehaviour
    {
       public LayerMask whatIsGround;

        Transform groundcheck;
 
        public Transform target;
        Rigidbody rigidbody;
        Collider collider;
        // Start is called before the first frame update
        void Start()
        {
            rigidbody = GetComponent<Rigidbody>();
            collider = GetComponent<Collider>();
            groundcheck = transforn.find("GroundCheck");
        }
       
        // Update is called once per frame
        void Update()
        {
            GroundCheck();
            //控制

                transform.Translate(0, 0, 7 * Time.deltaTime * Input.GetAxis("Vertical"));
                transform.Translate(7 * Time.deltaTime * Input.GetAxis("Horizontal"), 0, 0);
                if (Input.GetButtonDown("Jump"))
                {
                    rigidbody.AddForce(transform.up * 8, ForceMode.VelocityChange);
                }
            
            //主角看著target
            transform.LookAt(target);
        }

        public void GroundCheck()
        {
            bool onGround;
            if (Physics2D.OverlapCircleAll(groundCheck.position, groundCheckRadius, whatIsGround).Length > 0)
                onGround = true;
            else
                onGround = false;
        }

        //public bool OnGround = false;
        //private void OnColliderEnter(Collider other)
        //{
        //    if (other.tag == "ground")
        //    {
        //        OnGround = true;
        //    }
        //    else { OnGround = false; }
        //}
    }
}
