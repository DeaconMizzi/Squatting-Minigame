using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SquatScore : MonoBehaviour
{
    public int completedSquats = 0;
    public TextMeshProUGUI squatsText;

    void Start()
    {
        UpdateSquatsText();
    }

    public void IncrementScore()
    {
        completedSquats++;
        UpdateSquatsText();
    }

    void UpdateSquatsText()
    {
        if (squatsText != null)
        {
            squatsText.text = "Squats: " + completedSquats.ToString();
        }
        else
        {
            Debug.LogError("TextMeshPro component for squats is not assigned.");
        }
    }

}
