using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class AchievementUI : MonoBehaviour
{
    public TMP_Text achievementNameText;
    public TMP_Text descriptionText;
    public GameObject achievementCanvas;

    public GameObject achievementEndCanvas;

    public TMP_Text achievementEndNameText;
    public TMP_Text descriptionEndText;


    public void UpdateUI(string achievementName, string description, bool isUnlocked)
    {
        achievementNameText.text = achievementName;
        descriptionText.text = description;
        achievementEndNameText.text = achievementName;
        descriptionEndText.text = description;
    }
}
