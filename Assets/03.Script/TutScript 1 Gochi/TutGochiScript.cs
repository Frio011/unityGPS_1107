using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutGochiScript : MonoBehaviour
{
    public int count = 0; // �� ������Ʈ ���� ������ �ѱ�� ���� �Լ�

    private string testName;
    public Transform testcube;
    public Vector3 pos;
    public bool BoolTorF = false;
    public int FirstCount = 0;

    public string[] InputList = new string[3];
    public string InputTag; // �浹�� �±� �����ص�

    public GameObject Tut1;
    public GameObject Tut2;
    public GameObject Tut3;
    public GameObject Tut4;

    public void OnCollisionEnter(Collision collision)
    {
        if (count < 3) // 5������ �ִ�� ����, �� �̻��� �ȵ�
        {
            if (collision.gameObject.tag == "Ham" || collision.gameObject.tag == "Gesal" || collision.gameObject.tag == "Mush" || collision.gameObject.tag == "Papric" || collision.gameObject.tag == "pa")
            {
                InputTag = collision.gameObject.tag; // �浹�� ������Ʈ �±װ��� ����
                InputList[count] = InputTag;
                count = count + 1; // �������� �Ѿ �� �ְ� ��

                testcube.transform.Find("T" + collision.gameObject.tag + count.ToString()).gameObject.SetActive(true);

                pos = GameObject.Find("PosEmpty").transform.position;
                collision.gameObject.transform.position = pos;

                Destroy(collision.gameObject, 3);  // �浹�� ���� ������Ʈ ����
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
                // 2) �ʱ�ȭ ��ư�� ������ ����� ���� ��ġ�� ������, ���ο� ��ġ�� ���� �� �ֽ��ϴ�
                Debug.Log("1) �ʱ�ȭ ��ư�� ������ ����� ���� ��ġ�� ������, ���ο� ��ġ�� ���� �� �ֽ��ϴ�");
            }
        }
        if (count == 3)
        {
            if (FirstCount == 2)
            {
                if (InputList[0] == "Ham" && InputList[1] == "Ham" && InputList[2] == "Ham")
                {
                    // 4) ��ġ�� �ϼ������� ���� ��ư�� ������. ���� ��ġ�� ���� �� �־��.
                    Debug.Log("4) ��ġ�� �ϼ������� ���� ��ư�� ������. ���� ��ġ�� ���� �� �־��.");
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
                Debug.Log(" 3) �̹����� �ֹ��� ���� �˸��� ��ġ�� �������? �� - �� - ���� �Ⱦƺ��ô�.");
            }
        }
    }
}
