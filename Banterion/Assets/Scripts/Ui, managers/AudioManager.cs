using UnityEngine.Audio;
using System;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    //create a storage of sound stored in cs "Sound"
    public Sound[] sounds;

    public static AudioManager instance;

    // Start is called before the first frame update
    void Awake() // use settings from the cs "Sound"
    {

        if (instance == null)
            instance = this;
        else
        {

            Destroy(gameObject);
            return;
        }


        DontDestroyOnLoad(gameObject);

        foreach (Sound s in sounds)
        {

            s.source = this.gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }
    }

    void Start()
    {

        //Play("music that plays on startup");
    }


    public void Play(string name)
    {

        //play a sound from the array, playes  a sound based on its name
        //used via AudioManager.instance.Play("name of a sound")
        Sound s = Array.Find(sounds, sound => sound.name == name);
        //stops trying to play a non-existant 
        if (s == null)
        {

            Debug.LogWarning("Sound : " + name + " not found");
            return;
        }

        s.source.Play();

    }


}