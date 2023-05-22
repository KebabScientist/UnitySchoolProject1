using UnityEngine;
using UnityEngine.UI;

public class Radio : MonoBehaviour
{
    public AudioClip[] songs; // Array of songs to play
    private AudioSource audioSource; // Reference to the AudioSource component
    private int currentSongIndex = 0; // Index of the currently playing song

    public Text songTitleText; // Reference to the UI text element for song title
    public Text currentlyPlayingText; // Reference to the UI text element for currently playing information

    void Start()
    {
        audioSource = GetComponent<AudioSource>(); // Get the AudioSource component attached to this GameObject
        PlaySong(); // Start playing the first song
    }

    void Update()
    {
        if (!audioSource.isPlaying)
        {
            PlayNextSong(); // If the current song has finished playing, play the next song
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            SkipToNextSong();
        }
    }

    void PlaySong()
    {
        audioSource.clip = songs[currentSongIndex]; // Set the clip of the AudioSource to the current song
        audioSource.Play(); // Start playing the song

        // Update UI with song information
        songTitleText.text = "Song Title: " + audioSource.clip.name; // Display the title of the current song
        currentlyPlayingText.text = "Currently Playing: " + (currentSongIndex + 1) + "/" + songs.Length; // Display the currently playing song index and total song count
    }

    void PlayNextSong()
    {
        currentSongIndex = (currentSongIndex + 1) % songs.Length; // Move to the next song index, wrapping around to the beginning if necessary
        PlaySong(); // Play the next song
    }
    void SkipToNextSong() //allows us to skip a song
    {
        currentSongIndex = (currentSongIndex + 1) % songs.Length;
        audioSource.Stop();
        PlaySong();
    }
}
