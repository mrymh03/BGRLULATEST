using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
/// <summary>
///  Handles play pause button behavior and communicates with CVP 
/// </summary>
public class PlayPauseButtonBehaviour : MonoBehaviour ,IPointerEnterHandler, IPointerExitHandler
{
    public Sprite PlaySprite, PlayHoverSprite, PauseSprite, PauseHoverSprite;
    public Button PPButton;
    public bool videoPaused = false;
    public CinemaVideoPlayer cinemaVideoPlayer; 
    public void OnPointerEnter(PointerEventData eventData)
    {
        if (cinemaVideoPlayer.videoPlayer.isPlaying)
        {
            PPButton.image.sprite = PauseHoverSprite;      
        }
        else if (cinemaVideoPlayer.videoPlayer.isPaused)
        {
            PPButton.image.sprite = PlayHoverSprite;
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
       if (cinemaVideoPlayer.videoPlayer.isPlaying)  
        {
            PPButton.image.sprite = PauseSprite;
        }
        else if (cinemaVideoPlayer.videoPlayer.isPaused)
        {
            PPButton.image.sprite = PlaySprite;
        }
    }

    public void PlayPauseVideo()
    {
        if (cinemaVideoPlayer.videoPlayer.isPlaying)
        {
            cinemaVideoPlayer.videoPlayer.Pause(); 
            PPButton.image.sprite = PlaySprite;
            videoPaused = true;
        }
        else if (cinemaVideoPlayer.videoPlayer.isPaused)
        {
            cinemaVideoPlayer.videoPlayer.Play();
            PPButton.image.sprite = PauseSprite;
            videoPaused = false;
        }
    }
}
