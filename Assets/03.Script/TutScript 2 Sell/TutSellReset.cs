using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutSellReset : MonoBehaviour // 초기화 버튼
{
    public Rigidbody FCPrefab;
    public Transform FCTrans;
    public Rigidbody KBPrefab;
    public Transform KBTrans;
    public Rigidbody CTPrefab;
    public Transform CTTrans;
    public Rigidbody PJPrefab;
    public Transform PJTrans;
    public GameObject[] Tags;

    public GameObject TutSellMainLoad;

    private string[] RFPKtags = { "Fcake", "Kbob", "Pajun", "Rcake", "FCB" };

    public void Button_clicked()
    {
        for (int i = 0; i < RFPKtags.Length; i++)
        {
            Tags = GameObject.FindGameObjectsWithTag(RFPKtags[i]);
            for (int j = 0; j < Tags.Length; j++)
            {
                Destroy(Tags[j]);
            }
        }
        Instantiate(FCPrefab, FCTrans.position, FCTrans.rotation);
        Instantiate(KBPrefab, KBTrans.position, KBTrans.rotation);
        Instantiate(CTPrefab, CTTrans.position, CTTrans.rotation);
        Instantiate(PJPrefab, PJTrans.position, PJTrans.rotation);
    }
}
