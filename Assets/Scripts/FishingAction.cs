﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishingAction : MonoBehaviour
{
    Fishing fishing = new Fishing();
    public ItemDatabase itemDatabase;


    private void OnMouseDown()
    {
        Debug.Log("Ive been clicked UWU");
        Item fishCaught = fishing.CastLine(itemDatabase);
        Debug.Log(fishCaught.name);
    }
    
}
