using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class CardBase : ScriptableObject
{
    [SerializeField] int cardNumber;
    [SerializeField] int cost; //�J�[�h�̃R�X�g
    [SerializeField] CardType type;//�J�[�h�^�C�v�@
    [SerializeField] CardName kinds;// �J�[�h�̖��O
    [SerializeField] string description;//�J�[�h�̔\�͐���
    [SerializeField] Sprite icon;//�J�[�h�̃C���[�W
    [SerializeField] new string name;//�J�[�h�̖��O

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
