using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Level : MonoBehaviour
{
    public Text levelText;
       void Update()
    {
        levelText.text = "Level 0" + SceneManager.GetActiveScene().buildIndex;
    }
}
