using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Choice", menuName = "Scriptable Objects/Choice")]
public class Choice : ScriptableObject
{
    
    [TextArea(3,15)]public string want;
    public List<string> choice = new List<string>();
    public List<ChoiceType> choiceTypes = new List<ChoiceType>();
    public int hunger, fun, social, education;
}
public enum ChoiceType
{
    Technology,
    PopCulture,
    Political,
    Enviromental,
    Science,
    Economics
}
