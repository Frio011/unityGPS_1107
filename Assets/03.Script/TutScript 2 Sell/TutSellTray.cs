using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutSellTray : MonoBehaviour // Ʈ���� �νĽ�ũ��Ʈ
{

    public int i = 0;
    public int Kb = 0; // ���
    public int Fc = 0; // �
    public int Rc = 0; // ������
    public int Pa = 0; // ����
    public int TutC = 0; // ���� ������
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
            //Debug.Log("��� ���� : " + Kb);
        }
        if (collider.gameObject.tag == "Fcake")
        {
            Fc = Fc + i;
            //Debug.Log("� ���� : " + Fc);
        }
        if (collider.gameObject.tag == "Rcake")
        {
            Rc = Rc + i;
            //Debug.Log("������ ���� : " + Rc);
        }
        if (collider.gameObject.tag == "Pajun")
        {
            Pa = Pa + i;
            //Debug.Log("���� ���� : " + Pa);
        }
        count = count + 1;
        if (TutC == 0)
        {
            Debug.Log("2) ���� ��ư�� ������ ���� �ֹ����� �Ѿ�ϴ�.");
            TutC = 1;
        }
    }
    private void OnTriggerExit(Collider other) // �������� �������� ī��Ʈ -1
    {
        i = -1;

        if (other.gameObject.tag == "Kbob")
        {
            Kb = Kb + i;
            //Debug.Log("��� ���� : " + Kb);
        }
        if (other.gameObject.tag == "Fcake")
        {
            Fc = Fc + i;
            //Debug.Log("� ���� : " + Fc);
        }
        if (other.gameObject.tag == "Rcake")
        {
            Rc = Rc + i;
            //Debug.Log("������ ���� : " + Rc);
        }
        if (other.gameObject.tag == "Pajun")
        {
            Pa = Pa + i;
            //Debug.Log("���� ���� : " + Pa);
        }
        count = count - 1;

    }
    
    private int iPlusMinus(int TagName, int j)
    {
        return TagName = TagName + j;
    }
    

    void Awake()
    {
        Debug.Log("1) ���⿡ ���ĵ��� �÷�������.");
    }

    void Update()
    {
        if (Circle1.activeSelf == true)
        {
            Debug.Log("Ȱ��ȭ");
        }

        if (Pa == 1 && Rc == 1)
        {
            if (TutC == 2)
            {
                Circle2.SetActive(false);
                Circle3.SetActive(true);
                Debug.Log("4) ���� ��ư�� �����ּ���.");
                TutC = 3;
            }
        }
        if(TutC == 3 && Pa != 1 && Rc != 1)
        {
            TutC = 2;
        }
    }
}
