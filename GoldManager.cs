using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GoldManager : MonoBehaviour
{
    public TextMeshProUGUI goldUIText;

    // recives the ammount of gold player has and updates the text ui
    public void UpdateGoldCollected(int goldAmount)
    {
        Debug.Log("gold ammount changed");
        goldUIText.text = "Gold:" + goldAmount.ToString();
    }

}
