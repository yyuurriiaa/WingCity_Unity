﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestOnOffClear : MonoBehaviour {

    public DialogueScript theDS;

    public int quests;
    public bool[] triggerQuest;
    public bool[] startQuest;
    public bool[] endQuest;
    public bool[] clearQuest;

	// Use this for initialization
	void Start ()
    {

        theDS = FindObjectOfType<DialogueScript>();

		for(int i= 0; i < quests; i++)
        {
            triggerQuest[i] = false;
            startQuest[i] = false;
            endQuest[i] = false;
            clearQuest[i] = false;

        }
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public void QuestTrigger()
    {
        triggerQuest[theDS.questNumber] = true;
    }

    public void QuestStart()
    {        
        startQuest[theDS.questNumber] = true;
        triggerQuest[theDS.questNumber] = false;
    }
        
    public void QuestEnd()
    {        
        endQuest[theDS.questNumber] = true;        
    }

    public void QuestClear()
    {
        clearQuest[theDS.questNumber] = true;
        startQuest[theDS.questNumber] = false;
        endQuest[theDS.questNumber] = false;
        //triggerQuest[theDS.questNumber] = false;
    }
}
