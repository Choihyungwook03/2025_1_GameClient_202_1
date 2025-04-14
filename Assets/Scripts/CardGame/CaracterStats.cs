using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor.UI;

public class CaracterStats : MonoBehaviour
{
    public string characterName;
    public int maxHealth = 100;
    public int currentHealth;

    public SliderEditor healthBar;
    public TextMeshProUGUI healthText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
    }

    public void Heal(int amount)
    {
        currentHealth += amount;
    }
}
