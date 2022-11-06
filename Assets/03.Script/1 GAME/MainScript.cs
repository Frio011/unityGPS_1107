using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// 꼬치에 들어갈 메인 스크립트
public class MainScript : MonoBehaviour
{
    public int count = 0; // 빈 오브젝트 다음 순서로 넘기기 위한 함수

    private string testName;
    public Transform testcube;
    public Vector3 pos;

    public string[] InputList = new string[5];
    public string InputTag; // 충돌한 태그 저장해둠

    public void OnCollisionEnter(Collision collision)
    {
        if (count < 5) // 5개까지 최대로 들어가고, 이 이상은 안들어감
        {
            if(collision.gameObject.tag == "Ham" || collision.gameObject.tag == "Gesal" || collision.gameObject.tag == "Mush" || collision.gameObject.tag == "Papric" || collision.gameObject.tag == "pa")
            {
                InputTag = collision.gameObject.tag; // 충돌한 오브젝트 태그값을 저장
                InputList[count] = InputTag;
                count = count + 1; // 다음으로 넘어갈 수 있게 함

                transform.Find("T" + InputTag + count.ToString()).gameObject.SetActive(true);

                pos = GameObject.Find("PosEmpty").transform.position;
                collision.gameObject.transform.position = pos;

                Destroy(collision.gameObject, 3);  // 충돌한 게임 오브젝트 삭제
            }
        }
    }

    void Start()
    {
        testcube = GameObject.Find("Cube").transform.Find("");
    }

    void Update()
    {
        
    }
}