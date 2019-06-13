using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defender : MonoBehaviour
{
    [SerializeField] float currentSpeed = 0f;
    [SerializeField] int goldCost = 5;
    GameObject currentTarget;

    void Update()
    {
        transform.Translate(Vector2.right * currentSpeed * Time.deltaTime);
    }

    public void SetMovementSpeed(float speed)
    {
        currentSpeed = speed;
    }

    public void AddToGold(int amount)
    {
        FindObjectOfType<GoldDisplay>().AddToGold(amount);
    }

    public int GetGoldCost()
    {
        return goldCost;
    }

}

