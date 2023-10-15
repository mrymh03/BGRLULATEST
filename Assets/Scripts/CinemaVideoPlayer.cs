using System;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;

public class CinemaVideoPlayer : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public GameObject Panel;
    public PlayPauseButtonBehaviour PlayPauseButton;
    private GameObject progress;
    private Image fillBar;
    private Animator animator;


    public void SelectVideo(string videoTitle)
    { 
        string fileSource = "file://Assets/cinema_videos/" + videoTitle;
        videoPlayer.url = fileSource;
        videoPlayer.source = VideoSource.Url;
        videoPlayer.Play();
    }

    public void StopVideo()
    {
        videoPlayer.Stop();
    }

    private void Start()
    {
        if (videoPlayer.url != null)
        {
            progress = GameObject.Find("ProgressBarFill");

            fillBar = progress.GetComponent<Image>();
        }
    }
    private void Update()
    {
        if (videoPlayer.frameCount > 0)
        {
            fillBar.fillAmount = (float)videoPlayer.frame / (float)videoPlayer.frameCount;

            long playerCurrentFrame = videoPlayer.frame;
            long playerFrameCount = Convert.ToInt64(videoPlayer.frameCount);

            if (!videoPlayer.isPlaying && videoPlayer.frame > 0 && !PlayPauseButton.videoPaused)
            {
                ClosePanel();
            }
        }
    }

    //stolen from PanelOpener Script
    public void ClosePanel()
    {
        if (Panel != null)
        {
            animator = Panel.GetComponent<Animator>();

            if (animator != null)
            {
                bool isOpen = animator.GetBool("Open");
                if (isOpen == true)
                {
                    animator.SetBool("Open", !isOpen);
                }
            }
        }
    }
}