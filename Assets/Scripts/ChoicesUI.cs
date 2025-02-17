using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ChoicesUI : MonoBehaviour
{
    public static ChoicesUI instance;
    public ChoiceButton[] choiceButtons;
    public List<string> choiceNames;
    public List<ChoiceType> choiceTypes;
    public List<Choice> hungerWants, funWants, socialWants, educationWants = new List<Choice>();
    public Choice selectedWant;
    public TMP_Text wantTxt;
    public bool[] choiceBools = new bool[6];
    public bool answeringQuestions = false;
    [SerializeField] int oneToColor;
    public GameObject choicePanel;

    public Color techColor, popColor, polColor, enviroColor, sciCol, ecoCol, selectedCol, normalCol;

    void Awake()
    {
        if(instance != null)
            Destroy(instance);
        instance = this;
    }

    void Start()
    {
        SetWants();
        Pet.instance.hunger = 1f;
        Pet.instance.social = 1f;
        Pet.instance.education = 1f;
        Pet.instance.fun = 1f;
        choicePanel.SetActive(false);
    }
    
    public void SetWants()
    {
        hungerWants.Clear();
        funWants.Clear();
        socialWants.Clear();
        educationWants.Clear();
        Choice[] hunger = Resources.LoadAll<Choice>("Wants/Hunger");
        Choice[] fun = Resources.LoadAll<Choice>("Wants/Fun");
        Choice[] social = Resources.LoadAll<Choice>("Wants/Social");
        Choice[] education = Resources.LoadAll<Choice>("Wants/Education");
        foreach (var want in hunger)
        {
            hungerWants.Add(want);
        }

        foreach (var want in fun)
        {
            funWants.Add(want);
        }

        foreach (var want in social)
        {
            socialWants.Add(want);
        }

        foreach (var want in education)
        {
            educationWants.Add(want);
        }
        
    }

    void ChooseWant()
    {
        if (Pet.instance.hunger <= 0)
        {
            int rand = Random.Range(0, hungerWants.Count);
            selectedWant = hungerWants[rand];
            hungerWants.RemoveAt(rand);
        }

        if (Pet.instance.fun <= 0)
        {
            int rand = Random.Range(0, funWants.Count);
            selectedWant = funWants[rand];
            funWants.RemoveAt(rand);
        }

        if (Pet.instance.social <= 0)
        {
            int rand = Random.Range(0, socialWants.Count);
            selectedWant = socialWants[rand];
            socialWants.RemoveAt(rand);
        }

        if (Pet.instance.education <= 0)
        {
            int rand = Random.Range(0, educationWants.Count);
            selectedWant = educationWants[rand];
            educationWants.RemoveAt(rand);
        }
    }
    
    public void SetButtons()
    {
        wantTxt.text = selectedWant.want;
        choiceNames.Clear();
        choiceTypes.Clear();
        for (int i = 0; i < selectedWant.choice.Count; i++)
        {
            choiceNames.Add(selectedWant.choice[i]);
            choiceTypes.Add(selectedWant.choiceTypes[i]);
        }

        foreach (var button in choiceButtons)
        {
            int randomChoice = Random.Range(0, choiceNames.Count);
            Debug.Log(randomChoice);
            button.choice = choiceNames[randomChoice];
            button.choiceType = choiceTypes[randomChoice];
            choiceTypes.RemoveAt(randomChoice);
            choiceNames.RemoveAt(randomChoice);
        }
    }

    public void StartQuestion()
    {
        ChooseWant();
        SetButtons();
    }

    public void MakeSelection()
    {
        for (int i = 0; i < choiceBools.Length; i++)
        {
            if (choiceBools[i])
            {
                if (choiceButtons[i].choiceType == ChoiceType.Technology)
                {
                    Pet.instance.tech++;
                    choiceButtons[i].choiceImage.color = techColor;
                }
                if (choiceButtons[i].choiceType == ChoiceType.PopCulture)
                {
                    Pet.instance.pop++;
                    choiceButtons[i].choiceImage.color = popColor;
                }
                if (choiceButtons[i].choiceType == ChoiceType.Enviromental)
                {
                    Pet.instance.enviroment++;
                    choiceButtons[i].choiceImage.color = enviroColor;
                }
                if (choiceButtons[i].choiceType == ChoiceType.Political)
                {
                    Pet.instance.pol++;
                    choiceButtons[i].choiceImage.color = polColor;
                }
                if (choiceButtons[i].choiceType == ChoiceType.Economics)
                {
                    Pet.instance.economy++;
                    choiceButtons[i].choiceImage.color = ecoCol;
                }
                if (choiceButtons[i].choiceType == ChoiceType.Science)
                {
                    Pet.instance.science++;
                    choiceButtons[i].choiceImage.color = sciCol;
                }
            }
            if (choiceButtons[i].choiceType == ChoiceType.Technology)
            {
                choiceButtons[i].choiceImage.color = techColor;
            }
            if (choiceButtons[i].choiceType == ChoiceType.PopCulture)
            {
                choiceButtons[i].choiceImage.color = popColor;
            }
            if (choiceButtons[i].choiceType == ChoiceType.Enviromental)
            {
                choiceButtons[i].choiceImage.color = enviroColor;
            }
            if (choiceButtons[i].choiceType == ChoiceType.Political)
            {
                choiceButtons[i].choiceImage.color = polColor;
            }
            if (choiceButtons[i].choiceType == ChoiceType.Economics)
            {
                choiceButtons[i].choiceImage.color = ecoCol;
            }
            if (choiceButtons[i].choiceType == ChoiceType.Science)
            {
                choiceButtons[i].choiceImage.color = sciCol;
            }
            Pet.instance.hunger += selectedWant.hunger;
            Pet.instance.fun += selectedWant.fun;
            Pet.instance.social += selectedWant.social;
            Pet.instance.education += selectedWant.education;
        }

        StartCoroutine(StartNext());
    }

    public IEnumerator StartNext()
    {
        yield return new WaitForSeconds(5f);

        foreach (var button in choiceButtons)
        {
            button.choiceImage.color = normalCol;
        }
        choicePanel.SetActive(false);
        answeringQuestions = false;
        if (GameManager.instance.totalQuestions >= 6)
        {
            GameManager.instance.gameOver = true;
        }
    }
}
