using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustTrail : MonoBehaviour
{
    [SerializeField] ParticleSystem trailParticles;
    void OnCollisionEnter2D(Collision2D other) 
    {
        trailParticles.Play();    
    }
    void OnCollisionExit2D(Collision2D other) 
    {
        trailParticles.Stop();
    }
}
