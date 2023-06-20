using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoalScript : MonoBehaviour
{
    public AudioClip sound2;
    AudioSource audioSource;

    void Start()
    {
        //Component‚ğæ“¾
        audioSource = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("ƒS[ƒ‹‚µ‚Ü‚µ‚½I");
            SceneManager.LoadScene("ClearScene");
            audioSource.PlayOneShot(sound2);
        }
    }
}
