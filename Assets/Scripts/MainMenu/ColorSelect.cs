using TMPro;
using UnityEngine;

public class ColorSelect : MonoBehaviour
{
    public static ColorSelect instance;
    public Color[] colors;
    public string[] colorNames;
    public int pageIndex;
    public Color activeColor;
    public Material deviceMat;
    public TMP_Text[] choices; 

    void Awake()
    {
        if (instance != null)
            Destroy(instance);
        instance = this;
    }
    void Update()
    {
        deviceMat.color = activeColor;
    }

    public void SelectColor(int index)
    {
        activeColor = colors[index];
    }

    public void PreviousPage()
    {
        if (pageIndex <= 0)
        {
            MainMenu.instance.inColorSelect = false;
            MainMenu.instance.inMainMenu = true;
            return;
        }
        pageIndex--;
        UpdateColors();
        
    }

    public void NextPage()
    {
        if (pageIndex >= 4)
            return;
        pageIndex++;
        UpdateColors();
    }

    public void UpdateColors()
    {
        for (int i = 0; i < choices.Length; i++)
        {
            choices[i].text = colorNames[pageIndex*4+i];
        }
    }
}
