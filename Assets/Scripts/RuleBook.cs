using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RuleBook : MonoBehaviour
{

    [SerializeField] Battler player;
    [SerializeField] Battler enemy;
    [SerializeField] GameUI gameUI;
    //以下ゲームルールの根幹
    /*public float NumberBattleSurpass(Battler playerCard, Battler enemyCard)
    {
        float surpass = WeekBattle(playerCard, enemyCard);
        return surpass;
    }*/
    //ここまで

    /*float WeekBattle(Battler playerCard, Battler enemyCard)
    {

        if (playerCard.SubmitCard.Base.Type == CardType.Fire && enemyCard.SubmitCard.Base.Type == CardType.Ice)
        {
            float surpass = WeekPoint(playerCard, enemyCard, 1.25f, 1f);
            gameUI.ShowTurnResult("弱点だった！");
            return surpass;
        }
        if (playerCard.SubmitCard.Base.Type == CardType.Ice && enemyCard.SubmitCard.Base.Type == CardType.Fire)
        {
            float surpass = WeekPoint(playerCard, enemyCard, 1f, 1.25f);
            gameUI.ShowTurnResult("弱点だった！");
            return surpass;
        }
        if (playerCard.SubmitCard.Base.Type == CardType.Ice && enemyCard.SubmitCard.Base.Type == CardType.Thunder)
        {
            float surpass = WeekPoint(playerCard, enemyCard, 1.25f, 1f);
            gameUI.ShowTurnResult("弱点だった！");
            return surpass;
        }
        if (playerCard.SubmitCard.Base.Type == CardType.Thunder && enemyCard.SubmitCard.Base.Type == CardType.Ice)
        {
            float surpass = WeekPoint(playerCard, enemyCard, 1f, 1.25f);
            gameUI.ShowTurnResult("弱点だった！");
            return surpass;
        }
        if (playerCard.SubmitCard.Base.Type == CardType.Thunder && enemyCard.SubmitCard.Base.Type == CardType.Fire)
        {
            float surpass = WeekPoint(playerCard, enemyCard, 1.25f, 1f);
            gameUI.ShowTurnResult("弱点だった！");
            return surpass;
        }
        if (playerCard.SubmitCard.Base.Type == CardType.Fire && enemyCard.SubmitCard.Base.Type == CardType.Thunder)
        {
            float surpass = WeekPoint(playerCard, enemyCard, 1f, 1.25f);
            gameUI.ShowTurnResult("弱点だった！");
            return surpass;
        }

        float surpassDraw = WeekPoint(playerCard, enemyCard, 1.0f, 1.0f);

        return surpassDraw;
    }*/


    /*float WeekPoint(Battler playerCard, Battler enemyCard, float playerPower, float enemyPower)
    {

        Debug.Log($"{playerPower} {enemyPower}");
        if (playerCard.SubmitCard.Base.Power * playerPower > enemyCard.SubmitCard.Base.Power * enemyPower)
        {
            Debug.Log("win");
            Debug.Log("P" + playerCard.SubmitCard.Base.Power * playerPower);
            Debug.Log("E" + enemyCard.SubmitCard.Base.Power * enemyPower);
            float surpass = enemyCard.SubmitCard.Base.Power * enemyPower - playerCard.SubmitCard.Base.Power * playerPower;
            surpass = -surpass;
            Debug.Log(surpass);
            return surpass;
        }
        else if (playerCard.SubmitCard.Base.Power * playerPower < enemyCard.SubmitCard.Base.Power * enemyPower)
        {
            Debug.Log("lose");
            Debug.Log("P" + playerCard.SubmitCard.Base.Power * playerPower);
            Debug.Log("E" + enemyCard.SubmitCard.Base.Power * enemyPower);
            float surpass = playerCard.SubmitCard.Base.Power * playerPower - enemyCard.SubmitCard.Base.Power * enemyPower;
            Debug.Log(surpass);
            return surpass;
        }
        return 0;
    }*/
}
