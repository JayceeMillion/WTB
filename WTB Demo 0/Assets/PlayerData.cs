using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public string firstName, lastName, hairColor, skinColor;
    public int hairLength, breastSize, buttSize, bodySize, lipSize, luisRelationship, cockAddiction, cumAddiction, bsq;
    public bool topTorn, bottomTorn, underwearTorn;

    public PlayerData(Player player)
    {
        firstName = player.firstName;
        lastName = player.lastName;
        hairColor = player.hairColor;
        skinColor = player.skinColor;
        hairLength = player.hairLength;
        breastSize = player.breastSize;
        buttSize = player.buttSize;
        bodySize = player.bodySize;
        lipSize = player.lipSize;
        luisRelationship = player.luisRelationship;
        cockAddiction = player.cockAddiction;
        cumAddiction = player.cumAddiction;
        bsq = player.bsq;
        topTorn = player.topTorn;
        bottomTorn = player.bottomTorn;
        underwearTorn = player.underwearTorn;
	}
}
