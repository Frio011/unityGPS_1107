using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class TutNextButton : MonoBehaviour // 다음 버튼
{
    public GameObject TutSellTray;
    private int NextImage2 = 1; // 이미지 전환 번호
    public Image TestImage; // 이미지 전환
    public Text QNum;
    public GameObject NextGamePage;

    public void NextLevelButton2()
    {
        // 하나라도 꽂혀있어야 가능하게 함
        // MainLoad.GetComponent<MainScript>().count
        if (TutSellTray.GetComponent<TutSellTray>().count > 0)
        {
            if (TutSellTray.GetComponent<TutSellTray>().TutC == 1)
            {
                NextImage2 = 2;
                TestImage.sprite = Resources.Load<Sprite>("FQuiz/" + NextImage2) as Sprite;
                QNum.text = "문제 " + NextImage2;

                TutSellTray.GetComponent<TutSellTray>().Circle1.SetActive(false);
                TutSellTray.GetComponent<TutSellTray>().Circle2.SetActive(true);
                Debug.Log("3) 이번에는 주문대로 떡볶이와 파전을 하나씩 올려봅시다.");
                TutSellTray.GetComponent<TutSellTray>().TutC = 2;
            }
        }
        if (TutSellTray.GetComponent<TutSellTray>().TutC == 3)
        {
            NextGamePage.SetActive(true);
        }
    }

    public void realNextGameButton()
    {
        SceneManager.LoadScene("SellGameScene");
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
