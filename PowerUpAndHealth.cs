using UnityEngine;
using UnityEngine.UI;

public class PowerUpAndHealth : MonoBehaviour
{
    public int maxHealth = 10;
    public int healthIncrease = 10; // Amount to increase player's health
    public float respawnDelay = 10f; // Delay before power-up respawns
    public GameObject powerUpPrefab; // Prefab of the power-up GameObject

    private int currentHealth;
    private bool collected = false;

    public Text healthText;

    private void Start()
    {
        currentHealth = maxHealth;
        UpdateHealthUI();
        SpawnPowerUp();
    }

    private void OnCollisionEnter(Collision collision)
    {
        currentHealth -= 1;
        UpdateHealthUI();

        if (currentHealth <= 0)
        {
            Debug.Log("Game Over"); // You can perform any game over actions here
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!collected && other.gameObject.tag == "PowerUp")
        {
            collected = true;
            ApplyPowerUp();
            Destroy(other.gameObject);
            Invoke("RespawnPowerUp", respawnDelay);
        }
    }

    private void ApplyPowerUp()
    {
        // Apply the power-up effect to the player's health
        currentHealth += healthIncrease;
        if (currentHealth > maxHealth)
            currentHealth = maxHealth;

        UpdateHealthUI();
    }

    private void RespawnPowerUp()
    {
        collected = false;
        SpawnPowerUp();
    }

    private void UpdateHealthUI()
    {
        healthText.text = "Health: " + currentHealth.ToString();
    }

    private void SpawnPowerUp()
    {
        // Spawn the power-up GameObject
        Instantiate(powerUpPrefab, transform.position + new Vector3(0f, 1f, 0f), Quaternion.identity);
    }
}
