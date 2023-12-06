using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    public static Music Instance { get; set; }
    private AudioSource asMusic;
    
    private void Awake() 
    {
        asMusic = transform.GetChild(0).GetComponent<AudioSource>();
        DontDestroyOnLoad(this);

        if (Instance == null)
        {
            Instance = this;
        }    
        else
        {
            Destroy(gameObject);
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ButtonMusicMute()
    {
        if(asMusic.mute == false)
        {
            asMusic.mute = true;
        }
    }
}
