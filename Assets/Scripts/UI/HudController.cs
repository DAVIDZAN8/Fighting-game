﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HudController : MonoBehaviour {
	public Fighter player1;
	public Fighter player2;

	public Text player1Tag;
	public Text player2Tag;

	public Scrollbar leftBar;
	public Scrollbar rightBar;

	public Text timerText;

	public BattleController battle;


	// Use this for initialization
	void Start () {
        if (player1 != null)
        {
            player1Tag.text = player1.fighterName;
        }else
        {
            player1Tag.text = GameObject.FindGameObjectWithTag("Player1").GetComponent<Fighter>().fighterName;
        }

		player2Tag.text = player2.fighterName;
	}
	
	// Update is called once per frame
	void Update () {
		timerText.text = battle.roundTime.ToString();
        if (player1 != null)
        {
            if (leftBar.size >= player1.healtPercent)
            {
                leftBar.size -= 0.01f;
            }
        }else
        {
            player1 = GameObject.FindGameObjectWithTag("Player1").GetComponent<Fighter>();
            
        }
		if (rightBar.size >= player2.healtPercent) {
			rightBar.size-= 0.01f;
		}
	}
}
