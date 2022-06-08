using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeItem : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!DataManager.Instance.PlayerDie)
        {


            if (collision.gameObject.tag.CompareTo("Player") == 0)
            {
                //시간추가
                DataManager.Instance.playerTimeCurrent += 3f;
                //시간 max초과 -> max포함
                if (DataManager.Instance.playerTimeCurrent > DataManager.Instance.playerTimeMax)
                {
                    DataManager.Instance.playerTimeCurrent = DataManager.Instance.playerTimeMax;
                }
                gameObject.SetActive(false); //이미지 오프
            }
        }
    }
}