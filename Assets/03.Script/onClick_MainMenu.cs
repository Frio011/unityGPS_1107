using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class onClick_MainMenu : MonoBehaviour
{
    public GameObject optionPanel;
    public GameObject exitPanel;
    public GameObject mainPanel;

    public void exit_btn_clicked()
    {
        mainPanel.SetActive(false);
        exitPanel.SetActive(true);
    }
    public void exit_back_btn_clicked()
    {
        exitPanel.SetActive(false);
        mainPanel.SetActive(true);
    }
    public void option_btn_clicked()
    {
        mainPanel.SetActive(false);
        optionPanel.SetActive(true);
    }
    public void option_back_btn_clicked()
    {
        optionPanel.SetActive(false);
        mainPanel.SetActive(true);
    }
    public void making_btn_clicked()
    {
        SceneManager.LoadScene("newSceneStick");
    }
    public void sell_btn_clicked()
    {
        SceneManager.LoadScene("newSceneSell");
    }
    public void style_btn_clicked()
    {
        SceneManager.LoadScene("StyleGameScene");
    }
}
