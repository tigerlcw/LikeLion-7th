using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour {
    static DataManager instance;
    public bool PlayerDie = false;
    //게임플레이타임
    public float playerTimeCurrent = 15f;
    public float playerTimeMax = 15f;
    public int stage = 0; //맵번호
    public int stageView = 0; // 스테이지 뷰
    public static DataManager Instance
    {
        get
        {
            return instance;
        }
    }
    private void Awake()
    {
        if (instance == null)
        {
            DontDestroyOnLoad(gameObject);
            instance = this;
        }
        else
        {
            DestroyObject(gameObject);
        }
    }
    public int score = 0;
}
