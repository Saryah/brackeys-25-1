using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class WantsUI : MonoBehaviour
{
    public static WantsUI instance;
    public ChoiceButtonInfo[] buttons;
    [SerializeField] private Questions question;
    public NeedType need;
    [SerializeField] TMP_Text gameTitleTxt;
    public GameObject choicesUI;
    public Sprite techBoarder, poliBoarder, popBoarder, enviroBoarder, econBoarder, sciBoarder, normBoarder, selectBoarder;
    public Color techColor, poliColor, popColor, enviroColor, econColor, sciColor;
    public Image[] counter;
    public int counterIndex;

        void Awake()
    {
        if(instance != null)
            Destroy(instance);
        instance = this;
    }


    void Start()
    {
        choicesUI.SetActive(false);
        gameTitleTxt.text = GameManager.instance.GameTitle;
        foreach (var strike in counter)
        {
            strike.gameObject.SetActive(false);
        }
    }

    void Update()
    {
        if(!PetInfo.instance.stopWants)
            gameTitleTxt.text = GameManager.instance.GameTitle;
    }

    public void UpdateUI()
    {
        if (GameManager.instance.gameOver)
            return;
        foreach (var button in buttons)
        {
            if(button.isSelected)
                button.choiceImage.sprite = selectBoarder;
            else
                button.choiceImage.sprite = normBoarder;
        }
    }
    public void PopulateWant()
    {
        if (PetInfo.instance.hunger <= 0)
        {
            int rand = Random.Range(0, DeviceInteraction.instance.hungerQuestions.Length);
            question = DeviceInteraction.instance.hungerQuestions[rand];
            need = NeedType.Hunger;
        }

        if (PetInfo.instance.social <= 0)
        {
            int rand = Random.Range(0, DeviceInteraction.instance.socialQuestions.Length);
            question = DeviceInteraction.instance.socialQuestions[rand];
            need = NeedType.Social;
        }
        if (PetInfo.instance.education <= 0)
        {
            int rand = Random.Range(0, DeviceInteraction.instance.educationQuestions.Length);
            question = DeviceInteraction.instance.educationQuestions[rand];
            need = NeedType.Education;
        }
        if (PetInfo.instance.fun <= 0)
        {
            int rand = Random.Range(0, DeviceInteraction.instance.funQuestions.Length);
            question = DeviceInteraction.instance.funQuestions[rand];
            need = NeedType.Fun;
        }

        PopulateResponse();
    }
    public void PopulateResponse()
    {
        List<ChoiceType> types = new List<ChoiceType>();
        types.Clear();
        types.Add(ChoiceType.Technology);
        types.Add(ChoiceType.Political);
        types.Add(ChoiceType.PopCulture);
        types.Add(ChoiceType.Enviroment);
        types.Add(ChoiceType.Economics);
        types.Add(ChoiceType.Science);
        foreach (var b in buttons)
        {
            int rand = Random.Range(0, types.Count);
            Debug.Log(types[rand]);
            b.choiceType = types[rand];
            if (need == NeedType.Hunger)
            {
                if (b.choiceType == ChoiceType.Technology)
                {
                    int want = Random.Range(0, DeviceInteraction.instance.hungerTechResponse.Length);
                    b.answer = DeviceInteraction.instance.hungerTechResponse[want];
                }
                if (b.choiceType == ChoiceType.PopCulture)
                {
                    int want = Random.Range(0, DeviceInteraction.instance.hungerPopResponse.Length);
                    b.answer = DeviceInteraction.instance.hungerPopResponse[want];
                }
                if (b.choiceType == ChoiceType.Political)
                {
                    int want = Random.Range(0, DeviceInteraction.instance.hungerPolResponse.Length);
                    b.answer = DeviceInteraction.instance.hungerPolResponse[want];
                }
                if (b.choiceType == ChoiceType.Enviroment)
                {
                    int want = Random.Range(0, DeviceInteraction.instance.hungerEnviroResponse.Length);
                    b.answer = DeviceInteraction.instance.hungerEnviroResponse[want];
                }
                if (b.choiceType == ChoiceType.Economics)
                {
                    int want = Random.Range(0, DeviceInteraction.instance.hungerEconResponse.Length);
                    b.answer = DeviceInteraction.instance.hungerEconResponse[want];
                }
                if (b.choiceType == ChoiceType.Science)
                {
                    int want = Random.Range(0, DeviceInteraction.instance.hungerScienceResponse.Length);
                    b.answer = DeviceInteraction.instance.hungerScienceResponse[want];
                }
            }

            if (need == NeedType.Social)
            {
                if (b.choiceType == ChoiceType.Technology)
                {
                    int want = Random.Range(0, DeviceInteraction.instance.socialTechResponse.Length);
                    b.answer = DeviceInteraction.instance.socialTechResponse[want];
                }
                if (b.choiceType == ChoiceType.PopCulture)
                {
                    int want = Random.Range(0, DeviceInteraction.instance.socialPopResponse.Length);
                    b.answer = DeviceInteraction.instance.socialPopResponse[want];
                }
                if (b.choiceType == ChoiceType.Political)
                {
                    int want = Random.Range(0, DeviceInteraction.instance.socialPolResponse.Length);
                    b.answer = DeviceInteraction.instance.socialPolResponse[want];
                }
                if (b.choiceType == ChoiceType.Enviroment)
                {
                    int want = Random.Range(0, DeviceInteraction.instance.socialEnviroResponse.Length);
                    b.answer = DeviceInteraction.instance.socialEnviroResponse[want];
                }
                if (b.choiceType == ChoiceType.Economics)
                {
                    int want = Random.Range(0, DeviceInteraction.instance.socialEconResponse.Length);
                    b.answer = DeviceInteraction.instance.socialEconResponse[want];
                }
                if (b.choiceType == ChoiceType.Science)
                {
                    int want = Random.Range(0, DeviceInteraction.instance.socialScienceResponse.Length);
                    b.answer = DeviceInteraction.instance.socialScienceResponse[want];
                }
            }

            if (need == NeedType.Education)
            {
                if (b.choiceType == ChoiceType.Technology)
                {
                    int want = Random.Range(0, DeviceInteraction.instance.educationTechResponse.Length);
                    b.answer = DeviceInteraction.instance.educationTechResponse[want];
                }
                if (b.choiceType == ChoiceType.PopCulture)
                {
                    int want = Random.Range(0, DeviceInteraction.instance.educationPopResponse.Length);
                    b.answer = DeviceInteraction.instance.educationPopResponse[want];
                }
                if (b.choiceType == ChoiceType.Political)
                {
                    int want = Random.Range(0, DeviceInteraction.instance.educationPolResponse.Length);
                    b.answer = DeviceInteraction.instance.educationPolResponse[want];
                }
                if (b.choiceType == ChoiceType.Enviroment)
                {
                    int want = Random.Range(0, DeviceInteraction.instance.educationEnviroResponse.Length);
                    b.answer = DeviceInteraction.instance.educationEnviroResponse[want];
                }
                if (b.choiceType == ChoiceType.Economics)
                {
                    int want = Random.Range(0, DeviceInteraction.instance.educationEconResponse.Length);
                    b.answer = DeviceInteraction.instance.educationEconResponse[want];
                }
                if (b.choiceType == ChoiceType.Science)
                {
                    int want = Random.Range(0, DeviceInteraction.instance.educationScienceResponse.Length);
                    b.answer = DeviceInteraction.instance.educationScienceResponse[want];
                }
            }

            if (need == NeedType.Fun)
            {
                if (b.choiceType == ChoiceType.Technology)
                {
                    int want = Random.Range(0, DeviceInteraction.instance.funTechResponse.Length);
                    b.answer = DeviceInteraction.instance.funTechResponse[want];
                }
                if (b.choiceType == ChoiceType.PopCulture)
                {
                    int want = Random.Range(0, DeviceInteraction.instance.funPopResponse.Length);
                    b.answer = DeviceInteraction.instance.funPopResponse[want];
                }
                if (b.choiceType == ChoiceType.Political)
                {
                    int want = Random.Range(0, DeviceInteraction.instance.funPolResponse.Length);
                    b.answer = DeviceInteraction.instance.funPolResponse[want];
                }
                if (b.choiceType == ChoiceType.Enviroment)
                {
                    int want = Random.Range(0, DeviceInteraction.instance.funEnviroResponse.Length);
                    b.answer = DeviceInteraction.instance.funEnviroResponse[want];
                }
                if (b.choiceType == ChoiceType.Economics)
                {
                    int want = Random.Range(0, DeviceInteraction.instance.funEconResponse.Length);
                    b.answer = DeviceInteraction.instance.funEconResponse[want];
                }
                if (b.choiceType == ChoiceType.Science)
                {
                    int want = Random.Range(0, DeviceInteraction.instance.funScienceResponse.Length);
                    b.answer = DeviceInteraction.instance.funScienceResponse[want];
                }
            }
            types.RemoveAt(rand);
        }

        gameTitleTxt.text = question.answer;
        choicesUI.SetActive(true);
    }
    public void ChooseResponse()
    {
        
        foreach (var button in buttons)
        {
            button.isSelected = false;
            if (button.choiceType == ChoiceType.Technology)
            {
                button.choiceImage.sprite = techBoarder;
            }

            if (button.choiceType == ChoiceType.PopCulture)
            {
                button.choiceImage.sprite = popBoarder;
            }

            if (button.choiceType == ChoiceType.Political)
            {
                button.choiceImage.sprite = poliBoarder;
            }

            if (button.choiceType == ChoiceType.Enviroment)
            {
                button.choiceImage.sprite = enviroBoarder;
            }

            if (button.choiceType == ChoiceType.Economics)
            {
                button.choiceImage.sprite = econBoarder;
            }

            if (button.choiceType == ChoiceType.Science)
            {
                button.choiceImage.sprite = sciBoarder;
            }

            if (GameManager.instance.selectedChoiceType == ChoiceType.Technology)
                counter[counterIndex].color = techColor;
            if (GameManager.instance.selectedChoiceType == ChoiceType.PopCulture)
                counter[counterIndex].color = popColor;
            if (GameManager.instance.selectedChoiceType == ChoiceType.Political)
                counter[counterIndex].color = poliColor;
            if (GameManager.instance.selectedChoiceType == ChoiceType.Enviroment)
                counter[counterIndex].color = enviroColor;
            if (GameManager.instance.selectedChoiceType == ChoiceType.Economics)
                counter[counterIndex].color = econColor;
            if (GameManager.instance.selectedChoiceType == ChoiceType.Science)
                counter[counterIndex].color = sciColor;
            counter[counterIndex].gameObject.SetActive(true);
        }
        counterIndex++;
        StartCoroutine(RevealResponse());

    }

    IEnumerator RevealResponse()
    {
        
        yield return new WaitForSeconds(2.5f);
        counter[counterIndex - 1].gameObject.SetActive(true);
        if (need == NeedType.Education)
            PetInfo.instance.education = 1;
        if(need == NeedType.Fun)
            PetInfo.instance.fun = 1;
        if(need == NeedType.Hunger)
            PetInfo.instance.hunger = 1;
        if(need == NeedType.Social)
            PetInfo.instance.social = 1;
        UpdateUI();
        choicesUI.SetActive(false);
        PetInfo.instance.stopWants = false;
    }

    void ShowProp()
    {
        
    }
}
