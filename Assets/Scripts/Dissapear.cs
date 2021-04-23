using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dissapear : MonoBehaviour
{


    public GameObject glowingEyes;
    public GameObject glowingEyes1;

    AudioManager audioManager;

    public void Start()
    {
        audioManager = FindObjectOfType<AudioManager>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            Debug.Log("Collision detected");
            glowingEyes.GetComponent<Renderer>().enabled = false;
            glowingEyes1.GetComponent<Renderer>().enabled = false;
            audioManager.Play("DeepRoar");
        }
    }
}
