using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] ParticleSystem cashParticles;
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Ground")
        {
            cashParticles.Play();
            Invoke("ReloadScene",0.5f);
        }
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
