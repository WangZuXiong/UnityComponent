using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(WidgetSwitcher), true)]
public class WidgetSwitcherEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        WidgetSwitcher temp = target as WidgetSwitcher;

        Debug.LogError(temp.ActiveIndex);
    
        int length = temp.transform.childCount;

        for (int i = 0; i < length; i++)
        {
            temp.transform.GetChild(i).gameObject.SetActive(temp.ActiveIndex == i);
        }
    }
}