using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMaster : MonoBehaviour
{
    [SerializeField] Battler player;
    [SerializeField] Battler enemy;
    [SerializeField] CardGeneretter cardGeneretter;
    [SerializeField] GameObject submitButton;
    [SerializeField] GameUI gameUI;
   
    [SerializeField] private int Pl;
    [SerializeField] private int El;
    RuleBook ruleBook;
    

    
    //カードを生成して配る
    private void Awake()
    {
        ruleBook = GetComponent<RuleBook>();

    }

    [System.Obsolete]
    private void Start()
    {

        //SoundManager.Instance.PlayBGM(BGMSoundData.BGM.Battle);
        Setup();

        // StartCoroutine(SpeakTest("こんにちは！", voice));
    }

    [System.Obsolete]
    private void Setup()
    {
        //gameUI.InIt();
        //player.Life = Pl;
        //enemy.Life = El;
        //player.OnSubmitAction = SubmittedAction;
        //enemy.OnSubmitAction = SubmittedAction;
        SendCardTo(battler: player);
        //SendCardTo(battler: enemy);
        //gameUI.ShowLifes(player.Life, enemy.Life);
        

    }

    [System.Obsolete]
    void SubmittedAction()
    {
        if (player.IsSubmitted && enemy.IsSubmitted)
        {
            submitButton.SetActive(false);
            //カードのバトル勝利判定
            StartCoroutine(CardBattle());
        }

        else if (player.IsSubmitted)
        {
            
            submitButton.SetActive(false);
            //エネミーからカードを出す

        }
        else if (enemy.IsSubmitted)
        {
            //プレイヤーの提出を待つ
        }

    }

    void SendCardTo(Battler battler)
    {
        //Card card = cardGeneretter.Spawn(0);
        //battler.Hand.Add(card);
        //battler.SetCardToHand(card);


        for (int i = 0; i < 3; i++)
        {
            Card card = cardGeneretter.Spawn(i);
            battler.Hand.Add(card);
            battler.SetCardToHand(card);
        }
        battler.Hand.ResetPosition();
    }

    //カードの勝利判定
    [System.Obsolete]
    IEnumerator CardBattle()
    {

        yield return new WaitForSeconds(1f);
        enemy.SubmitCard.Open();
        yield return new WaitForSeconds(1f);
        gameUI.ShowLifes(player.Life, enemy.Life);


        //以下　修正の必要あり
        /* Result result = ruleBook.GetResult(player,enemy,3,1);

         switch (result)
         { 
             case Result.TurnWin:


                 break;
             case Result.TurnLose:



                 break;
             case Result.TurnDraw:
                 gameUI.ShowTurnResult("DRAW");


                 break;

         }*/
        //float surpass = ruleBook.NumberBattleSurpass(player, enemy);
        /*Debug.Log(surpass);
        if (surpass > 0)
        {
            gameUI.ShowTurnResult("WIN");
            yield return new WaitForSeconds(2f);
            gameUI.ShowTurnResult(surpass + "ダメージ");
            SoundManager.Instance.PlaySE(SESoundData.SE.Atk);
            enemy.Life -= surpass;
        }
        else if (surpass < 0)
        {

            surpass = -surpass;
            gameUI.ShowTurnResult("LOSE");
            yield return new WaitForSeconds(2f);
            gameUI.ShowTurnResult(surpass + "ダメージ");
            SoundManager.Instance.PlaySE(SESoundData.SE.Dmg);
            player.Life -= surpass;
        }
        else if (surpass == 0)
        {
            gameUI.ShowTurnResult("DRAW");
        }
        gameUI.ShowLifes(player.Life, enemy.Life);

        yield return new WaitForSeconds(2f);
        gameUI.ShowTurnResult(null);
        //カードの枚数も０になったら実施する

        if (player.Life <= 0 || enemy.Life <= 0)
        {
            //GameOver
            ShowResult();
        }
        else
        {
            SetupNextTurnGame();
        }*/

    }

    [Obsolete]
    void ShowResult()
    {

        if (player.Life >= 0 && enemy.Life <= 0)
        {
            enemy.Life = 0;
            gameUI.ShowLifes(player.Life, enemy.Life);
            gameUI.ShowGameResult("WIN");
            SoundManager.Instance.PlaySE(SESoundData.SE.Win);

        }
        else if (player.Life <= 0 && enemy.Life >= 0)
        {
            player.Life = 0;
            gameUI.ShowLifes(player.Life, enemy.Life);
            gameUI.ShowGameResult("LOSE");
            SoundManager.Instance.PlaySE(SESoundData.SE.Lose);
        }
        else if (player.Life >= 0 && enemy.Life >= 0)
        {
            gameUI.ShowGameResult("DRAW");
        }

    }

    void SetupNextTurnGame()
    {
        player.SetupNextTurn();
        enemy.SetupNextTurn();
        submitButton.SetActive(true);

    }

    [System.Obsolete]
    
    public void OnRetryButton()
    {
        string currentScen = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(currentScen);
    }
    public void OnTitleButton()
    {

       
        SceneManager.LoadScene("Title");
    }

   

    

   
}
