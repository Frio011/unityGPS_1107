using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutSellTray : MonoBehaviour // 트레이 인식스크립트
{

    public int i = 0;
    public int Kb = 0; // 김밥
    public int Fc = 0; // 어묵
    public int Rc = 0; // 떡볶이
    public int Pa = 0; // 파전
    public int TutC = 0; // 패턴 정리용
    public int count = 0;

    public GameObject Circle1;
    public GameObject Circle2;
    public GameObject Circle3;

    private void OnTriggerEnter(Collider collider)
    {
        i = 1;

        if (collider.gameObject.tag == "Kbob")
        {
            Kb = Kb + i;
            //Debug.Log("김밥 갯수 : " + Kb);
        }
        if (collider.gameObject.tag == "Fcake")
        {
            Fc = Fc + i;
            //Debug.Log("어묵 갯수 : " + Fc);
        }
        if (collider.gameObject.tag == "Rcake")
        {
            Rc = Rc + i;
            //Debug.Log("떡볶이 갯수 : " + Rc);
        }
        if (collider.gameObject.tag == "Pajun")
        {
            Pa = Pa + i;
            //Debug.Log("파전 갯수 : " + Pa);
        }
        count = count + 1;
        if (TutC == 0)
        {
            Debug.Log("2) 제출 버튼을 누르면 다음 주문으로 넘어갑니다.");
            TutC = 1;
        }
    }
    private void OnTriggerExit(Collider other) // 도마에서 내려가면 카운트 -1
    {
        i = -1;

        if (other.gameObject.tag == "Kbob")
        {
            Kb = Kb + i;
            //Debug.Log("김밥 갯수 : " + Kb);
        }
        if (other.gameObject.tag == "Fcake")
        {
            Fc = Fc + i;
            //Debug.Log("어묵 갯수 : " + Fc);
        }
        if (other.gameObject.tag == "Rcake")
        {
            Rc = Rc + i;
            //Debug.Log("떡볶이 갯수 : " + Rc);
        }
        if (other.gameObject.tag == "Pajun")
        {
            Pa = Pa + i;
            //Debug.Log("파전 갯수 : " + Pa);
        }
        count = count - 1;

    }
    
    private int iPlusMinus(int TagName, int j)
    {
        return TagName = TagName + j;
    }
    

    void Awake()
    {
        Debug.Log("1) 여기에 음식들을 올려보세요.");
    }

    void Update()
    {
        if (Circle1.activeSelf == true)
        {
            Debug.Log("활성화");
        }

        if (Pa == 1 && Rc == 1)
        {
            if (TutC == 2)
            {
                Circle2.SetActive(false);
                Circle3.SetActive(true);
                Debug.Log("4) 제출 버튼을 눌러주세요.");
                TutC = 3;
            }
        }
        if(TutC == 3 && Pa != 1 && Rc != 1)
        {
            TutC = 2;
        }
    }
}
