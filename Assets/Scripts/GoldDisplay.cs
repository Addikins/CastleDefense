using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoldDisplay : MonoBehaviour
{
    [SerializeField] int gold = 100;
    Text goldText;

    void Start()
    {
        goldText = GetComponent<Text>();
        UpdateDisplay();
    }

    private void UpdateDisplay()
    {
        goldText.text = gold.ToString();
    }

    public bool HaveEnoughGold(int cost)
    {
        if (gold >= cost)
        { return true; }
        else { return false; }
    }

    public void AddToGold(int amount)
    {
        gold += amount;
        UpdateDisplay();
    }

    public void TakeFromGold(int amount)
    {
        if (gold >= amount)
        {
            gold -= amount;
            UpdateDisplay();
        }

    }
}
