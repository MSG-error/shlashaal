using UnityEngine;

public class HammerCollision : MonoBehaviour
{
    public AudioSource destroySound; // Reference to the audio source for the destroy sound

    // Detects when the hammer collides with the rock
    private void OnCollisionEnter(Collision collision)
    {
        // Check if the object is tagged as "Destructible"
        if (collision.gameObject.CompareTag("Destructible"))
        {
            // Play the destroy sound
            destroySound.Play();

            // Destroy the object after the sound has finished playing
            Destroy(collision.gameObject, destroySound.clip.length);
        }
    }
}
