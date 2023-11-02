using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// Opens youtube channel on playlist element button in a browser
/// </summary>
public class ChannelLinkButtonBehaviour : MonoBehaviour
{
    public void OpenLink(string link)
    {
        Application.OpenURL(link);
    }
}
