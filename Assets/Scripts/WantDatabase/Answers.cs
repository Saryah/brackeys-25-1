using UnityEngine;

[CreateAssetMenu(fileName = "Answer", menuName = "Answers")]
public class Answers : ScriptableObject
{
    public string answerText;
    public ChoiceType choiceType;
}

public enum ChoiceType
{
    Technology,
    PopCulture,
    Political,
    Science,
    Enviroment,
    Economics
}