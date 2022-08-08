using UnityEngine.Audio;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    public Sound[] sounds;

    public static AudioManager instance;

    // Play Sounds with FindObjectOfType<AudioManager>().Play("name des sounds")
    void Awake() {

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

        foreach (Sound s in sounds) 
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s. loop;
        }
    }

    public void Play (string name) 
    {
        //Sound s = Array.Find(sounds, sound => sound.name == name);
        Sound s = null;
        foreach(Sound so in sounds) 
        {
            if (so.name == name) 
            {
                s = so;
            }
        }
        if (s == null) 
        {
            Debug.LogWarning("Der sound " + name + " ist nicht in der Array Liste!");
            return;
        }
        s.source.Play();
    }
}
