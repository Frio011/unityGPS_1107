using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutSponScript : MonoBehaviour
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

    public GameObject GochiLoad;

    private string[] Foodtags = { "Ham", "Mush", "pa", "Gesal", "Papric" };
    public void Button_clicked()
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
        GochiLoad.GetComponent<TutGochiScript>().count = 0;

        if (GochiLoad.GetComponent<TutGochiScript>().FirstCount == 2)
        {
            GochiLoad.GetComponent<TutGochiScript>().Tut3.SetActive(false);
            GochiLoad.GetComponent<TutGochiScript>().Tut2.SetActive(true);
            GochiLoad.GetComponent<TutGochiScript>().InputList[2] = "Gesal";
            GochiLoad.GetComponent<TutGochiScript>().FirstCount = 2;
        }
    }
    
    public void aaa()
    {
        // 초기화 버튼에 넣을 것
        if (GochiLoad.GetComponent<TutGochiScript>().FirstCount == 1)
        {
            GochiLoad.GetComponent<TutGochiScript>().FirstCount = 2;
        }
        if (GochiLoad.GetComponent<TutGochiScript>().FirstCount == 3)
        {
            GochiLoad.GetComponent<TutGochiScript>().FirstCount = 2;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
