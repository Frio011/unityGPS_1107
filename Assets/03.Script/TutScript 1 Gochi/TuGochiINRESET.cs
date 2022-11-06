using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TuGochiINRESET : MonoBehaviour
{
    public GameObject GochiLoad;

    public void GochiInReset()
    {
        if (GochiLoad.GetComponent<TutGochiScript>().FirstCount != 1)
        {
            for (int i = 0; i < 25; i++)
            {
                GochiLoad.transform.GetChild(i).gameObject.SetActive(false);
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
