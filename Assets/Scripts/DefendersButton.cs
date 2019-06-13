using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefendersButton : MonoBehaviour
{
    [SerializeField] Defender defenderPrefab;

    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var buttons = FindObjectsOfType<DefendersButton>();
            foreach (DefendersButton button in buttons)
            {
                button.GetComponent<SpriteRenderer>().color = new Color32(99, 99, 99, 255);
            }
            GetComponent<SpriteRenderer>().color = Color.white;
            FindObjectOfType<DefenseSpawners>().SetSelectedDefender(defenderPrefab);
        }
        /* else if (Input.GetMouseButtonUp(0))
        {
            GetComponent<SpriteRenderer>().color = Color.gray;
        } */
    }
}
