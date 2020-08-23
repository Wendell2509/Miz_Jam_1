using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    public AudioClip[] musics;
    private AudioSource src;

    private void Start()
    {
        src = GetComponent<AudioSource>();
        src.loop = true;
    }

    private void Update()
    {
        if (!src.isPlaying)
        {
            src.clip = GetRandomClip();
            src.Play();
        }
    }

    private AudioClip GetRandomClip()
    {
        return musics[UnityEngine.Random.Range(0, musics.Length)];
    }
}