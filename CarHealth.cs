using UnityEngine;
using UnityEngine.UI;

public class CarHealth : MonoBehaviour
{
    public int maxHealth = 10;
    private int currentHealth;

    public Text healthText;

    private void Start()
    {
        currentHealth = maxHealth;
        UpdateHealthUI();
    }

    public void TakeDamage(int amount)
    {
        currentHealth -= amount;
        UpdateHealthUI();

        if (currentHealth <= 0)
        {
            Debug.Log("Game Over");
           
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Check if the colliding object has a tag "Obstacle" (change it to match your objects)
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            TakeDamage(1); // Decrease health by 1
        }
    }

    private void UpdateHealthUI()
    {
        healthText.text = "Health: " + currentHealth.ToString();
    }
}
