using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLevel : MonoBehaviour
{
       [SerializeField] float delay = 1f;
       [SerializeField] ParticleSystem crashEffect;
       [SerializeField] AudioClip crashSFX;

       bool crashed;
    void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Ground" && !crashed)
        {
            crashed = true;
            FindObjectOfType<PlayerController>().Disable();
            crashEffect.Play();
            GetComponent<AudioSource>().PlayOneShot(crashSFX);
            Invoke("ReloadScene",delay);
        }    
    }
    
    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
