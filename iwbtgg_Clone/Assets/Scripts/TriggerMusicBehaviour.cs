﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerMusicBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject music;
    
    void Start()
    {

        music.SetActive(false);
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            music.SetActive(true);
            

        }
    }

}
