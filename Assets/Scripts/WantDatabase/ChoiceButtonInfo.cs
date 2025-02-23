using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ChoiceButtonInfo : MonoBehaviour
{
    public int buttonIndex;
    public Answers answer;
    [SerializeField] TMP_Text answerTxt;
    public ChoiceType choiceType;
    public Image choiceImage;
    public bool isSelected = false;




    void Update()
    {
        if (answer == null)
            return;
        answerTxt.text = answer.answerText;
        if (isSelected)
        {
            choiceImage.sprite = WantsUI.instance.selectBoarder;
        }
        else
        {
            choiceImage.sprite = WantsUI.instance.normBoarder;
        }
    }

    public void Selection()
    {
        foreach (var button in WantsUI.instance.buttons)
        {
            button.isSelected = false;
        }
        isSelected = true;
        GameManager.instance.selectedChoiceType = choiceType;
    }
}
