using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutGochiScript : MonoBehaviour
{
    public int count = 0; // 빈 오브젝트 다음 순서로 넘기기 위한 함수

    private string testName;
    public Transform testcube;
    public Vector3 pos;
    public bool BoolTorF = false;
    public int FirstCount = 0;

    public string[] InputList = new string[3];
    public string InputTag; // 충돌한 태그 저장해둠

    public GameObject Tut1;
    public GameObject Tut2;
    public GameObject Tut3;
    public GameObject Tut4;

    public void OnCollisionEnter(Collision collision)
    {
        if (count < 3) // 5개까지 최대로 들어가고, 이 이상은 안들어감
        {
            if (collision.gameObject.tag == "Ham" || collision.gameObject.tag == "Gesal" || collision.gameObject.tag == "Mush" || collision.gameObject.tag == "Papric" || collision.gameObject.tag == "pa")
            {
                InputTag = collision.gameObject.tag; // 충돌한 오브젝트 태그값을 저장
                InputList[count] = InputTag;
                count = count + 1; // 다음으로 넘어갈 수 있게 함

                testcube.transform.Find("T" + collision.gameObject.tag + count.ToString()).gameObject.SetActive(true);

                pos = GameObject.Find("PosEmpty").transform.position;
                collision.gameObject.transform.position = pos;

                Destroy(collision.gameObject, 3);  // 충돌한 게임 오브젝트 삭제
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (FirstCount == 0)
        {
            if (count > 0)
            {
                FirstCount = 1;
                // 2) 초기화 버튼을 누르면 만드는 중인 꼬치를 버리고, 새로운 꼬치를 만들 수 있습니다
                Debug.Log("1) 초기화 버튼을 누르면 만드는 중인 꼬치를 버리고, 새로운 꼬치를 만들 수 있습니다");
            }
        }
        if (count == 3)
        {
            if (FirstCount == 2)
            {
                if (InputList[0] == "Ham" && InputList[1] == "Ham" && InputList[2] == "Ham")
                {
                    // 4) 꼬치를 완성했으면 제출 버튼을 눌러요. 다음 꼬치를 만들 수 있어요.
                    Debug.Log("4) 꼬치를 완성했으면 제출 버튼을 눌러요. 다음 꼬치를 만들 수 있어요.");
                    FirstCount = 3;
                    Tut2.SetActive(false);
                    Tut3.SetActive(true);
                }
            }
        }
        if (FirstCount == 2)
        {
            if (Tut2.activeSelf == false)
            {
                Tut1.SetActive(false);
                Tut2.SetActive(true);
                Tut3.SetActive(false);
                Debug.Log(" 3) 이번에는 주문을 보고 알맞은 꼬치를 만들어볼까요? 햄 - 햄 - 햄을 꽂아봅시다.");
            }
        }
    }
}
