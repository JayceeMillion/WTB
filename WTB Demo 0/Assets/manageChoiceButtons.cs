using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class manageChoiceButtons : MonoBehaviour
{
    public TextMeshProUGUI Choice1Text;
    public TextMeshProUGUI Choice2Text;
    public TextMeshProUGUI Choice3Text;
    public Button Choice1Button;
    public Button Choice2Button;
    public Button Choice3Button;
    public GameObject TextBoxChoices;

    void start()
    {
        //Choice1Button = GameObject.FindWithTag("Choice1Button");
        //Choice2Button = GameObject.FindWithTag("Choice2Button");
        //Choice3Button = GameObject.FindWithTag("Choice3Button");
	}

    public void disableAll()
    {
        Choice1Text.enabled = false;
        Choice2Text.enabled = false;
        Choice3Text.enabled = false;
        Choice1Button.gameObject.SetActive(false);
        Choice2Button.gameObject.SetActive(false);
        Choice3Button.gameObject.SetActive(false);
        TextBoxChoices.gameObject.SetActive(false);
	}
    public void enableAll()
    {
        Choice1Text.enabled = true;
        Choice2Text.enabled = true;
        Choice3Text.enabled = true;
        Choice1Button.gameObject.SetActive(true);
        Choice2Button.gameObject.SetActive(true);
        Choice3Button.gameObject.SetActive(true);
        TextBoxChoices.gameObject.SetActive(true);
	}
}
