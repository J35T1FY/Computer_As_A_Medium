using UnityEngine;

public class hiddenTrap : MonoBehaviour
{
    public GameObject hiddenObject;

    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        hiddenObject.SetActive(true);
    }
}
