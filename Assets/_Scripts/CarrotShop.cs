using UnityEngine;
using UnityEngine.UI;

public class CarrotShop : MonoBehaviour
{
    public Text carrotCountText;
    private int carrotCount;

    void Start()
    {
        carrotCount = PlayerPrefs.GetInt("CarrotCount", 0);
        UpdateUI();
    }

    public void BuyItem(int cost)
    {
        if (carrotCount >= cost)
        {
            carrotCount -= cost;
            PlayerPrefs.SetInt("CarrotCount", carrotCount);
            UpdateUI();
            // Implement item purchase logic
        }
        else
        {
            Debug.Log("Not enough carrots!");
        }
    }

    void UpdateUI()
    {
        carrotCountText.text = "Carrots: " + carrotCount;
    }
}
