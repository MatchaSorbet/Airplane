using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class TouchHelper
{
#if UNITY_EDITOR
    public static bool Touch2 => Input.GetMouseButtonDown(1);     //  마우스 오른쪽 버튼
    public static bool isDown => Input.GetMouseButtonDown(0);   //  마우스 왼쪽 버튼
    public static bool isUp => Input.GetMouseButtonUp(0);
    public static Vector2 TouchPosition => Input.mousePosition;
#else
    public static bool Touch2 => Input.touchCount == 2 && (Input.GetTouch(1).phase == TouchPhase.Began);
    public static bool isDown => Input.GetTouch(0).phase == TouchPhase.Began;
    public static bool isUp => Input.GetTouch(0).phase == TouchPhase.Ended;
    public static Vector2 TouchPosition => Input.GetTouch(0).position;
#endif

}
