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
    

    
    //�J�[�h�𐶐����Ĕz��
    private void Awake()
    {
        ruleBook = GetComponent<RuleBook>();

    }

    [System.Obsolete]
    private void Start()
    {

        //SoundManager.Instance.PlayBGM(BGMSoundData.BGM.Battle);
        Setup();

        // StartCoroutine(SpeakTest("����ɂ��́I", voice));
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
            //�J�[�h�̃o�g����������
            StartCoroutine(CardBattle());
        }

        else if (player.IsSubmitted)
        {
            
            submitButton.SetActive(false);
            //�G�l�~�[����J�[�h���o��

        }
        else if (enemy.IsSubmitted)
        {
            //�v���C���[�̒�o��҂�
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

    //�J�[�h�̏�������
    [System.Obsolete]
    IEnumerator CardBattle()
    {

        yield return new WaitForSeconds(1f);
        enemy.SubmitCard.Open();
        yield return new WaitForSeconds(1f);
        gameUI.ShowLifes(player.Life, enemy.Life);


        //�ȉ��@�C���̕K�v����
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
            gameUI.ShowTurnResult(surpass + "�_���[�W");
            SoundManager.Instance.PlaySE(SESoundData.SE.Atk);
            enemy.Life -= surpass;
        }
        else if (surpass < 0)
        {

            surpass = -surpass;
            gameUI.ShowTurnResult("LOSE");
            yield return new WaitForSeconds(2f);
            gameUI.ShowTurnResult(surpass + "�_���[�W");
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
        //�J�[�h�̖������O�ɂȂ�������{����

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
