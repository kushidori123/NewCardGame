using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Battler : MonoBehaviour
{
    [SerializeField] BattlerHand hand;
    [SerializeField] SubmitPosition submitPosition;
    public bool IsSubmitted { get; private set; }
    public UnityAction OnSubmitAction;

    public BattlerHand Hand { get => hand; }
    public Card SubmitCard { get => submitPosition.SubmitCard; }
    public float Life { get; set; }

    public void SetCardToHand(Card card)
    {
        hand.Add(card);
        card.OnClickCard = SelectedCard;
    }
    void SelectedCard(Card card)
    {
        if (IsSubmitted)
        {
            return;
        }
        // すでにセットしていれば、手札にもどす
        if (submitPosition.SubmitCard)
        {
            hand.Add(submitPosition.SubmitCard);
        }
        hand.Remove(card);
        submitPosition.Set(card);
        hand.ResetPosition();
        Debug.Log("通過");
    }

    public void OnSubmitButton()
    {
        if (submitPosition.SubmitCard)
        {
            IsSubmitted = true;
            //カードの決定
            //ゲームマスターに通知
            OnSubmitAction?.Invoke();
        }

    }
    public void RandomSubmit()
    {
        //手札からランダムでカードを抜き取
        Card card = hand.RandomRemove();
        //提出用にセット
        submitPosition.Set(card);
        //提出ゲームマスターに
        IsSubmitted = true;
        OnSubmitAction?.Invoke();
        hand.ResetPosition();
    }
    public void SetSubmitCard(int number)
    {

        Card card = hand.Remove(number);

        submitPosition.Set(card);

        IsSubmitted = true;
        OnSubmitAction?.Invoke();
        hand.ResetPosition();
    }

    public void SetupNextTurn()
    {
        IsSubmitted = false;
        submitPosition.DeleteCard();
    }
}
