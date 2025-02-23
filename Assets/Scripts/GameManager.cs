using UnityEngine;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public string GameTitle = "My Pet AI";

    public int totalCount;
     public bool gameOver = false;
    public ChoiceType selectedChoiceType;
    public int[] answerCounts;
    public string[] answerNames;
    [SerializeField] private float timer = 5f;
    [SerializeField] int highestAnswer = 0;
    [SerializeField] string highestAnswerName;

    void Awake()
    {
        if(instance != null)
            Destroy(instance);
        instance = this;
        
    }

    void Start()
    {
        gameOver = false;
    }

    void Update()
    {
        totalCount = WantsUI.instance.counterIndex;
        if (totalCount >= 12)
        {
            gameOver = true;
            for (int i = 0; i < answerNames.Length; i++)
            {
                if (answerCounts[i] >= highestAnswer)
                {
                    highestAnswer = answerCounts[i];
                    highestAnswerName = answerNames[i];
                }
            }
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                Player.instance.highestAnswer = highestAnswerName;
                SceneManager.LoadScene("GameOver");
            }
        }
    }

    public void AddAnswer(ChoiceType answer)
    {
        if (answer == ChoiceType.Technology)
            answerCounts[0]++;
        if (answer == ChoiceType.PopCulture)
            answerCounts[1]++;
        if (answer == ChoiceType.Political)
            answerCounts[2]++;
        if (answer == ChoiceType.Enviroment)
            answerCounts[3]++;
        if (answer == ChoiceType.Science)
            answerCounts[4]++;
        if (answer == ChoiceType.Economics)
            answerCounts[5]++;
    }
}
