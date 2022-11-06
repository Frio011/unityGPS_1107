using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NextButton : MonoBehaviour
{
    public Rigidbody HamPrefab;
    public Transform HamTrans;
    public Rigidbody PaPrefab;
    public Transform PaTrans;
    public Rigidbody PapricPrefab;
    public Transform PapricTrans;
    public Rigidbody MushPrefab;
    public Transform MushTrans;
    public Rigidbody GesalPrefab;
    public Transform GesalTrans;
    public GameObject[] Tags;
    public ButtonScript Bts;

    private string[] Foodtags = { "Ham", "Mush", "pa", "Gesal", "Papric"};
    public void Button_clicked()
    { 
        if(Bts.LastQ < 1)
        {
            for (int i = 0; i < Foodtags.Length; i++)
            {
                Tags = GameObject.FindGameObjectsWithTag(Foodtags[i]);
                for (int j = 0; j < Tags.Length; j++)
                {
                    Destroy(Tags[j]);
                }
            }
            for (int i = 0; i < 3; i++)
            {
                Instantiate(HamPrefab, HamTrans.position, HamTrans.rotation);
                Instantiate(GesalPrefab, GesalTrans.position, GesalTrans.rotation);
                Instantiate(MushPrefab, MushTrans.position, MushTrans.rotation);
                Instantiate(PapricPrefab, PapricTrans.position, PapricTrans.rotation);
                Instantiate(PaPrefab, PaTrans.position, PaTrans.rotation);
            }
        }
    }

}
