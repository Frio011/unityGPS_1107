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
    private int NextImage2 = 1; // �̹��� ��ȯ ��ȣ
    public Image TestImage; // �̹��� ��ȯ
    private int a;
    public GameObject[] Tags;
    public Text ScoreText;
    public Text LScoreText;
    public GameObject EndPanel;
    public TrayScript tray;

    /*
    // ���Ⱑ ����� �ϴ� ��, �ӽ÷� �������
    public int RRc = 1; // ������
    public int RFc = 1; // �
    public int RPa = 1; // ����
    public int RKb = 1; // ���
    */
    private int correctNum2 = 0; // ���° ��������
    private string[][] Correct = { // ���� ������ ������ 2���� �迭, �ٸ� ���ڷ� �����Ұ���
        // ������� ==> ({������, �, ����, ���})
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

    public void Change() // ��ư Ŭ���� ����
    {

        InputList[0] = MainLoad2.GetComponent<TrayScript>().Rc.ToString();
        InputList[1] = MainLoad2.GetComponent<TrayScript>().Fc.ToString();
        InputList[2] = MainLoad2.GetComponent<TrayScript>().Pa.ToString();
        InputList[3] = MainLoad2.GetComponent<TrayScript>().Kb.ToString();

        // Debug.Log("InputList�� ���� : " + InputList.Length);
        // Debug.Log("correctNum2 : " + correctNum2);
        // Debug.Log("Correct[correctNum2]�� ���� : " + Correct[correctNum2].Length);

        if (NextImage2 < 10)
        {
            NextImage2 = NextImage2 + 1;
            TestImage.sprite = Resources.Load<Sprite>("FQuiz/" + NextImage2) as Sprite;
            score = score + 1; // �ϴ� ���� �߰��ص�

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
                        Debug.Log("����� �Է��� ��ġ���� �ʽ��ϴ�.");
                        score = score - 1; // ���� �ƴ� �� �߰��ص� ���� �ٽ� ��
                        break;
                    }
                }
            }
            correctNum2 = correctNum2 + 1; //���� �Ѿ
            tray.countreset();



            // ȭ��� ������Ʈ ���� ����
            /*for (int i = 0; i < RFPKtags.Length; i++)
            {
                Tags = GameObject.FindGameObjectsWithTag(RFPKtags[i]);
                for (int j = 0; j < Tags.Length; j++)
                {
                    Destroy(Tags[j]);
                }
            }*/
            ScoreText.text = "���� ���� : " + score + " / 10";

            // ���� ����
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
                        Debug.Log("����� �Է��� ��ġ���� �ʽ��ϴ�.");
                        score = score - 1; // ���� �ƴ� �� �߰��ص� ���� �ٽ� ��
                        break;
                    }
                }
            }
            Debug.Log("�غ��� 10 ������ �����Ǿ����ϴ�.");
            Debug.Log("ȹ�� ���� : " + score + "/10");
            EndPanelON();
            // 10�̻� ������� ���� ȭ������ ���ư�
        }
        // ȭ��� ������Ʈ ���� ����
        // ���� ����
    }
    public void EndPanelON()
    {
        EndPanel.SetActive(true);
        LScoreText.text = "���� ���� : " + score + " / 10";
    }
    public void Yes_btn_clicked()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void Start()
    {
    }

}

