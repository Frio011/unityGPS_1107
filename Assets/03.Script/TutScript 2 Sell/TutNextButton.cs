using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class TutNextButton : MonoBehaviour // ���� ��ư
{
    public GameObject TutSellTray;
    private int NextImage2 = 1; // �̹��� ��ȯ ��ȣ
    public Image TestImage; // �̹��� ��ȯ
    public Text QNum;
    public GameObject NextGamePage;

    public void NextLevelButton2()
    {
        // �ϳ��� �����־�� �����ϰ� ��
        // MainLoad.GetComponent<MainScript>().count
        if (TutSellTray.GetComponent<TutSellTray>().count > 0)
        {
            if (TutSellTray.GetComponent<TutSellTray>().TutC == 1)
            {
                NextImage2 = 2;
                TestImage.sprite = Resources.Load<Sprite>("FQuiz/" + NextImage2) as Sprite;
                QNum.text = "���� " + NextImage2;

                TutSellTray.GetComponent<TutSellTray>().Circle1.SetActive(false);
                TutSellTray.GetComponent<TutSellTray>().Circle2.SetActive(true);
                Debug.Log("3) �̹����� �ֹ���� �����̿� ������ �ϳ��� �÷����ô�.");
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
