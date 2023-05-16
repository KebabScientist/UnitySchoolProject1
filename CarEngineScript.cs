using UnityEngine;

public class SoundPlayer : MonoBehaviour
{
    public AudioClip startSound; //sound that plays in the start 
    public AudioClip loopSound; //engine sound that keeps looping over and over, not interactive
    private AudioSource audioSource;

    void Start()
    {
        //this code lets us get a sound that will only play at the beginning
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = startSound;
        audioSource.Play();
    }

    void Update()
    {
        //meanwhile this code works a loop that will loop the sound over and over when its not pressed on any specific key
        if (!audioSource.isPlaying)
        {
            audioSource.clip = loopSound;
            audioSource.loop = true;
            audioSource.Play();
        }
    }
}
