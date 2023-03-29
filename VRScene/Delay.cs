using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class Delay : MonoBehaviour
{
    public VideoPlayer MyVideoPlayer;
    public bool isPlaying = false;
    public int StoppedTime = 0;
    public float DelayTime = 20f;

    void Start()
    {
        Invoke("PlayVideo", DelayTime);
    }

    void PlayVideo()
    {
        Debug.Log("e");

        MyVideoPlayer = GetComponent<VideoPlayer>();
        MyVideoPlayer.Play();
        isPlaying = true;
    }
    private void Update()
    {
        if (isPlaying)
        {
            if (!MyVideoPlayer.isPlaying)
            {
                StoppedTime++;
            }

        }
        if (isPlaying && StoppedTime > 40)
        {
            SceneManager.LoadSceneAsync(1);
        }
    }
}

