using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseButton : MonoBehaviour
{
    public GameObject PausePanel;

    public void Pause_btn_clicked()
    {
        PausePanel.SetActive(true);
    }
    public void Yes_btn_clicked()
    {
        SceneManager.LoadScene("MainScene");
    }
    public void No_btn_clicked()
    {
        PausePanel.SetActive(false);
    }
}
