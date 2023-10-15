using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class PlayPauseButtonBehaviour : CinemaVideoPlayer, IPointerEnterHandler, IPointerExitHandler
{
    public Sprite PlaySprite, PlayHoverSprite, PauseSprite, PauseHoverSprite;
    public Button PPButton;
    public bool videoPaused = false;

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (videoPlayer.isPlaying)
        {
            PPButton.image.sprite = PauseHoverSprite;      
        }
        else if (videoPlayer.isPaused)
        {
            PPButton.image.sprite = PlayHoverSprite;
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (videoPlayer.isPlaying)
        {
            PPButton.image.sprite = PauseSprite;
        }
        else if (videoPlayer.isPaused)
        {
            PPButton.image.sprite = PlaySprite;
        }
    }

    public void PlayPauseVideo()
    {
        if (videoPlayer.isPlaying)
        {
            videoPlayer.Pause();
            PPButton.image.sprite = PlaySprite;
            videoPaused = true;
        }
        else if (videoPlayer.isPaused)
        {
            videoPlayer.Play();
            PPButton.image.sprite = PauseSprite;
            videoPaused = false;
        }
    }
}
