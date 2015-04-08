﻿/****************************************************************************************************
 * Primary Contributor: Derrick Gold
 * Secondary Contributors: Curtis Murray
 * 
 * Description: Keeps track of any global variables and gameobjects. This script can be called by
 *              any other script to access any of its variables
 ****************************************************************************************************/

using UnityEngine;
using UnityEngine.UI; 
using System.Collections;

public class Common: MonoBehaviour {
    //Player GameObjects
    [HideInInspector]
    public GameObject player;

    //AI GameObjects
    [HideInInspector]
	public GameObject[] ai;

    //Sound GameObjects
	public enum AudioSFX {
			SNOWBALL_THROW = 0, SNOWBALL_HIT = 1
	};
	public AudioSource[] sfx;

    //Misc GameObjects
	public GameObject SnowBall;
    public GameObject DeathExplosion;
	public Sprite infAmmonIcon;
	public Sprite infHealthIcon;
	public Sprite infStaminIcon;
	public Sprite speedBoostIcon;
	public Sprite superSnowballIcon;
	public Sprite healthIcon;

	public int TEAM_A_KILLS = 0;
	public int TEAM_B_KILLS = 0;
	public Color TEAM_A_COLOR = Color.black;
	public Color TEAM_B_COLOR = Color.black;
	public string playerTeam;

	public Text topText;
	public Text bottomText;

	void Start()
	{
        if (Application.loadedLevelName != "Intro")
        {
            GameObject hud = GameObject.FindGameObjectWithTag("hud");//<"hud">();
            topText = hud.transform.FindChild("teamA_score").GetComponent<Text>();
            bottomText = hud.transform.FindChild("teamB_score").GetComponent<Text>();
        }
	}

	void Update()
	{
        if (Application.loadedLevelName != "Intro")
        {
            	topText.text = TEAM_A_KILLS.ToString();
				topText.color = TEAM_A_COLOR;
            	bottomText.text = TEAM_B_KILLS.ToString();
				bottomText.color = TEAM_B_COLOR;
        }
	}
}