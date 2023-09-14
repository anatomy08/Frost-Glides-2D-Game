using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] ParticleSystem CrashObject;
   
    [SerializeField] float CrashDelay = .50f;
    [SerializeField] AudioClip CrashSFX;

    bool hasCrashed = false; // set if not yet crash

    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Ground" && !hasCrashed) // when head bump to ground
        {   
            hasCrashed = true; // if crash then it will go back from the code and it will not run the if code again
            FindObjectOfType<PlayerController>().DisableControls();  // when head bumps it will
                                                                       // call the Disablecontrol method under PlayerController
                                                                     // class, which is canMove is set to False.
               
            Invoke("ReloadScene", CrashDelay);
            GetComponent<AudioSource>().PlayOneShot(CrashSFX);
            CrashObject.Play(); // the particle when the head is bump to the ground,
           
        }
        
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


}