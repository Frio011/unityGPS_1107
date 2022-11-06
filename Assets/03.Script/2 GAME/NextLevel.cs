using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{

    public GameObject MainLoad2;

    public string[] InputList = new string[4];
    private int score = 0;
    private int NextImage2 = 1; // 이미지 전환 번호
    public Image TestImage; // 이미지 전환
    private int a;
    public GameObject[] Tags;
    public Text ScoreText;
    public Text LScoreText;
    public GameObject EndPanel;
    public TrayScript tray;

    /*
    // 여기가 맞춰야 하는 값, 임시로 적어놓음
    public int RRc = 1; // 떡볶이
    public int RFc = 1; // 어묵
    public int RPa = 1; // 파전
    public int RKb = 1; // 김밥
    */
    private int correctNum2 = 0; // 몇번째 문제인지
    private string[][] Correct = { // 정답 레시피 저장할 2차원 배열, 다만 숫자로 저장할거임
        // 순서대로 ==> ({떡볶이, 어묵, 파전, 김밥})
        new string[]{"1", "0", "0", "0"},
        new string[]{"1", "0", "1", "0"},
        new string[]{"0", "3", "0", "0"},

        new string[]{"0", "0", "1", "1"},
        new string[]{"1", "2", "0", "1"},
        new string[]{"1", "0", "1", "2"},
        new string[]{"0", "2", "2", "0"},

        new string[]{"0", "2", "1", "1"},
        new string[]{"1", "0", "3", "0"},
        new string[]{"1", "2", "1", "1"}
    };
    private string[] RFPKtags = { "Fcake", "Kbob", "Pajun", "Rcake","FCB" };

    public void Change() // 버튼 클릭시 실행
    {

        InputList[0] = MainLoad2.GetComponent<TrayScript>().Rc.ToString();
        InputList[1] = MainLoad2.GetComponent<TrayScript>().Fc.ToString();
        InputList[2] = MainLoad2.GetComponent<TrayScript>().Pa.ToString();
        InputList[3] = MainLoad2.GetComponent<TrayScript>().Kb.ToString();

        // Debug.Log("InputList의 길이 : " + InputList.Length);
        // Debug.Log("correctNum2 : " + correctNum2);
        // Debug.Log("Correct[correctNum2]의 길이 : " + Correct[correctNum2].Length);

        if (NextImage2 < 10)
        {
            NextImage2 = NextImage2 + 1;
            TestImage.sprite = Resources.Load<Sprite>("FQuiz/" + NextImage2) as Sprite;
            score = score + 1; // 일단 점수 추가해둠

            if (Correct[correctNum2].Length == InputList.Length)
            {
                for (int i = 0; i < 4; i++)
                {
                    if (Correct[correctNum2][i] == InputList[i])
                    {
                        continue;
                    }
                    else
                    {
                        Debug.Log("정답과 입력이 일치하지 않습니다.");
                        score = score - 1; // 정답 아닐 시 추가해둔 점수 다시 뺌
                        break;
                    }
                }
            }
            correctNum2 = correctNum2 + 1; //문제 넘어감
            tray.countreset();



            // 화면상 오브젝트 전부 지움
            /*for (int i = 0; i < RFPKtags.Length; i++)
            {
                Tags = GameObject.FindGameObjectsWithTag(RFPKtags[i]);
                for (int j = 0; j < Tags.Length; j++)
                {
                    Destroy(Tags[j]);
                }
            }*/
            ScoreText.text = "맞힌 갯수 : " + score + " / 10";

            // 새로 생성
        }
        else
        {
            score = score + 1;
            if (Correct[correctNum2].Length == InputList.Length)
            {
                for (int i = 0; i < 4; i++)
                {
                    if (Correct[correctNum2][i] == InputList[i])
                    {
                        continue;
                    }
                    else
                    {
                        Debug.Log("정답과 입력이 일치하지 않습니다.");
                        score = score - 1; // 정답 아닐 시 추가해둔 점수 다시 뺌
                        break;
                    }
                }
            }
            Debug.Log("준비한 10 문제가 소진되었습니다.");
            Debug.Log("획득 점수 : " + score + "/10");
            EndPanelON();
            // 10이상 넘은경우 메인 화면으로 돌아감
        }
        // 화면상 오브젝트 전부 지움
        // 새로 생성
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

    public void Start()
    {
    }

}

