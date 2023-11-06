using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelManager : MonoBehaviour
{
  [SerializeField] private GameObject panel;

    public void PanelOpen()
    {
        panel.SetActive(true);
    }

    public void PanelClose()
    {
        panel.SetActive(false);
    }
}
