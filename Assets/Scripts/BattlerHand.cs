using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattlerHand : MonoBehaviour
{
    public List<Card> list = new List<Card>();
    //list‚É’Ç‰Á‚µ‚ÄŽ©•ª‚ÌŽq—v‘f‚É‚·‚é
    public void Add(Card card)
    {
        list.Add(card);
        card.transform.SetParent(transform);
    }
    public void Remove(Card card)
    {
        list.Remove(card);
    }
    public void ResetPosition()
    {
        //Number‚Ì¬‚³‚¢‡‚É‚È‚ç‚×‚é
        list.Sort((card0, card1) => card0.Base.Cost - card1.Base.Cost);
        for (int i = 0; i < list.Count; i++)
        {
            float posX = (i - list.Count / 2f) * 20f;
            list[i].transform.localPosition = new Vector3(posX, 0);
        }
    }
    public Card RandomRemove()
    {
        int r = Random.Range(0, list.Count);
        Card card = list[r];
        Remove(card);
        return card;
    }
    public Card Remove(int number)
    {

        Card card = list.Find(x => x.Base.CardNumber == number);
        Remove(card);
        return card;


    }
}
