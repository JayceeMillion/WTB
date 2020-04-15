using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class PrologueDialogue : MonoBehaviour
{
    public Player player;
    public Dialogue[] prologueDialogue;
    public Dialogue beforePortal;
    public TextMeshProUGUI Choice1Text;
    public TextMeshProUGUI Choice2Text;
    public TextMeshProUGUI Choice3Text;
    public Button Choice1Button;
    public Button Choice2Button;
    public Button Choice3Button;
    public GameObject TextBoxChoices;

    public DialogueManager dialogueManager;
    public manageChoiceButtons ChoiceButtonManager;

    public void startPrologue()
    {
        beforePortal.name = player.firstName + " " + player.lastName;
        beforePortal.sentences[0] = "You sigh as you open your front door and walk into your apartment. " +
            "Rent's due in a few days and you're struggling to pay it. You throw your keys in a bowl on your dining table, which is also the only table you own. " +
            "Honestly, you have no idea how to make ends meet this month and it's stressing you out. Should you get a second job? Should you just run and live in the woods? Turn to a life of crime?";
        beforePortal.sentences[1] = "Or prostitution? You're not proud that the thought even crossed your mind, but you've heard of a few girls in your area who found creative ways to make ends meet. " + 
            "Soliciting men for sex, porn, stripping... Even just becoming a camgirl, showing off for men online. But... you turn to your full-size mirror and sigh. Who would want to pay for you? " + 
            $"You look yourself over, staring at your {player.describeHairLength()} {player.hairColor} hair, your {player.skinColor} skin, your {player.describeBreasts()} breasts and {player.describeButt()} behind... You're not exactly the porn star type.";
        beforePortal.sentences[2] = "You're broken out of your train of thought by an odd noise behind you. You turn around and gasp. Right in the middle of your tiny apartment is a huge, pink, swirling vortex. " + 
            "What the fuck? As you struggle to even comprehend what you're seeing, you feel yourself moving towards it by sheer force. It's pulling you in!";
        beforePortal.sentences[3] = "What do you do?";
        Choice1Text.text = "Fuck it. I jump in!";
        Choice2Text.text = "Run!";
        prologueDialogue[0] = beforePortal;
        //start dialogue, play through to end of beforePortal, then show button options
        dialogueManager.StartDialogue(prologueDialogue[0]);
        ChoiceButtonManager.disableAll();
        Choice1Button.gameObject.SetActive(true);
        Choice1Text.enabled = true;
        Choice2Button.gameObject.SetActive(true);
        Choice2Text.enabled = true;
        TextBoxChoices.gameObject.SetActive(true);
	}
    void Start()
    {
        Choice1Text = gameObject.GetComponent<TMPro.TextMeshProUGUI>();
        Choice2Text = gameObject.GetComponent<TMPro.TextMeshProUGUI>();
        Choice3Text = gameObject.GetComponent<TMPro.TextMeshProUGUI>();
        Choice1Button = gameObject.GetComponent<Button>();
        Choice2Button = gameObject.GetComponent<Button>();
        Choice3Button = gameObject.GetComponent<Button>();
        TextBoxChoices = GameObject.FindWithTag("TextBoxMenu");
        player = gameObject.GetComponent("Player") as Player;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
