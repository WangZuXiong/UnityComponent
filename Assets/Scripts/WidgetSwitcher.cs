using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class WidgetSwitcher : MonoBehaviour
{
    public int ActiveIndex = 0;

    private void Awake()
    {
        int length = transform.childCount;

        for (int i = 0; i < length; i++)
        {
            transform.GetChild(i).gameObject.SetActive(ActiveIndex == i);
        }
    }
}
