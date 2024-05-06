using UnityEngine;
using UnityEngine.SceneManagement; // Include this for scene management

public class FinishLine : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Check if the car hits the finish line
        if (other.CompareTag("Car")) // Ensure your car GameObject has the tag "Car"
        {
            // Reset the car or the race
            ResetCar();
            Debug.Log(other.name + " entered the finish line!");

        }
    }

    void ResetCar()
    {
        // Option 1: Reset car position to the start (or a designated reset point)
        // other.transform.position = startPosition;

        // Option 2: Reload the scene, effectively resetting everything
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
