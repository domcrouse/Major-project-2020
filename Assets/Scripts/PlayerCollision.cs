using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
    AudioManager audioManager;

    public void Start()
    {
        audioManager = FindObjectOfType<AudioManager>();
    }

    public void Update()
    {
        //Play audio
        if (Input.GetButton("Horizontal"))
        {
            audioManager.Play("Walking");
        }
        
        if (Input.GetButton("Vertical"))
        {
            audioManager.Play("Walking");
        }

        //Pause audio
        if (Input.GetButtonUp("Horizontal"))
        {
            audioManager.Pause("Walking");
        }
        
        if (Input.GetButtonUp("Vertical"))
        {
            audioManager.Pause("Walking");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(0);
        }
    }

    //Plays appropiate audio upon collision
    void OnCollisionEnter(Collision col)
    {
        if (col.collider.tag == "")
        {
            FindObjectOfType<AudioManager>().Play("");
        }
    }
}
