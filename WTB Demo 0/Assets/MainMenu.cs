using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

class startup
{
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    static void startUpMethod()
    {
        SceneManager.LoadSceneAsync("ManagerScene",LoadSceneMode.Additive);
	}
}



public class MainMenu : MonoBehaviour
{
    public GameObject playerParent;
    public Player player;
    public PrologueDialogue start;
    void Awake()
    {
        try
        {
              playerParent = GameObject.FindWithTag("player");
              //playerParent.gameObject.SetActive(false);
		}
        catch
        {
            Debug.LogError("First one is being a bitch");  
		}
        
        player = playerParent.GetComponent<Player>();
	}
	public void PlayGame()
	{
		SceneManager.LoadSceneAsync("Prologue");
        SceneManager.LoadSceneAsync("ManagerScene",LoadSceneMode.Additive);
        
		
		//player.firstName = "Danielle";
        //player.lastName = "Grey";
        player.changeName("Danielle", "Grey");
        player.hairColor = "Brown";
        player.skinColor = "Pale";
        player.hairLength = 30;
        player.breastSize = 0;
        player.buttSize = 0;
        player.bodySize = 50;
        player.lipSize = 0;
        player.luisRelationship = 0;
        player.cockAddiction = 0;
        player.cumAddiction = 0;
        player.bsq = 0;
        player.topTorn = false;
        player.bottomTorn = false;
        player.underwearTorn = false;
        
        start.startPrologue();
	}
	public void QuitGame()
	{
		Application.Quit();
	}
}
