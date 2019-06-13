using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenseSpawners : MonoBehaviour
{
    Defender defender;

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            AttemptToPlaceDefenderAt(GetSquareClicked());
        }
        else if (Input.GetMouseButtonDown(1))
        {
            return;
        }
        else if (Input.GetMouseButtonDown(2))
        {
            return;
        }
    }

    public void SetSelectedDefender(Defender defenderToSelect)
    {
        defender = defenderToSelect;
    }

    private void AttemptToPlaceDefenderAt(Vector2 gridPos)
    {
        var GoldDisplay = FindObjectOfType<GoldDisplay>();
        int defenderCost = defender.GetGoldCost();

        if (GoldDisplay.HaveEnoughGold(defenderCost))
        {
            SpawnDefense(gridPos);
            GoldDisplay.TakeFromGold(defenderCost);
        }
    }

    private Vector2 GetSquareClicked()
    {
        Vector2 clickPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 worldPos = Camera.main.ScreenToWorldPoint(clickPos);
        Vector2 gridPos = SnapToGrid(worldPos);
        return gridPos;
    }

    private Vector2 SnapToGrid(Vector2 rawWorldPos)
    {
        float newX = Mathf.RoundToInt(rawWorldPos.x);
        float newY = Mathf.RoundToInt(rawWorldPos.y);
        return new Vector2(newX, newY);
    }

    private void SpawnDefense(Vector2 roundedPos)
    {
        Defender newDefense = Instantiate(defender, roundedPos, Quaternion.identity) as Defender;
    }
}
