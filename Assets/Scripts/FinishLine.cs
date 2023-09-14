using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] ParticleSystem FinishObject;
    [SerializeField] float FinishDelay = 1.5f;

    bool hasFinished = false; // set if not yet finish
    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Jye" && !hasFinished) 
        {
            hasFinished = true; // // if finished then it will go back from the code and it will not run the if code again
            FinishObject.Play();
            GetComponent<AudioSource>().Play();
            Invoke("ReloadScene", FinishDelay);
           
        }
        
    }
    

    void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
