using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {
    public float jump = 12f;
    public float jump2 = 14f;

    int jumpCount = 0;

    public void Jump_Btn()
    {
        if (!DataManager.Instance.PlayerDie)
        {
            if (jumpCount == 0)
            {
                gameObject.GetComponent<Rigidbody2D>().velocity = new Vector3(0, jump, 0);
                jumpCount += 1;

            }
            else if (jumpCount == 1)
            {
                gameObject.GetComponent<Rigidbody2D>().velocity = new Vector3(0, jump2, 0);
                jumpCount += 1;
            }

            /* 키입력 - 스페이스바 
               void Jump ()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigid.AddForce(Vector3.up * JumpPower, ForceMode.Impulse);
        }
    }
    */

        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.CompareTo("Land") == 0)
        {
            jumpCount = 0;
        }
        if (collision.gameObject.tag.CompareTo("Block") == 0)
        {
            DataManager.Instance.playerTimeCurrent -= 1.5f;
        }
    }

}
