using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardGeneretter : MonoBehaviour
{
    [SerializeField] CardBase[] cardBases;
    [SerializeField] Card cardPrefab;


    public Card Spawn(int number)
    {
        Card card = Instantiate(cardPrefab);
        card.Set(cardBases[number]);
        return card;
    }
}
