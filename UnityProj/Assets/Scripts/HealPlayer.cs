using UnityEngine;

public class HealPlayer : MonoBehaviour
{
    public PlayerHealth playerHealth;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // similar to trap script, just does opposite
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (playerHealth.health == 100)
            {
                //does NOTHING!!!
            }
            else
            {
                // actually heals when less than 100 + destroys
                playerHealth.health += 10;
                Destroy(gameObject);
            }
        }
    }
}
