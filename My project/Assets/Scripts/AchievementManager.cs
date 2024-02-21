using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AchievementManager : MonoBehaviour
{
    private Achievement enduranceChampionAchievement;
    private List<Achievement> achievements = new List<Achievement>();
    private bool enduranceChampionUnlocked = false;
    public AchievementUI achievementUI;
    // Reference to the Timer script
    public Timer timerScript;
    public SquatScore squatScore;

    

    // Counter to track the number of squats completed
    private int squatsCompleted;

    void Start()
    {
        squatScore = FindObjectOfType<SquatScore>();
        // Create an empty GameObject to represent the achievement
        GameObject achievementObject = new GameObject("Endurance Champion Achievement");
        enduranceChampionAchievement = achievementObject.AddComponent<Achievement>();

        // Initialize the achievement
        enduranceChampionAchievement.Initialize("Endurance Champion", "Complete 60 squats within 15 seconds.");
        achievements.Add(enduranceChampionAchievement);
    }

    void Update()
    {
        if (!enduranceChampionUnlocked)
        {
            CheckForEnduranceChampionAchievement();
        }
    }

    void UpdateAchievementUI(Achievement achievement)
    {
        achievementUI.UpdateUI(achievement.achievementName, achievement.description, achievement.isUnlocked);
    }

    private IEnumerator DeactivateAchievementCanvas(float delay)
    {
        yield return new WaitForSeconds(delay);
        achievementUI.achievementCanvas.SetActive(false);
    }
    
    // Method to check if the achievement condition is met and unlock it
    private void CheckForEnduranceChampionAchievement()
    {
        // Example condition: Check if the player has completed 100 squats within 15 seconds
        if (squatScore.completedSquats >= 60)
        {
            enduranceChampionAchievement.Unlock();
            enduranceChampionUnlocked = true;
            achievementUI.achievementCanvas.SetActive(true);
            UpdateAchievementUI(enduranceChampionAchievement);
            StartCoroutine(DeactivateAchievementCanvas(3f));
        }
    }
        
}
