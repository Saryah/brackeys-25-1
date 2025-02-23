using System.Collections;
using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;

public class Pet : MonoBehaviour
{
    public GameObject lvl1, lvl2;
    public SpriteRenderer sr1, sr2, srI;
    public Sprite sprite1, sprite2, spriteI;
    public int lvl;
    private bool _evolving;

    void Start()
    {
        sprite1 = Player.instance.playerSprite;
        sprite2 = Player.instance.playerSprite2;
        spriteI = Player.instance.playerSpriteIdle;
        sr1.sprite = sprite1;
        sr2.sprite = sprite2;
        srI.sprite = spriteI;
        sr2.gameObject.SetActive(false);
        srI.gameObject.SetActive(false);
        sr1.gameObject.SetActive(true);
        lvl = 1;
    }

    void Update()
    {
        
        if (GameManager.instance.gameOver)
            return;

        if (GameManager.instance.totalCount == 7 && lvl != 2)
        {
            PetInfo.instance.stopWants = true;
            GetComponent<Animator>().enabled = true;
            GetComponent<Animator>().SetTrigger("Evolve");
            if (PetInfo.instance.hunger <= 0 || PetInfo.instance.fun <= 0 || PetInfo.instance.social <= 0 ||
                PetInfo.instance.education <= 0)
            {
                lvl = 2;
                WantsUI.instance.PopulateWant();
                //_evolving = true;
            }
            else
            {
                PetInfo.instance.stopWants = false;
            }
            
        }

    }
}
