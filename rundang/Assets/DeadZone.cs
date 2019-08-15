﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadZone : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(!DataManager.Instance.PlayerDie)
        {
            if(collision.gameObject.tag.CompareTo("Player")==0)
            {
                //deadzone sound off
                SoundManager.Instance.StopSound("BG");
                DataManager.Instance.PlayerDie = true;
            }
        }
    }
}
