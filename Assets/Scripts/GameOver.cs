using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public TMP_Text headerTxt, endingText;
    [TextArea(10, 10)] public string techEnding, polEnding, popEnding, envEnding, ecoEnding, sciEnding;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        headerTxt.text = Player.instance.highestAnswer;
        if (Player.instance.highestAnswer == "Technology")
            endingText.text = techEnding;
        if (Player.instance.highestAnswer == "Pop Culture")
            endingText.text = popEnding;
        if (Player.instance.highestAnswer == "Politics")
            endingText.text = polEnding;
        if (Player.instance.highestAnswer == "Enviroment")
            endingText.text = envEnding;
        if (Player.instance.highestAnswer == "Science")
            endingText.text = sciEnding;
        if (Player.instance.highestAnswer == "Economics")
            endingText.text = ecoEnding;
    }

    public void TryAgain()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
