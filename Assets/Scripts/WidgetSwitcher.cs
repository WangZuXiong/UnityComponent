using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class WidgetSwitcher : MonoBehaviour
{
    [SerializeField]
    private int _activeIndex = 0;
    public int ActiveIndex
    {
        get
        {
            return _activeIndex;
        }
        set
        {
            _activeIndex = value;
            //_activeIndex = Mathf.Clamp(0, transform.childCount, value);
        }
    }


    private void Awake()
    {
        SetActiveWidgetIndex(ActiveIndex);
    }

    public void SetActiveWidgetIndex(int activeIndex)
    {
        ActiveIndex = activeIndex;
        int length = transform.childCount;

        for (int i = 0; i < length; i++)
        {
            transform.GetChild(i).gameObject.SetActive(ActiveIndex == i);
        }
    }
}
