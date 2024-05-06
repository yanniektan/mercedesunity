using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class DrivingAudio : MonoBehaviour
{
    public AudioSource DavidAttenborough; // Reference to the AudioSource component

    void Update()
    {
        // Check if the 'D' key is pressed
        if (Input.GetKeyDown(KeyCode.D))
        {
            StartCoroutine(PlayNarrationAndReset());
        }
    }

    IEnumerator PlayNarrationAndReset()
    {
        // Play the narration audio if it's not already playing
        if (!DavidAttenborough.isPlaying)
        {
            DavidAttenborough.Play();
            // Wait until the audio clip finishes playing
            yield return new WaitForSeconds(DavidAttenborough.clip.length + 5);

            // Implement the reset logic here
            // For example, reload the current scene for a simple reset
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
