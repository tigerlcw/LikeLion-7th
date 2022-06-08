using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour {

    public GameObject[] NumberImage;
    public Sprite[] Number;
    //timebar
    public Image TimeBar;
    //endpanel
    public GameObject EndPanel;
    //맵 정보 배열
    public GameObject[] StageMap;
    public GameObject LoadMap; //로드맵 오브젝트

    public void Next_Stage()
    {
        //stage up
        DataManager.Instance.stage += 1;
        DataManager.Instance.stageView += 1;

        //3개의 스테이지
        if(DataManager.Instance.stage > StageMap.Length)
        {
            DataManager.Instance.stage = DataManager.Instance.stage % StageMap.Length;
            if(DataManager.Instance.stage == 0)
            {
                DataManager.Instance.stage = StageMap.Length;
            }
        }
        StageStart();
    }
    public void StageStart()
    {
        for (int temp =1; temp <= StageMap.Length; temp++)
        {
            if (temp == DataManager.Instance.stage)
            {
                //맵 고정
                StageMap[temp - 1].transform.position = new Vector3(15f, StageMap[temp - 1].transform.position.y, StageMap[temp - 1].transform.position.z);
                // 맵 로드
                StageMap[temp - 1].SetActive(true);
            }
            else
            {
                StageMap[temp - 1].SetActive(false);
            }
        }
    }

    public void Load_Map()
    {
        //맵 고정
        LoadMap.transform.position = new Vector3(15f, LoadMap.transform.position.y, LoadMap.transform.position.z);
        LoadMap.SetActive(true);
    }

    private void Update()
    {

        int temp = DataManager.Instance.score / 100;
        NumberImage[0].GetComponent<Image>().sprite = Number[temp];
        int temp2 = DataManager.Instance.score % 100;

        temp2 = temp2 / 10;
        NumberImage[1].GetComponent<Image>().sprite = Number[temp2];

        int temp3 = DataManager.Instance.score % 10;
        NumberImage[2].GetComponent<Image>().sprite = Number[temp3];

        if (!DataManager.Instance.PlayerDie)
        {
            DataManager.Instance.playerTimeCurrent -= 1 * Time.deltaTime;

            //timebar full -1 out - 0
            TimeBar.fillAmount = DataManager.Instance.playerTimeCurrent / DataManager.Instance.playerTimeMax;


            //시간초과 종료
            if (DataManager.Instance.playerTimeCurrent < 0)
            {
                //배경음악끄기
                SoundManager.Instance.StopSound("BG");
                DataManager.Instance.PlayerDie = true;
                //배경끄기
            }

      


        }
        //게임종료시
        if (DataManager.Instance.PlayerDie == true)
        {
            EndPanel.SetActive(true);
        }

    }
    public void Restart_Btu()
    {
        DataManager.Instance.score = 0;
        DataManager.Instance.PlayerDie = false;
        DataManager.Instance.playerTimeCurrent = DataManager.Instance.playerTimeMax;
        SceneManager.LoadScene("dangrun");
        SoundManager.Instance.PlaySound("BG");
    }
}
