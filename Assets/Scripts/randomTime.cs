using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomTime : MonoBehaviour
{
    float controltime;
    float intime;
    public float controlIndex = 0f;
    float turn = 0f;
    float incontrol = 0f;
    public float scoretime = 0f;

    public AudioClip[] audios;
    private AudioSource audioSource1;
    private AudioSource audioSource2; 
    private AudioSource audioSource3;

    // Start is called before the first frame update
    void Start()
    {
        audioSource1 = gameObject.AddComponent<AudioSource>();
        audioSource1.loop = true;
        audioSource1.clip = audios[0];
        audioSource1.volume = 0.5f;
        audioSource1.Play();

        audioSource2 = gameObject.AddComponent<AudioSource>();
        audioSource2.clip = audios[1];
        audioSource2.volume = 0.5f;
        audioSource2.Play();

        audioSource3 = gameObject.AddComponent<AudioSource>();
        audioSource3.clip = audios[2];
        audioSource3.volume = 0.5f;
        audioSource3.Play();
    }

    // Update is called once per frame
    void Update()
    {
        float timeT = Time.time;
        if (turn == 0f)//lumber
        {
            if (incontrol == 0)
            {
                intime = Time.time;
                controltime = Random.Range(1f, 3f);
                incontrol = 1;
                //print("1");
            }

            if (controltime- (timeT - intime) >= 0)
            {
                controlIndex = 0f;//lumber
                                  //print("2");


            }
            if (controltime - (timeT - intime) < 0)
            {
                controlIndex = 1f;
                turn = 1;
                //print("3");
                ChangeMusicTrees();

            }


        }

        if (turn == 1f)//tree
        {
            if (incontrol == 1)
            {
                intime = Time.time;
                controltime = Random.Range(1f, 3f);
                incontrol = 0;
                //print("4");

            }
            if (controltime - (timeT - intime) >= 0)
            {
                controlIndex = 1f;//tree
                //print("5");


            }
            if (controltime - (timeT - intime) < 0)
            {
                controlIndex = 0f;
                turn = 0;
                //print("6");
                ChangeMusicLumber();

            }

            scoretime += timeT - intime;

        }
        //print("controlTime"+controltime+"time"+ timeT + "intime"+intime+"control" + (controltime - (Time.time - intime)));
    }

    void ChangeMusicLumber()
    {
        if (audioSource2.clip != audios[1])
        {
            audioSource2.clip = audios[1];
            audioSource2.Play();

            audioSource3.clip = audios[2];
            audioSource3.Play();
        }
    }

    void ChangeMusicTrees()
    {
        if (audioSource2.clip != audios[3])
        {
            audioSource2.clip = audios[3];
            audioSource2.Play();

            audioSource3.clip = audios[4];
            audioSource3.Play();
        }
    }
}
