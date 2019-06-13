using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopButton : MonoBehaviour
{
    Vector2 menuSelectionPosition = new Vector2(0f, 0f);

    void OnMouseDown()
    {
        if(GetComponent<Animator>().GetBool("isOpen"))
        {
            GetComponent<Animator>().SetBool("isOpen", false);
        }
        else {
            GetComponent<Animator>().SetBool("isOpen", true);
        }
    }
}
