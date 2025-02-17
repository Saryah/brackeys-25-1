using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    [TextArea(5, 5)] public string ending1, ending2, ending3, ending4, ending5, ending6;
    public string endingTitle1, endingTitle2, endingTitle3, endingTitle4, endingTitle5, endingTitle6;
    public TMP_Text endingTitleTxt, endingTxt;
    
    public GameObject gameOverObj;
    public bool gameOver;
    public int totalQuestions;
    
    public Slider hungerBar, funBar, socialBar, educationBar;

    void Awake()
    {
        if(instance != null)
            Destroy(instance);
        instance = this;
    }

    void Start()
    {
        totalQuestions = 0;
        gameOver = false;
        gameOverObj.SetActive(false);
    }
    void Update()
    {
        totalQuestions = (int)(Pet.instance.tech + Pet.instance.economy + Pet.instance.enviroment + Pet.instance.pol + Pet.instance.pop + Pet.instance.science);
        if (gameOver)
        {
            gameOverObj.SetActive(true);
            // Store all categories in a dictionary with their corresponding ending texts
            Dictionary<string, (float value, string title, string text)> categories = new Dictionary<string, (float, string, string)>
            {
                { "tech", (Pet.instance.tech, endingTitle1, ending1) },
                { "economy", (Pet.instance.economy, endingTitle2, ending2) },
                { "enviroment", (Pet.instance.enviroment, endingTitle3, ending3) },
                { "pol", (Pet.instance.pol, endingTitle4, ending4) },
                { "pop", (Pet.instance.pop, endingTitle5, ending5) },
                { "science", (Pet.instance.science, endingTitle6, ending6) }
            };

            // Find the category with the highest value
            var highestCategory = categories.OrderByDescending(c => c.Value.value).First();

            // Set the ending text
            endingTitleTxt.text = highestCategory.Value.title;
            endingTxt.text = highestCategory.Value.text;
            return;
        }
        MeterChange();
    }

    void MeterChange()
    {
        hungerBar.value = Pet.instance.hunger;
        funBar.value = Pet.instance.fun;
        socialBar.value = Pet.instance.social;
        educationBar.value = Pet.instance.education;
        if (!ChoicesUI.instance.answeringQuestions)
        {
            if (Pet.instance.hunger <= 0 || Pet.instance.fun <= 0 || Pet.instance.social <= 0 ||
                Pet.instance.education <= 0)
            {
                ChoicesUI.instance.StartQuestion();
                ChoicesUI.instance.answeringQuestions = true;
                ChoicesUI.instance.choicePanel.SetActive(true);
            }
        }
    }

    public void TryAgain()
    {
        ChoicesUI.instance.SetWants();
        Pet.instance.hunger = 1f;
        Pet.instance.social = 1f;
        Pet.instance.education = 1f;
        Pet.instance.fun = 1f;
        ChoicesUI.instance.choicePanel.SetActive(false);
        gameOverObj.SetActive(false);
        gameOver = false;
    }
}
