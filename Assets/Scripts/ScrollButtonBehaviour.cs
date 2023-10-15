using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollButtonBehaviour: MonoBehaviour
{
    public Scrollbar bar;

    public void ScrollButtonUp()
    {
        float value = (float)bar.value;
        float inc = 0.1F;

        bar.value = value + inc;
    }

    public void ScrollButtonDown()
    {
        float value = (float)bar.value;
        float dec = 0.1F;

        bar.value = value - dec;
    }
}
