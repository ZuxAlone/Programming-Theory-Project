using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    private int points = 0;
    public int Points
    {
        get
        {
            return points;
        }
        set
        {
            if (value < 0)
            {
                Debug.LogError("Value must be positive");
            }
            else
            {
                points = value;
            }
        }
    }
}
