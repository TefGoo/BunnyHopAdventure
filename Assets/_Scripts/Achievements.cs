using UnityEngine;

public class Achievements : MonoBehaviour
{
    public static Achievements instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void UnlockAchievement(string achievementID)
    {
        // Implement achievement unlocking logic
        Debug.Log("Achievement unlocked: " + achievementID);
    }
}
