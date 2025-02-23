using UnityEngine;
using UnityEngine.UI;

public class CharacterSelect : MonoBehaviour
{
    public static CharacterSelect instance;
    public Sprite[] sprites, spritesLvl2, idleSprites;
    public Sprite selectedSprite, selectedSpritelvl2, idleSprite;
    public Image selectedImage;

    void Awake()
    {
        if(instance != null)
            Destroy(instance);
        instance = this;
    }
    public void SelectCharacter(int index)
    {
        selectedSprite = sprites[index - 1];
        selectedSpritelvl2 = spritesLvl2[index - 1];
        idleSprite = idleSprites[index - 1];
        selectedImage.sprite = selectedSprite;
    }
}
