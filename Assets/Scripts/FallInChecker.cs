using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallInChecker : MonoBehaviour
{
    [SerializeField] Hole red;
    [SerializeField] Hole blue;
    [SerializeField] Hole green;

    private void OnGUI()
    {
         string label = " ";
         
         // 全てのボールが入ったらラベルを表示
         if (red.IsFallIn() && blue.IsFallIn() && green.IsFallIn())
         {
             label = "Fall in hole!";
         }
         GUI.Label (new Rect(0, 0, 100, 30), label);
    }
}
