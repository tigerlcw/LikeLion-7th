using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour {

	private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag.CompareTo("Player")==0)
        {
            //coin sound import
            SoundManager.Instance.PlaySound("Coin");
            DataManager.Instance.score += 1;
            gameObject.SetActive(false);
        }
    }
}
