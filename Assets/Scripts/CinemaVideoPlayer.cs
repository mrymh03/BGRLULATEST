using System;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;
/// <summary>
/// Lula:  handles video events once clicked  as well as theater management 
/// </summary>
public class CinemaVideoPlayer : MonoBehaviour
{
    [Header(" CinemaVideoPlayer Configurartions")]
    [SerializeField] private GameObject theatrePanel;
    [SerializeField] private GameObject[] playlistElements; 
    public VideoPlayer videoPlayer;

  public   bool IsPlayin { get; set;  }

    public PlayPauseButtonBehaviour PlayPauseButton;
    private GameObject progress;
    private Image fillBar;
    private Animator animator;

    /// <summary>
    ///  retrieves string from video and plays 
    /// </summary>
    /// <param name="videoTitle"></param>
    public void SelectVideo(string videoTitle)
    { 
        string fileSource = "file://Assets/cinema_videos/" + videoTitle;
        videoPlayer.url = fileSource;
        videoPlayer.source = VideoSource.Url;
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
    /// 
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
    ///  CODE REVIEW CALLING METHOD IN UPDATE CLARIFIED! 
    /// </summary>
    public void FrameCheck()
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

    /// <summary>
    /// stolen from PanelOpener Script  
    /// </summary>
    public void ClosePanel()
    {
        if (theatrePanel != null)
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



}