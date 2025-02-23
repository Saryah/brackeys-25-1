using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeviceManager : MonoBehaviour
{
    RaycastHit hit;
    [SerializeField] private LayerMask device, deviceButton;
    public AudioClip click;
    public AudioSource audioSource;
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, Mathf.Infinity, device))
            {
                Debug.Log("Device Found" + hit.collider.gameObject.name);
            }

            if (Physics.Raycast(ray, out hit, Mathf.Infinity, deviceButton))
            {
                Debug.Log("Button Found " + hit.collider.gameObject.GetComponent<MainMenuButton>().buttonIndex);
                hit.collider.gameObject.GetComponent<Animator>().SetTrigger("Clicked");
                //int randClick = Random.Range(0, click.Length);
                audioSource.PlayOneShot(click);
                MainMenuButton clickedButton = hit.collider.gameObject.GetComponent<MainMenuButton>();
                if (MainMenu.instance.inMainMenu)
                {
                    if (clickedButton.buttonIndex == 1)
                    {
                        return;
                    }
                    if (clickedButton.buttonIndex == 2)
                    {
                        return;
                    }
                    if (clickedButton.buttonIndex == 3)
                    {
                        return;
                    }
                    if (clickedButton.buttonIndex == 4)
                    {
                        StartCoroutine(Wait());
                    }
                    if (clickedButton.buttonIndex == 5)
                    {
                        return;
                        //StartCoroutine(Wait());
                        //MainMenu.instance.Options();
                    }
                    if (clickedButton.buttonIndex == 6)
                    {
                        StartCoroutine(Wait());
                        MainMenu.instance.ExitGame();
                    }
                    if (clickedButton.buttonIndex == 7)
                    {
                        return;
                    }
                }
                if (MainMenu.instance.inColorSelect)
                {
                    if (clickedButton.buttonIndex == 1)
                    {
                        clickedButton.colorSelect = 0;
                        ColorSelect.instance.activeColor = ColorSelect.instance.colors[(ColorSelect.instance.pageIndex * 4) + clickedButton.colorSelect];
                        ColorSelect.instance.choices[clickedButton.colorSelect].text = ColorSelect.instance.colorNames[ColorSelect.instance.pageIndex * 4 + clickedButton.colorSelect];
                    }

                    if (clickedButton.buttonIndex == 2)
                    {
                        clickedButton.colorSelect = 1;
                        ColorSelect.instance.activeColor = ColorSelect.instance.colors[(ColorSelect.instance.pageIndex * 4) + clickedButton.colorSelect];
                        ColorSelect.instance.choices[clickedButton.colorSelect].text = ColorSelect.instance.colorNames[ColorSelect.instance.pageIndex * 4 + clickedButton.colorSelect];
                    }

                    if (clickedButton.buttonIndex == 3)
                    {
                        ColorSelect.instance.PreviousPage();
                    }

                    if (clickedButton.buttonIndex == 4)
                    {
                        clickedButton.colorSelect = 2;
                        ColorSelect.instance.activeColor = ColorSelect.instance.colors[(ColorSelect.instance.pageIndex * 4) + clickedButton.colorSelect];
                        ColorSelect.instance.choices[clickedButton.colorSelect].text = ColorSelect.instance.colorNames[ColorSelect.instance.pageIndex * 4 + clickedButton.colorSelect];
                    }

                    if (clickedButton.buttonIndex == 5)
                    {
                        clickedButton.colorSelect = 3;
                        ColorSelect.instance.activeColor = ColorSelect.instance.colors[(ColorSelect.instance.pageIndex * 4) + clickedButton.colorSelect];
                        ColorSelect.instance.choices[clickedButton.colorSelect].text = ColorSelect.instance.colorNames[ColorSelect.instance.pageIndex * 4 + clickedButton.colorSelect];
                    }

                    if (clickedButton.buttonIndex == 6)
                    {
                        ColorSelect.instance.NextPage();
                    }

                    if (clickedButton.buttonIndex == 7)
                    {
                        StartCoroutine(Wait());
                    }
                }
                if (MainMenu.instance.inCharacterSelect)
                {
                    if (clickedButton.buttonIndex == 1)
                    {
                        CharacterSelect.instance.SelectCharacter(clickedButton.buttonIndex);
                    }

                    if (clickedButton.buttonIndex == 2)
                    {
                        CharacterSelect.instance.SelectCharacter(clickedButton.buttonIndex);
                    }

                    if (clickedButton.buttonIndex == 3)
                    {
                        CharacterSelect.instance.SelectCharacter(clickedButton.buttonIndex);
                    }

                    if (clickedButton.buttonIndex == 4)
                    {
                        CharacterSelect.instance.SelectCharacter(clickedButton.buttonIndex);
                    }

                    if (clickedButton.buttonIndex == 5)
                    {
                        CharacterSelect.instance.SelectCharacter(clickedButton.buttonIndex);
                    }

                    if (clickedButton.buttonIndex == 6)
                    {
                        CharacterSelect.instance.SelectCharacter(clickedButton.buttonIndex);
                    }

                    if (clickedButton.buttonIndex == 7)
                    {
                        Player.instance.playerSprite = CharacterSelect.instance.selectedSprite;
                        Player.instance.playerSprite2 = CharacterSelect.instance.selectedSpritelvl2;
                        Player.instance.playerSpriteIdle = CharacterSelect.instance.idleSprite;
                        SceneManager.LoadScene("Game");
                    }
                }

                if (MainMenu.instance.inOptions)
                {
                    if (clickedButton.buttonIndex == 1)
                    {
                        StartCoroutine(Wait());
                        Options.instance.DecreaseMasterVolume();
                    }
                    if (clickedButton.buttonIndex == 2)
                    {
                        StartCoroutine(Wait());
                        Options.instance.DecreaseBGMVolume();
                    }
                    if (clickedButton.buttonIndex == 3)
                    {
                        StartCoroutine(Wait());
                        Options.instance.DecreaseSFXVolume();
                    }
                    if (clickedButton.buttonIndex == 4)
                    {
                        StartCoroutine(Wait());
                        Options.instance.IncreaseMasterVolume();
                    }
                    if (clickedButton.buttonIndex == 5)
                    {
                        StartCoroutine(Wait());
                        Options.instance.IncreaseBGMVolume();
                        
                    }
                    if (clickedButton.buttonIndex == 6)
                    {
                        StartCoroutine(Wait());
                        Options.instance.IncreaseSFXVolume();
                        
                    }
                    if (clickedButton.buttonIndex == 7)
                    {
                        MainMenu.instance.inMainMenu = true;
                        MainMenu.instance.inOptions = false;
                    }
                }
            }
        }
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(1f);
        if (MainMenu.instance.inMainMenu)
        {
            MainMenu.instance.StartGame();
        }
        else if (MainMenu.instance.inColorSelect)
        {
            MainMenu.instance.SelectCharacter();
        }
    }
}
