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
        // ���łɃZ�b�g���Ă���΁A��D�ɂ��ǂ�
        if (submitPosition.SubmitCard)
        {
            hand.Add(submitPosition.SubmitCard);
        }
        hand.Remove(card);
        submitPosition.Set(card);
        hand.ResetPosition();
        Debug.Log("�ʉ�");
    }

    public void OnSubmitButton()
    {
        if (submitPosition.SubmitCard)
        {
            IsSubmitted = true;
            //�J�[�h�̌���
            //�Q�[���}�X�^�[�ɒʒm
            OnSubmitAction?.Invoke();
        }

    }
    public void RandomSubmit()
    {
        //��D���烉���_���ŃJ�[�h�𔲂���
        Card card = hand.RandomRemove();
        //��o�p�ɃZ�b�g
        submitPosition.Set(card);
        //��o�Q�[���}�X�^�[��
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
