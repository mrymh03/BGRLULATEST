using System;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;
/// <summary>
/// Lula:  handles video events once clicked  as well as theater management 
/// </summary>
public class CinemaVideoPlayer : MonoBehaviour
{
    [Header(" CinemaVideoPlayer Configurations")]
    [SerializeField] private GameObject theatrePanel;
    [SerializeField] private GameObject[] playlistElements;
    public VideoPlayer videoPlayer;

    public   bool IsPlayin { get; set;  }

    public PlayPauseButtonBehaviour PlayPauseButton;
    private GameObject progress;
    private Image fillBar;
    private Animator animator;

    /// <summary>
    ///  retrieves title of video from string and plays it
    /// </summary>
    /// <param name="videoTitle"></param>
    public void SelectVideo(string videoTitle)
    {
        string fileSource = System.IO.Path.Combine(Application.streamingAssetsPath, videoTitle);
        videoPlayer.url = fileSource;
        videoPlayer.Play();
    }
    /// <summary>
    /// stops the video 
    /// </summary>
    public void StopVideo()
    {
        videoPlayer.Stop();
    }
    /// <summary>
    /// Function that begins the filling of the progress bar when the video is started
    /// </summary>
    private void Start()
    {
        if (videoPlayer.url != null)
        {
            progress = GameObject.Find("ProgressBarFill");

            fillBar = progress.GetComponent<Image>();
        }
    }
    /// <summary>
    ///  FrameCheck running Update 
    /// </summary>
    private void Update()
    {
        FrameCheck(); 
    }

    /// <summary>
    ///  Updates amount progress bar is filled in accordance with the progress of the video 
    ///  Used to be in Update()
    /// </summary>
    public void FrameCheck()
    {
        if (videoPlayer.frameCount > 0)
        {
            fillBar.fillAmount = (float)videoPlayer.frame / (float)videoPlayer.frameCount;

            long playerCurrentFrame = videoPlayer.frame;
            long playerFrameCount = Convert.ToInt64(videoPlayer.frameCount);

            if (!videoPlayer.isPlaying && videoPlayer.frame > 0 && !PlayPauseButton.videoPaused && Application.isFocused)
            {
                ClosePanel();
            }
        }
    }    

    /// <summary>
    /// stolen from PanelOpener Script  
    /// </summary>
    public void ClosePanel()
    {
        animator = theatrePanel.GetComponent<Animator>();

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