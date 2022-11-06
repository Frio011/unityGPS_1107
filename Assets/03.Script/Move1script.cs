using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move1script : MonoBehaviour
{
    public void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "NPC")
        {
            if (collider.gameObject.GetComponent<MoveGuestscript>().TorF == true)
            {
                collider.gameObject.GetComponent<MoveGuestscript>().Move = 2;
                collider.gameObject.GetComponent<MoveGuestscript>().TorF = false;
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
