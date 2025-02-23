using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player instance;
    public Sprite playerSprite, playerSprite2, playerSpriteIdle;
    public string highestAnswer;
    void Awake()
    {
        if(instance != null)
            Destroy(instance);
        instance = this;
        DontDestroyOnLoad(this);
    }
}
