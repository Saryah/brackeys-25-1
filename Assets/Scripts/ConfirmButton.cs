using UnityEngine;

public class ConfirmButton : MonoBehaviour
{
    public void Confirm()
    {
        WantsUI.instance.ChooseResponse();
        GameManager.instance.AddAnswer(GameManager.instance.selectedChoiceType);
        //GameManager.instance.totalCount++;
    }
}
