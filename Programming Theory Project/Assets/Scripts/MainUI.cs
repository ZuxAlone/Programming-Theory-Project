using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MainUI : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI pointsText;
    [SerializeField] Player player;

    public void UpdatePoints()
    {
        pointsText.text = "Points: " + player.Points;
    }
}
