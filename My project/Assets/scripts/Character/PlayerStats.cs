using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerStats : MonoBehaviour
{
    [HideInInspector]
    public int PlayerLevel;
    public int MaxHealth = 100;
    public int CurrentHealth = 100;
    public int MaxStamina = 100;
    public int CurrentStamina = 100;

    public TMP_Text message;

    public List<GameObject> Inventory;
}
