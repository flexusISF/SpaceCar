using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public List<GameObject> targets;
    private int score;
    public TextMeshProUGUI scoreText;


    // Start is called before the first frame update
    void Start()
    {
        UpdateScore(0);
       
    }

    // Update is called once per frame
    void Update()
    {
       while (true) { UpdateScore(1); }
    }

    void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
       scoreText.text = "Score:" + score;
    }
}
