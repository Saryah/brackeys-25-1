using UnityEngine;
using UnityEngine.UI;

public class PetInfo : MonoBehaviour
{
    public static PetInfo instance;
    public float hunger, fun, social, education, hungerRate, funRate, socialRate, educationRate;
    public Slider hungerSlider, funSlider, socialSlider, educationSlider;
    public int multiplyer;
    public bool stopWants;

    void Awake()
    {
        if(instance != null)
            Destroy(instance);
        instance = this;
    }

    void Start()
    {
        hungerRate = Random.Range(0.5f, 1f);
        funRate = Random.Range(0.5f, 1f);
        socialRate = Random.Range(0.5f, 1f);
        educationRate = Random.Range(0.5f, 1f);
    }

    void Update()
    {
        if (GameManager.instance.gameOver)
            return;
        if (stopWants)
            return;
        hunger -= hungerRate * Time.deltaTime / multiplyer;
        fun -= funRate * Time.deltaTime / multiplyer;
        social -= socialRate * Time.deltaTime / multiplyer;
        education -= educationRate * Time.deltaTime / multiplyer;
        
        hungerSlider.value = hunger;
        funSlider.value = fun;
        socialSlider.value = social;
        educationSlider.value = education;
        if (hunger <= 0 || fun <= 0 || social <= 0 || education <= 0)
        {
            stopWants = true;
            WantsUI.instance.PopulateWant();
        }
            
    }
}
