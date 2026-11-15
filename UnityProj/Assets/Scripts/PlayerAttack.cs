using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAttack : MonoBehaviour
{
    public Animator animator;

    public GameObject bulletPrefab;
    public Transform firePoint;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Attack();
        Shoot();
    }

    void Attack()
    {
        if (Keyboard.current.fKey.isPressed) //NOTE: F key is the SWORD button
        {
            animator.SetBool("attack", true);
        }
        else
        {
            animator.SetBool("attack", false);
        }
    }

    void Shoot()
    {
        if (Keyboard.current.qKey.wasPressedThisFrame) //NOTE: Q key is the SHOOT button
        {
            Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        }
    }
}
