using UnityEngine;

[CreateAssetMenu(fileName = "Questions", menuName = "Questions")]
public class Questions : ScriptableObject
{
    

    public string answer;
    public NeedType andswerType;
}
public enum NeedType
{
    Hunger,
    Social,
    Education,
    Fun
}
