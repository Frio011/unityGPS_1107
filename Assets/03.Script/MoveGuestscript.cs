using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveGuestscript : MonoBehaviour
{
    public int Move = 1;
    // move 1 > a∑Œ ¿Ãµø
    // move 2 > ∏ÿ√„
    // move 3 > b∑Œ ¿Ãµø
    public bool TorF = true;

    public void MOVEButton()
    {
        Move = 3;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Move == 1)
        {
            transform.position = Vector3.MoveTowards(transform.position, GameObject.Find("Move1").transform.position, 0.03f);
        }
        if (Move == 3)
        {
            transform.position = Vector3.MoveTowards(transform.position, GameObject.Find("Move2").transform.position, 0.03f);
        }
    }
}
