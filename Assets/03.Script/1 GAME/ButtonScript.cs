using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    public AudioClip audio0;
    public AudioClip audio1;
    private AudioSource audioSource;

    private int score = 0;
    public int NextImage = 1; // 이미지 전환 번호
    public Image TestImage; // 이미지 전환
    private int a;
    //public GameObject SNText;
    public Text QNum;
    public Text ScoreText;
    public Text LScoreText;
    public GameObject EndPanel;
    public int LastQ = 0;

    public GameObject Image0;
    public GameObject Image1;
    public float GameTime = 0;
    public float ButtonTime = 0;
    public bool UpdateTimeTorF = false;

    private int correctNum = 0; // 몇번째 문제인지
    private string[][] Correct = { // 정답 레시피 저장할 2차원 배열
        new string[]{"Ham", "Ham", "Ham"},
        new string[]{"Gesal", "Gesal", "Ham"},
        new string[]{"Mush", "pa", "Papric"},

        new string[]{"Ham", "pa", "Ham", "pa"},
        new string[]{"Gesal", "pa", "Ham", "Gesal"},
        new string[]{"Papric", "Ham", "Gesal", "pa"},
        new string[]{"Mush", "Ham", "Ham", "Papric"},

        new string[]{"Mush", "Mush", "Gesal", "Gesal", "pa"},
        new string[]{"Papric", "Papric", "Ham", "Ham", "pa"},
        new string[]{"Mush", "Papric", "Ham", "Gesal", "pa"}
    };

    public GameObject MainLoad;

    public void ChangeImage()
    {
        // Debug.Log(a = MainLoad.GetComponent<MainScript>().count);
        Image0.SetActive(false);
        Image1.SetActive(false);

        ButtonTime = GameTime;
        UpdateTimeTorF = true;

        if (NextImage < 10)
        {
            NextImage = NextImage + 1;
            TestImage.sprite = Resources.Load<Sprite>("Quiz/" + NextImage) as Sprite;

            if (MainLoad.GetComponent<MainScript>().count == Correct[correctNum].Length)
            {
                score = score + 1;
                for (int i = 0; i < MainLoad.GetComponent<MainScript>().count; i++)
                {
                    if (Correct[correctNum][i] == MainLoad.GetComponent<MainScript>().InputList[i])
                    {
                        continue;
                    }
                    else
                    {
                        audioSource.PlayOneShot(audio0);
                        Image0.SetActive(true);
                        // OX 표시
                        Debug.Log("정답과 입력이 일치하지 않습니다. 정답 : " + Correct[correctNum][i]);
                        score = score - 1;
                        correctNum = correctNum + 1;
                        break;
                    }
                }
                audioSource.PlayOneShot(audio1);
                Image1.SetActive(true);
                // OX 표시
                Debug.Log("정답.");
            }
            else
            {
                audioSource.PlayOneShot(audio0);
                Image0.SetActive(true);
                // OX 표시
                Debug.Log("정답과 입력이 일치하지 않습니다.");
            }
            for (int i = 0; i < MainLoad.GetComponent<MainScript>().count; i++)
            {
                int j = i + 1;
                // MainLoad.GetComponent<MainScript>().InputList[i] + j
                GameObject.Find("Cube").transform.Find("T"+ MainLoad.GetComponent<MainScript>().InputList[i] + j).gameObject.SetActive(false);
            }
            MainLoad.GetComponent<MainScript>().count = 0;
            correctNum = correctNum + 1;
            QNum.text = "문제 " + NextImage;
            ScoreText.text = "맞힌 갯수: " + score + " / 10";
            //Debug.Log(score);
        }
        else
        {
            LastQ = 1;
            if (MainLoad.GetComponent<MainScript>().count == Correct[correctNum].Length)
            {
                score = score + 1;
                for (int i = 0; i < MainLoad.GetComponent<MainScript>().count; i++)
                {
                    if (Correct[correctNum][i] == MainLoad.GetComponent<MainScript>().InputList[i])
                    {
                        continue;
                    }
                    else
                    {
                        audioSource.PlayOneShot(audio0);
                        Image0.SetActive(true);
                        // OX 표시
                        Debug.Log("정답과 입력이 일치하지 않습니다. 정답 : " + Correct[correctNum][i]);
                        score = score - 1;
                        correctNum = correctNum + 1;
                        break;
                    }
                }

                Debug.Log("정답.");
                audioSource.PlayOneShot(audio1);
                Image1.SetActive(true);
                // OX 표시
            }
            else
            {
                audioSource.PlayOneShot(audio0);
                Image0.SetActive(true);
                // OX 표시
                Debug.Log("정답과 입력이 일치하지 않습니다.");
            }
            for (int i = 0; i < MainLoad.GetComponent<MainScript>().count; i++)
            {
                int j = i + 1;
                // MainLoad.GetComponent<MainScript>().InputList[i] + j
                GameObject.Find("Cube").transform.Find("T" + MainLoad.GetComponent<MainScript>().InputList[i] + j).gameObject.SetActive(false);
            }
            MainLoad.GetComponent<MainScript>().count = 0;
            

            Debug.Log("준비한 10 문제가 소진되었습니다.");
            // 10이상 넘은경우 메인 화면으로 돌아감
            EndPanelON();
        }
    }

    public void resetGochi()
    {
        for (int i = 0; i < MainLoad.GetComponent<MainScript>().count; i++)
        {
            int j = i + 1;
            // MainLoad.GetComponent<MainScript>().InputList[i] + j
            GameObject.Find("Cube").transform.Find("T" + MainLoad.GetComponent<MainScript>().InputList[i] + j).gameObject.SetActive(false);
        }
        MainLoad.GetComponent<MainScript>().count = 0;
    }

    public void EndPanelON()
    {
        EndPanel.SetActive(true);
        LScoreText.text = "최종 점수 : " + score + " / 10";
    }
    public void Yes_btn_clicked()
    {
        SceneManager.LoadScene("MainScene");
    }

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        //SNScore = SNText.GetComponent<Text>();
    }

    void Update()
    {
        if (UpdateTimeTorF == true)
        {
            if (GameTime - ButtonTime > 5)
            {
                Image0.SetActive(false);
                Image1.SetActive(false);
                UpdateTimeTorF = false;
            }
        }
        GameTime += Time.deltaTime;
    }
}
