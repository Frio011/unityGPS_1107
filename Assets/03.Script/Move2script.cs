using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move2script : MonoBehaviour
{
    public void OnTriggerEnter(Collider collider)
    {
        Debug.Log("�浹����");
        if (collider.gameObject.GetComponent<MoveGuestscript>().Move == 3)
        {
            Debug.Log("Move 3 Ȯ�� �Ϸ�");
            if (collider.gameObject.name == "Guest")
            {
                Debug.Log("collider.gameObject ����");
                Destroy(collider.gameObject, 1);
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
        
    }
}
