using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public static MainMenu instance;
    public bool inMainMenu, inOptions, inColorSelect, inCharacterSelect;
    public GameObject mainMenu, options, colorSelect, characterSelect;

    void Awake()
    {
        if (instance != null)
            Destroy(instance);
        instance = this;
        
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        inMainMenu = true;
        inOptions = false;
        inColorSelect = false;
        inCharacterSelect = false;
    }

    // Update is called once per frame
    void Update()
    {
        mainMenu.SetActive(inMainMenu);
        options.SetActive(inOptions);
        colorSelect.SetActive(inColorSelect);
        characterSelect.SetActive(inCharacterSelect);
    }

    public void StartGame()
    {
        inMainMenu = false;
        inOptions = false;
        inColorSelect = true;
        inCharacterSelect = false;
        ColorSelect.instance.UpdateColors();
    }

    public void Options()
    {
        inMainMenu = false;
        inOptions = true;
        inColorSelect = false;
        inCharacterSelect = false;
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void SelectCharacter()
    {
        inMainMenu = false;
        inOptions = false;
        inColorSelect = false;
        inCharacterSelect = true;
    }
}
