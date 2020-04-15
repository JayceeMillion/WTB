using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public string firstName, lastName, hairColor, skinColor;
    public int hairLength, breastSize, buttSize, bodySize, lipSize, luisRelationship, cockAddiction, cumAddiction, bsq;
    public bool topTorn, bottomTorn, underwearTorn;

    public void changeName (string first, string second)
    {
        this.firstName = first;
        this.lastName = second;
	}
    public void changeHairColor (string color)
    {
        this.hairColor = color;
	}
    public void changeSkinColor (string color)
    {
        this.skinColor = color;
	}
    public void changeHairLength (int length)
    {
        this.hairLength = length;
	}
    public void changeBreastSize (int size)
    {
        this.breastSize = size;
	}
    public void changeButtSize (int size)
    {
        this.buttSize = size;
	}
    public void changeBodySize (int size)
    {
        this.bodySize = size;
	}
    public void changeLipSize (int size)
    {
        this.lipSize = size;
	}
    public void changeLuisRelationship (int size)
    {
        this.luisRelationship = size;
	}
    public void changeCockAddiction(int value)
    {
        this.cockAddiction = value;
	}
    public void changeCumAddiction (int value)
    {
        this.cumAddiction = value;
	}
    public void changeBSQ (int value)
    {
        this.bsq = value;
	}
    public void changeTopTorn (bool value)
    {
        this.topTorn = value;
	}
    public void changeBottomTorn (bool value)
    {
        this.bottomTorn = value;
	}
    public void changeUnderwearTorn (bool value)
    {
        this.underwearTorn = value;
	}
    public void savePlayerData()
    {
        SaveManager.savePlayerData(this);
	}
    public string describeBreasts()
    {
        if (this.breastSize <= 10)
        {
            return "flat";  
		}
        else if (this.breastSize <= 20)
        {
              return "petite";
		}
        else if (this.breastSize <= 30)
        {
              return "cute";
		}
        else if (this.breastSize <= 40)
        {
              return "perky";
		}
        else if (this.breastSize <= 50)
        {
              return "round";
		}
        else if (this.breastSize <= 60)
        {
              return "large";
		}
        else if (this.breastSize <= 70)
        {
              return "heavy";
		}
        else if (this.breastSize <= 80)
        {
              return "massive";
		}
        else if (this.breastSize <= 90)
        {
              return "enormous";
		}
        else
        {
              return "gigantic";
		}
	}
    public string describeButt()
    {
        if (this.buttSize <= 10)
        {
            return "flat";  
		}
        else if (this.buttSize <= 20)
        {
            return "small";  
		}
        else if (this.buttSize <= 30)
        {
            return "average";  
		}
        else if (this.buttSize <= 40)
        {
            return "shapely";  
		}
        else if (this.buttSize <= 50)
        {
            return "large";  
		}
        else if (this.buttSize <= 60)
        {
            return "juicy";  
		}
        else if (this.buttSize <= 70)
        {
            return "bubbly";  
		}
        else if (this.buttSize <= 80)
        {
            return "huge";  
		}
        else if (this.buttSize <= 90)
        {
            return "enormous";  
		}
        else
        {
            return "gigantic";  
		}
	}
    public string describeLips()
    {
        if (this.lipSize <= 10)
        {
            return "thin";  
		}
        else if (this.lipSize <= 20)
        {
            return "kissable";  
		}
        else if (this.lipSize <= 30)
        {
            return "plump";  
		}
        else if (this.lipSize <= 40)
        {
            return "juicy";  
		}
        else if (this.lipSize <= 50)
        {
            return "lucious";  
		}
        else if (this.lipSize <= 60)
        {
            return "beestung";  
		}
        else if (this.lipSize <= 70)
        {
            return "swollen";  
		}
        else if (this.lipSize <= 80)
        {
            return "balloned";  
		}
        else
        {
            return "bloated";  
		}
	}
    public string describeHairLength()
    {
        if (this.hairLength <= 1)
        {
            return "bald";  
		}
        else if (this.hairLength <= 5)
        {
            return "buzzcut";  
		}
        else if (this.hairLength <= 10)
        {
            return "pixie cut";  
		}
        else if (this.hairLength <= 15)
        {
            return "short";  
		}
        else if (this.hairLength <= 20)
        {
            return "neck length";  
		}
        else if (this.hairLength <= 30)
        {
            return "shoulder length";  
		}
        else if (this.hairLength <= 40)
        {
            return "collarbone length";  
		}
        else if (this.hairLength <= 50)
        {
            return "elbow length";  
		}
        else if (this.hairLength <= 60)
        {
            return "cascading";  
		}
        else if (this.hairLength <= 70)
        {
            return "butt length";  
		}
        else if (this.hairLength <= 80)
        {
            return "knee length";  
		}
        else if (this.hairLength <= 90)
        {
            return "heel length";  
		}
        else
        {
            return "rapunzel-esque";  
		}
	}
    public void loadPlayerData()
    {
        PlayerData data = SaveManager.loadSave();
        
        firstName = data.firstName;
        lastName = data.lastName;
        hairColor = data.hairColor;
        skinColor = data.skinColor;
        hairLength = data.hairLength;
        breastSize = data.breastSize;
        buttSize = data.buttSize;
        bodySize = data.bodySize;
        lipSize = data.lipSize;
        luisRelationship = data.luisRelationship;
        cockAddiction = data.cockAddiction;
        cumAddiction = data.cumAddiction;
        bsq = data.bsq;
        topTorn = data.topTorn;
        bottomTorn = data.bottomTorn;
        underwearTorn = data.underwearTorn;
	}
    // Start is called before the first frame update
    void Start()
    {
        
    }
}
