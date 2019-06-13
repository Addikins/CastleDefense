using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pointer : MonoBehaviour
{
    float minX = -5.95f;
    float maxX = 5.95f;
    float minY = -3.35f;
    float maxY = 3.35f;
    float screenWidthInUnits = 12f;
    float xOffset = .27f;
    float yOffset = -.25f;
    float zOffset = 2f;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pointerPosition = new Vector3(transform.position.x, transform.position.y);
        Vector3 offset = new Vector3(xOffset, yOffset);
        Vector3 desiredPosition = Input.mousePosition;
        pointerPosition = Camera.main.ScreenToWorldPoint(desiredPosition);
        pointerPosition.x = Mathf.Clamp(pointerPosition.x, minX, maxX);
        pointerPosition.y = Mathf.Clamp(pointerPosition.y, minY, maxY);
        pointerPosition.z += zOffset;
        pointerPosition += offset;
        transform.position = pointerPosition;
    }
}
