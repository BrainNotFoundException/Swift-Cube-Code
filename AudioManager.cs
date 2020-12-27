using System;
using UnityEngine.Audio;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    public Sound[] sounds;

    public static AudioManager instance;

    // Start is called before the first frame update
    void Awake()
    {

        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);

        foreach (Sound sound in sounds) {

            sound.source = gameObject.AddComponent<AudioSource>();

            sound.source.clip = sound.clip;

            //sound.source.volume = sound.volume;
            sound.source.pitch = 1f;
            sound.source.loop = sound.loop;
        }

    }

    public void Play(string soundName) {

        Sound s = Array.Find(sounds, sound => sound.name == soundName);

        if (s == null) {
            Debug.LogError("Sound " + soundName + " does not exist");
            return;
        }

        s.source.Play();
        //s.source.volume;

    }

    public void Stop(string soundName){

        Sound s = Array.Find(sounds, sound => sound.name == soundName);

        s.source.Stop();

    }

    public void ChangeVolume(float volume) {

        foreach (Sound sound in sounds) {
            sound.source.volume = volume;
        }
    
    }

}
