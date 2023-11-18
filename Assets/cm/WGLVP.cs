using UnityEngine.Video;
using UnityEngine;
/// <summary>
/// CM : Testing WebGL VP workaround using "StreamingAssets" Folder 
/// </summary>
public class WGLVP : MonoBehaviour
{
    [Header(" VideoplayerConfigurations")]
    [SerializeField] private string videoFileName;  // name of file we want to play 
    // Start is called before the first frame update
    void Start()
    {
        PlayVideo();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PlayVideo()
    {
        // grabbing vp component the script is attached to 
        VideoPlayer videoPlayer = GetComponent<VideoPlayer>();
        // check if vP reference 
        if (videoPlayer)
        {
            // grabs video path through folder path to grab file path 
            string videoPath = System.IO.Path.Combine(Application.streamingAssetsPath, videoFileName);
            Debug.Log(videoPath);
            videoPlayer.url = videoPath;  // URL set to videoPath
            videoPlayer.Play();
        }
    }
}
