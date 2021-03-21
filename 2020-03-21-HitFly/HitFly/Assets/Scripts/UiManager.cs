using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiManager : MonoBehaviour
{
    public Text DeadText;

    public void ShowDeadText()
    {
        DeadText.gameObject.SetActive(true);
    }

    public void HideDeadText()
    {
        DeadText.gameObject.SetActive(false);
    }
}
