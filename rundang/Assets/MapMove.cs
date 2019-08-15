using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapMove : MonoBehaviour {

    public float mapSpeed = 10f;
	
	// Update is called once per frame
	void Update () {
        if (!DataManager.Instance.PlayerDie)
        {


            transform.Translate(-mapSpeed * Time.deltaTime, 0, 0);
        }
	}
}
