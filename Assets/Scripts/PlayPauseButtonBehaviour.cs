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

    /// <summary>
    /// Displays hover sprite of play/pause button while mouse hovers
    /// </summary>
    /// <param name="eventData"></param>
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

    /// <summary>
    /// Displays regular sprite of play/pause button when mouse stops hovering over the button
    /// </summary>
    /// <param name="eventData"></param>
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

    /// <summary>
    /// Plays and Pauses the video when play/pause button is clicked
    /// </summary>
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
