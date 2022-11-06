using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrayScript : MonoBehaviour
{

    public int i = 0;
    public int Kb = 0; // ±è¹ä
    public int Fc = 0; // ¾î¹¬
    public int Rc = 0; // ¶±ººÀÌ
    public int Pa = 0; // ÆÄÀü

    /*private void OnCollisionstay(Collision collision) // µµ¸¶¿¡ ¿Ã¶ó°¡¸é Ä«¿îÆ® +1
    {
        i = 1;

        if (collision.gameObject.tag == "Kbob")
        {
            Kb = Kb + i;
            //Debug.Log("±è¹ä °¹¼ö : " + Kb);
        }
        if (collision.gameObject.tag == "Fcake")
        {
            Fc = Fc + i;
            //Debug.Log("¾î¹¬ °¹¼ö : " + Fc);
        }
        if (collision.gameObject.tag == "Rcake")
        {
            Rc = Rc + i;
            //Debug.Log("¶±ººÀÌ °¹¼ö : " + Rc);
        }
        if (collision.gameObject.tag == "Pajun")
        {
            Pa = Pa + i;
            //Debug.Log("ÆÄÀü °¹¼ö : " + Pa);
        }
    }

    private void OnCollisionExit(Collision collision) // µµ¸¶¿¡¼­ ³»·Á°¡¸é Ä«¿îÆ® -1
    {
        i = -1;

        if (collision.gameObject.tag == "Kbob")
        {
            Kb = Kb + i;
            //Debug.Log("±è¹ä °¹¼ö : " + Kb);
        }
        if (collision.gameObject.tag == "Fcake")
        {
            Fc = Fc + i;
            //Debug.Log("¾î¹¬ °¹¼ö : " + Fc);
        }
        if (collision.gameObject.tag == "Rcake")
        {
            Rc = Rc + i;
            //Debug.Log("¶±ººÀÌ °¹¼ö : " + Rc);
        }
        if (collision.gameObject.tag == "Pajun")
        {
            Pa = Pa + i;
            //Debug.Log("ÆÄÀü °¹¼ö : " + Pa);
        }
    }*/
    private void OnTriggerEnter(Collider collider)
    {
        i = 1;

        if (collider.gameObject.tag == "Kbob")
        {
            Kb = Kb + i;
            //Debug.Log("±è¹ä °¹¼ö : " + Kb);
        }
        if (collider.gameObject.tag == "Fcake")
        {
            Fc = Fc + i;
            //Debug.Log("¾î¹¬ °¹¼ö : " + Fc);
        }
        if (collider.gameObject.tag == "Rcake")
        {
            Rc = Rc + i;
            //Debug.Log("¶±ººÀÌ °¹¼ö : " + Rc);
        }
        if (collider.gameObject.tag == "Pajun")
        {
            Pa = Pa + i;
            //Debug.Log("ÆÄÀü °¹¼ö : " + Pa);
        }
    }
    private void OnTriggerExit(Collider other) // µµ¸¶¿¡¼­ ³»·Á°¡¸é Ä«¿îÆ® -1
    {
        i = -1;

        if (other.gameObject.tag == "Kbob")
        {
            Kb = Kb + i;
            //Debug.Log("±è¹ä °¹¼ö : " + Kb);
        }
        if (other.gameObject.tag == "Fcake")
        {
            Fc = Fc + i;
            //Debug.Log("¾î¹¬ °¹¼ö : " + Fc);
        }
        if (other.gameObject.tag == "Rcake")
        {
            Rc = Rc + i;
            //Debug.Log("¶±ººÀÌ °¹¼ö : " + Rc);
        }
        if (other.gameObject.tag == "Pajun")
        {
            Pa = Pa + i;
            //Debug.Log("ÆÄÀü °¹¼ö : " + Pa);
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