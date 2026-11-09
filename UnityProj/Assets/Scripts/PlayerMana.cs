
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMana : MonoBehaviour

{

    public int mana = 100;

    public TMP_Text ManaText;

    public ParticleSystem magicEffect;

    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void Start()

    {

        ManaText.text = "Press E to use Magic!\nMana: " + mana;

    }

    // Update is called once per frame

    void Update()

    {
        Magic();
    }

    void Magic()
    {
        if (Keyboard.current.eKey.wasPressedThisFrame && mana >=10)
        {
            mana -= 10;

            magicEffect.Play();

            UpdateManaText();
        }
    }
     void UpdateManaText()
    { 
        ManaText.text = "Press E to use Magic!\nMana: " + mana;

    }

}

