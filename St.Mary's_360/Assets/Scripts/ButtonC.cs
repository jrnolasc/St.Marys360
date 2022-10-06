using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Video;

public class ButtonC : MonoBehaviour


{
    public VideoPlayer Video;
    public VideoClip ClipChange;
    public Animator animator;
    public PlayableDirector Fade;
    public PlayableDirector FadeBack;

    public GameObject[] triggers;
    public GameObject[] deactivate;
    GameObject ReturnButton;
    

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void VideoSwitch()
    {
        Video.clip = ClipChange;
        Video.Play();
        Fade.Play();

    }

    public void HeadHome()
    {
        FadeBack.Play();
        this.gameObject.SetActive(false);

    }
    public void PlayCCVideo()
    {
        Video.clip = ClipChange;
        Video.Play();
        FadeBack.Play();
    }
    public void StopCCVideo()
    {
        Video.Pause();
    }

    public void ResumeCCVideo()
    {
        Video.Play();
    }
    public void FFCCVideo()
    {
        Video.time = Video.time * 100;
    }
    public void RWCCVideo()
    {
        
    }

    public void Switches()
    {
        for (int i = 0; i < deactivate.Length; i++)
        {
            deactivate[i].SetActive(false);
        }

        for (int i = 0; i < triggers.Length; i++)
        {
            triggers[i].SetActive(true);
        }
    }
}
