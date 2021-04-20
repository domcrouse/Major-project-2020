using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    //Plays appropiate audio upon collision
    void OnCollisionEnter(Collision col)
    {
        if (col.collider.tag == "")
        {
            FindObjectOfType<AudioManager>().Play("");
        }
    }
}
