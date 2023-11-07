using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameUI : MonoBehaviour
{
    [SerializeField] Text turnResultText;
    [SerializeField] GameObject effctText;
    [SerializeField] Text playerLifeText;
    [SerializeField] Text enemyLifeText;
    [SerializeField] GameObject resultPanel;
    [SerializeField] GameObject leavePanel;
    [SerializeField] GameObject retryButton;
    [SerializeField] Text resultText;
    [SerializeField] GameObject nextButton;
    [SerializeField] GameObject returnButton;
    [SerializeField] GameObject page1;
    [SerializeField] GameObject page2;
    //èüîsï\é¶

    public void InIt()
    {
        //turnResultText.gameObject.SetActive(false);
        //resultPanel.SetActive(false);
    }
    public void ShowLifes(float playerLife, float enemyLife)
    {
        playerLifeText.text = $"{playerLife}";
        enemyLifeText.text = $"{enemyLife}";
    }
    public void ShowTurnResult(string result)
    {
        turnResultText.gameObject.SetActive(true);
        turnResultText.text = result;
        Debug.Log(result);
    }

    public void ShowGameResult(string result)
    {
       
        resultPanel.SetActive(true);
        resultText.text = result;
    }

    public void ShowEffct()
    {
        effctText.gameObject.SetActive(true);
        returnButton.gameObject.SetActive(false);
        page1.gameObject.SetActive(true);
        page2.gameObject.SetActive(false);
    }
    public void CloseEffect()
    {
        effctText.gameObject.SetActive(false);
        returnButton.gameObject.SetActive(false);
        page2.gameObject.SetActive(false);
    }
    public void ShowLeavePanel()
    {
        leavePanel.SetActive(true);
    }

    public void NextPanel()
    {
        nextButton.gameObject.SetActive(false);
        returnButton.gameObject.SetActive(true);
        page1.gameObject.SetActive(false);
        page2.gameObject.SetActive(true);
    }

    public void ReturnPanel()
    {
        nextButton.gameObject.SetActive(true);
        returnButton.gameObject.SetActive(false);
        page1.gameObject.SetActive(true);
        page2.gameObject.SetActive(false);
    }
}
