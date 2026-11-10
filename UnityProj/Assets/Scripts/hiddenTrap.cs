using UnityEngine;

public class hiddenTrap : MonoBehaviour
{
    public GameObject trap;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //gameObject.SetActive(true);
        trap.SetActive(true);
    }
}
