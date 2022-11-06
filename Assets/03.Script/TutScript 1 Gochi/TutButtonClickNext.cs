using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TutButtonClickNext : MonoBehaviour
{
    public int NextImage = 1; // 이미지 전환 번호
    public Image TestImage; // 이미지 전환
    public Text QNum;
    public GameObject GochiLoad;
    public int HamCount = 0;
    public int TutStep = 1;

    public GameObject TutPausePage; // 튜토리얼용 정지페이지
    public GameObject TutEndPage; // 엔드페이지(다음으로 넘어가기 위한 페이지)

    public void NextLevelButton()
    {
        // 하나라도 꽂혀있어야 가능하게 함
        // MainLoad.GetComponent<MainScript>().count
        if (GochiLoad.GetComponent<TutGochiScript>().FirstCount != 1)
        {
            if (GochiLoad.GetComponent<TutGochiScript>().count > 0)
            {
                if (NextImage == 1)
                {
                    NextImage = 2;
                    TestImage.sprite = Resources.Load<Sprite>("Quiz/" + NextImage) as Sprite;
                    QNum.text = "문제 " + NextImage;
                }
            }
        }

        if (GochiLoad.GetComponent<TutGochiScript>().FirstCount == 3)
        {
            GochiLoad.GetComponent<TutGochiScript>().FirstCount = 4;
            GochiLoad.GetComponent<TutGochiScript>().Tut3.SetActive(false);
            GochiLoad.GetComponent<TutGochiScript>().Tut4.SetActive(true);
        }
    }
    public void TutPauseButton()
    {
        TutPausePage.SetActive(true);
    }

    public void TutPauseNo()
    {
        TutPausePage.SetActive(false);
        TutEndPage.SetActive(true);
    }

    public void TutEndPageEnter()
    {
        SceneManager.LoadScene("StickGameScene");
    }
}

/*
    public void GoStickGameButton()
    {
        SceneManager.LoadScene("StickGameScene");
    }

    public GameObject PausePanel;

    public void Pause_btn_clicked()
    {
        if () // pause
        {
            PausePanel.SetActive(true);
        }
        else if () // 튜토리얼
        {
            TutPausePage.SetActive(true);
        }
    }
*/