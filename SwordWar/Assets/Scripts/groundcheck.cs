using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groundcheck : MonoBehaviour
{
    public bool OnGround;
    private void OnColliderEnter(Collider other)
    {
        if (other.tag == "ground")
        {
            OnGround = true;
        }
    }
}
