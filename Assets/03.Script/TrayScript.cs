using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrayScript : MonoBehaviour
{

    public int i = 0;
    public int Kb = 0; // ���
    public int Fc = 0; // �
    public int Rc = 0; // ������
    public int Pa = 0; // ����

    /*private void OnCollisionstay(Collision collision) // ������ �ö󰡸� ī��Ʈ +1
    {
        i = 1;

        if (collision.gameObject.tag == "Kbob")
        {
            Kb = Kb + i;
            //Debug.Log("��� ���� : " + Kb);
        }
        if (collision.gameObject.tag == "Fcake")
        {
            Fc = Fc + i;
            //Debug.Log("� ���� : " + Fc);
        }
        if (collision.gameObject.tag == "Rcake")
        {
            Rc = Rc + i;
            //Debug.Log("������ ���� : " + Rc);
        }
        if (collision.gameObject.tag == "Pajun")
        {
            Pa = Pa + i;
            //Debug.Log("���� ���� : " + Pa);
        }
    }

    private void OnCollisionExit(Collision collision) // �������� �������� ī��Ʈ -1
    {
        i = -1;

        if (collision.gameObject.tag == "Kbob")
        {
            Kb = Kb + i;
            //Debug.Log("��� ���� : " + Kb);
        }
        if (collision.gameObject.tag == "Fcake")
        {
            Fc = Fc + i;
            //Debug.Log("� ���� : " + Fc);
        }
        if (collision.gameObject.tag == "Rcake")
        {
            Rc = Rc + i;
            //Debug.Log("������ ���� : " + Rc);
        }
        if (collision.gameObject.tag == "Pajun")
        {
            Pa = Pa + i;
            //Debug.Log("���� ���� : " + Pa);
        }
    }*/
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
    }
    public void countreset()
    {
        Kb = 0;
        Fc = 0;
        Pa = 0;
        Rc = 0;
    }

}