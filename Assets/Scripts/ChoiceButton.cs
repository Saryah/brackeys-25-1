using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ChoiceButton : MonoBehaviour
{
    public TMP_Text choiceText;
    public string choice;
    public ChoiceType choiceType;
    public Image choiceImage;

    void Update()
    {
        choiceText.text = choice;
    }
    
    public void SelectOption(int choiceNum)
    {
        for (int i = 0; i < ChoicesUI.instance.choiceBools.Length; i++)
        {
            ChoicesUI.instance.choiceBools[i] = false;
            ChoicesUI.instance.choiceButtons[i].choiceImage.color = ChoicesUI.instance.normalCol;
        }
        ChoicesUI.instance.choiceBools[choiceNum] = true;
        choiceImage.color = ChoicesUI.instance.selectedCol;
    }
}
