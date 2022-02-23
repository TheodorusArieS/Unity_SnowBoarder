using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustParticles : MonoBehaviour
{
    [SerializeField] ParticleSystem dustParticle;
    void OnCollisionEnter2D(Collision2D other) {
        dustParticle.Play();
    }

    void OnCollisionExit2D(Collision2D other) {
        dustParticle.Stop();    
    }

}
