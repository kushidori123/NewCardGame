using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class CardBase : ScriptableObject
{
    [SerializeField] int cardNumber;
    [SerializeField] int cost; //カードのコスト
    [SerializeField] CardType type;//カードタイプ　
    [SerializeField] CardName kinds;// カードの名前
    [SerializeField] string description;//カードの能力説明
    [SerializeField] Sprite icon;//カードのイメージ
    [SerializeField] new string name;//カードの名前

    public int Cost { get => cost; }
    public CardType Type { get => type; }
    public CardName Kinds { get => kinds; }
    public string Description { get => description; }
    public Sprite Icon { get => icon; }
    public string Name { get => name; }
    public int CardNumber { get => cardNumber;}
}

public enum CardType
{
    Holy,
    Darkness,
    Fire,
    Ice,
    Thunder,
}

public enum CardName
{
    DragonRage,
    DarkFog,
    FireBlaze,
    IceStorm,
    ThunderBreaker,
    InfernoByte,
    AbissWitch,
    NovaSkull


}
