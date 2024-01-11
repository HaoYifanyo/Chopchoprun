using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chop : MonoBehaviour
{

    public AudioSource audioSource;
    public AudioClip[] audios;

    // Start is called before the first frame update
    void Start()
    {
        //audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < 0)
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "lumber")
        {
            //audioSource.Play();
            PlayChopSound();

            Destroy(gameObject);
            // source.PlayOneShot(clip);
        }
    }

    void PlayChopSound()
    {
        int randomNumber = Random.Range(0, 6);

        //Debug.Log(chopSound.clip);
        audioSource.clip = audios[randomNumber];
        audioSource.Play();
        
    }
}
