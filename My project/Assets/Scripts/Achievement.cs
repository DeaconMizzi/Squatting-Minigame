using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Achievement : MonoBehaviour
{
    // Rename the 'name' property to avoid conflicts
    public string achievementName;
    public string description;
    public bool isUnlocked;

    public void Initialize(string name, string description)
    {
        this.achievementName = name;
        this.description = description;
        this.isUnlocked = false;
    }

    public void Unlock()
    {
        isUnlocked = true;
        Debug.Log(achievementName + " achievement unlocked!");
        // Add any other logic for handling unlocked achievements here
    }
}