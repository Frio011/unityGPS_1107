using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TutButtonClickNext : MonoBehaviour
{
    public int NextImage = 1; // �̹��� ��ȯ ��ȣ
    public Image TestImage; // �̹��� ��ȯ
    public Text QNum;
    public GameObject GochiLoad;
    public int HamCount = 0;
    public int TutStep = 1;

    public GameObject TutPausePage; // Ʃ�丮��� ����������
    public GameObject TutEndPage; // ����������(�������� �Ѿ�� ���� ������)

    public void NextLevelButton()
    {
        // �ϳ��� �����־�� �����ϰ� ��
        // MainLoad.GetComponent<MainScript>().count
        if (GochiLoad.GetComponent<TutGochiScript>().FirstCount != 1)
        {
            if (GochiLoad.GetComponent<TutGochiScript>().count > 0)
            {
                if (NextImage == 1)
                {
                    NextImage = 2;
                    TestImage.sprite = Resources.Load<Sprite>("Quiz/" + NextImage) as Sprite;
                    QNum.text = "���� " + NextImage;
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
        else if () // Ʃ�丮��
        {
            TutPausePage.SetActive(true);
        }
    }
*/