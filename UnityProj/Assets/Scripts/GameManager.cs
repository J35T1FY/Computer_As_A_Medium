using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public GameObject player;
    public GameObject gameOverUI;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject tryHarderUI;
    public GameObject stopThatUI;

    private bool isGameOver = false;
    private bool isWarning = false;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        GameEnd();
        StartCoroutine(Warning());
    }
    IEnumerator Warning()
    {
        if (playerHealth.health == 50)
        {
            isWarning = true;
            stopThatUI.SetActive(true);
            yield return new WaitForSeconds(3f);
            stopThatUI.SetActive(false);
            isWarning = false;

        }
    }

    void GameEnd()
    {
        if (playerHealth.health <= 0 && isGameOver == false)
        {
            isGameOver = true;
            StartCoroutine(BeforeEnd());
        }
    }

    IEnumerator BeforeEnd()
    {
        playerHealth.healthText.text = "Health: 0";
        player.SetActive(false);
        tryHarderUI.SetActive(true);
        yield return new WaitForSeconds(3f);
        tryHarderUI.SetActive(false);
        gameOverUI.SetActive(true);

    }
}