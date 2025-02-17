using UnityEngine;

public class Pet : MonoBehaviour
{
    public static Pet instance;
    public float hunger, fun, social, education, tech, pop, enviroment, science, economy,pol, hungerMultiplyer, funMultiplyer, socialMultiplyer, educationMultiplyer;

    public int numberOfCorrect;

    void Awake()
    {
        if (instance != null)
        {
            Destroy(instance);
        }
        instance = this;
    }

    void Start()
    {
        hungerMultiplyer = Random.Range(0, .5f);
        funMultiplyer = Random.Range(0, .5f);
        socialMultiplyer = Random.Range(0, .5f);
        educationMultiplyer = Random.Range(0, .5f);
    }

    void Update()
    {
        if (ChoicesUI.instance.answeringQuestions)
            return;
        if (hunger >= 1f)
            hunger = 1f;

        if (fun >= 1f)
            fun = 1f;
        
        if(education >= 1f)
            education = 1f;
        
        if(social >= 1f)
            social = 1f;
        
        hunger -= (hungerMultiplyer * Time.deltaTime)/10;
        fun -= (funMultiplyer * Time.deltaTime)/10;
        education -= (educationMultiplyer * Time.deltaTime) / 10;
        social -= (socialMultiplyer * Time.deltaTime) / 10;
    }
}
