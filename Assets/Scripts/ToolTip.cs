using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolTip : MonoBehaviour
{

    bool ObjectIsFollowingMouse = false;
    public GameObject Object;
    Vector3 MousePos;
    Vector2 pos = new Vector2(0f, 0f);
    public Transform Self;
    public float moveSpeed = 1f;


    public void OnMouseEnter()
    {
        Object.SetActive(true);
        ObjectIsFollowingMouse = true;
        Debug.Log("Mouse has enterd");
    }
    void OnPointerExit()
    {
        Object.SetActive(true);
        ObjectIsFollowingMouse = true;
    }


    void Update()
    {
        MousePos = Input.mousePosition;
        MousePos = Camera.main.ScreenToWorldPoint(MousePos);
        pos = Vector2.MoveTowards(Self.position, MousePos, moveSpeed);
    }
}
