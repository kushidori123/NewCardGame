using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Card : MonoBehaviour
{

    [SerializeField] Text costText;
    [SerializeField] Text descriptionText;
    [SerializeField] Image icon;
    [SerializeField] Text nameText;
    [SerializeField] GameObject hidePanel;
    public CardBase Base { get; set; }
    //関数を登録できる
    public UnityAction<Card> OnClickCard;
    public void Set(CardBase cardBase)
    {
        Base = cardBase;
        costText.text = $"コスト：{cardBase.Cost}";
        descriptionText.text = cardBase.Description;
        icon.sprite = cardBase.Icon;
        nameText.text = cardBase.Name;
       
        
    }

    public void OnClick()
    {
        Debug.Log("クリックされました");
        OnClickCard?.Invoke(this);
    }

    public void OnPointerEnter()
    {
        transform.position += Vector3.up * 0.3f;
        transform.localScale = Vector3.one * 1.2f;
        GetComponentInChildren<Canvas>().sortingLayerName = "OverLay";
    }

    public void OnPointerExit()
    {
        transform.position += Vector3.down * 0.3f;
        transform.localScale = Vector3.one;
        GetComponentInChildren<Canvas>().sortingLayerName = "Default";
    }

    public void Open()
    {
        hidePanel.SetActive(false);
    }


}