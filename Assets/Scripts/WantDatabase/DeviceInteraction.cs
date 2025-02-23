using UnityEngine;

public class DeviceInteraction : MonoBehaviour
{
    public static DeviceInteraction instance;
    [Header("Questions")]
    [Space(10)]
    public Questions[] hungerQuestions;
    public Questions[] socialQuestions;
    public Questions[] funQuestions;
    public Questions[] educationQuestions;
    [Space(10)]
    [Header("Responces")]
    [Space(10)]
    public Answers[] hungerTechResponse;
    public Answers[] hungerPopResponse;
    public Answers[] hungerPolResponse;
    public Answers[] hungerEnviroResponse;
    public Answers[] hungerEconResponse;
    public Answers[] hungerScienceResponse;
    public Answers[] funTechResponse;
    public Answers[] funPopResponse;
    public Answers[] funPolResponse;
    public Answers[] funEnviroResponse;
    public Answers[] funEconResponse;
    public Answers[] funScienceResponse;
    public Answers[] socialTechResponse;
    public Answers[] socialPopResponse;
    public Answers[] socialPolResponse;
    public Answers[] socialEnviroResponse;
    public Answers[] socialEconResponse;
    public Answers[] socialScienceResponse;
    public Answers[] educationTechResponse;
    public Answers[] educationPopResponse;
    public Answers[] educationPolResponse;
    public Answers[] educationEnviroResponse;
    public Answers[] educationEconResponse;
    public Answers[] educationScienceResponse;

    void Awake()
    {
        if(instance != null)
            Destroy(instance);
        instance = this;
        
        LoadEducationQuestions();
        LoadFunQuestions();
        LoadHungerQuestions();
        LoadSocialQuestions();
        LoadHungerEconAnswers();
        LoadHungerPopAnswers();
        LoadHungerPolAnswers();
        LoadHungerEnviroAnswers();
        LoadHungerScienceAnswers();
        LoadHungerTechAnswers();
        LoadSocialEconAnswers();
        LoadSocialEnviroAnswers();
        LoadSocialPopAnswers();
        LoadSocialPolAnswers();
        LoadSocialTechAnswers();
        LoadSocialScienceAnswers();
        LoadEducationEconAnswers();
        LoadEducationPopAnswers();
        LoadEducationPolAnswers();
        LoadEducationEnviroAnswers();
        LoadEducationScienceAnswers();
        LoadEducationTechAnswers();
        LoadFunEconAnswers();
        LoadFunPopAnswers();
        LoadFunPolAnswers();
        LoadFunEnviroAnswers();
        LoadFunScienceAnswers();
        LoadFunTechAnswers();
    }

    void Start()
    {
        
    }

    void LoadHungerQuestions()
    {
        Questions[] q = Resources.LoadAll<Questions>("Questions/Hunger");
        
        hungerQuestions = new Questions[q.Length];

        for (int i = 0; i < q.Length; i++)
        {
            hungerQuestions[i] = q[i];
        }
    }

    void LoadSocialQuestions()
    {
        Questions[] q = Resources.LoadAll<Questions>("Questions/Social");
        
        socialQuestions = new Questions[q.Length];

        for (int i = 0; i < q.Length; i++)
        {
            socialQuestions[i] = q[i];
        }
    }

    void LoadFunQuestions()
    {
        Questions[] q = Resources.LoadAll<Questions>("Questions/Fun");
        
        funQuestions = new Questions[q.Length];

        for (int i = 0; i < q.Length; i++)
        {
            funQuestions[i] = q[i];
        }
    }
    void LoadEducationQuestions()
    {
        Questions[] q = Resources.LoadAll<Questions>("Questions/Fun");
        
        educationQuestions = new Questions[q.Length];

        for (int i = 0; i < q.Length; i++)
        {
            educationQuestions[i] = q[i];
        }
    }

    void LoadHungerTechAnswers()
    {
        Answers[] a = Resources.LoadAll<Answers>("Answers/Hunger/Technology");
        
        hungerTechResponse = new Answers[a.Length];

        for (int i = 0; i < a.Length; i++)
        {
            hungerTechResponse[i] = a[i];
        }
    }
    void LoadHungerPopAnswers()
    {
        Answers[] a = Resources.LoadAll<Answers>("Answers/Hunger/Pop");
        
        hungerPopResponse = new Answers[a.Length];

        for (int i = 0; i < a.Length; i++)
        {
            hungerPopResponse[i] = a[i];
        }
    }
    void LoadHungerPolAnswers()
    {
        Answers[] a = Resources.LoadAll<Answers>("Answers/Hunger/Pol");
        
        hungerPolResponse = new Answers[a.Length];

        for (int i = 0; i < a.Length; i++)
        {
            hungerPolResponse[i] = a[i];
        }
    }
    void LoadHungerEconAnswers()
    {
        Answers[] a = Resources.LoadAll<Answers>("Answers/Hunger/Eco");
        
        hungerEconResponse = new Answers[a.Length];

        for (int i = 0; i < a.Length; i++)
        {
            hungerEconResponse[i] = a[i];
        }
    }
    void LoadHungerEnviroAnswers()
    {
        Answers[] a = Resources.LoadAll<Answers>("Answers/Hunger/Env");
        
        hungerEnviroResponse = new Answers[a.Length];

        for (int i = 0; i < a.Length; i++)
        {
            hungerEnviroResponse[i] = a[i];
        }
    }
    void LoadHungerScienceAnswers()
    {
        Answers[] a = Resources.LoadAll<Answers>("Answers/Hunger/Sci");
        
        hungerScienceResponse = new Answers[a.Length];

        for (int i = 0; i < a.Length; i++)
        {
            hungerScienceResponse[i] = a[i];
        }
    }
    void LoadEducationTechAnswers()
    {
        Answers[] a = Resources.LoadAll<Answers>("Answers/Education/Technology");
        
        educationTechResponse = new Answers[a.Length];

        for (int i = 0; i < a.Length; i++)
        {
            educationTechResponse[i] = a[i];
        }
    }
    void LoadEducationPopAnswers()
    {
        Answers[] a = Resources.LoadAll<Answers>("Answers/Education/Pop");
        
        educationPopResponse = new Answers[a.Length];

        for (int i = 0; i < a.Length; i++)
        {
            educationPopResponse[i] = a[i];
        }
    }
    void LoadEducationPolAnswers()
    {
        Answers[] a = Resources.LoadAll<Answers>("Answers/Education/Pol");
        
        educationPolResponse = new Answers[a.Length];

        for (int i = 0; i < a.Length; i++)
        {
            educationPolResponse[i] = a[i];
        }
    }
    void LoadEducationEconAnswers()
    {
        Answers[] a = Resources.LoadAll<Answers>("Answers/Education/Eco");
        
        educationEconResponse = new Answers[a.Length];

        for (int i = 0; i < a.Length; i++)
        {
            educationEconResponse[i] = a[i];
        }
    }
    void LoadEducationEnviroAnswers()
    {
        Answers[] a = Resources.LoadAll<Answers>("Answers/Education/Env");
        
        educationEnviroResponse = new Answers[a.Length];

        for (int i = 0; i < a.Length; i++)
        {
            educationEnviroResponse[i] = a[i];
        }
    }
    void LoadEducationScienceAnswers()
    {
        Answers[] a = Resources.LoadAll<Answers>("Answers/Education/Sci");
        
        educationScienceResponse = new Answers[a.Length];

        for (int i = 0; i < a.Length; i++)
        {
            educationScienceResponse[i] = a[i];
        }
    }
    void LoadSocialTechAnswers()
    {
        Answers[] a = Resources.LoadAll<Answers>("Answers/Social/Technology");
        
        socialTechResponse = new Answers[a.Length];

        for (int i = 0; i < a.Length; i++)
        {
            socialTechResponse[i] = a[i];
        }
    }
    void LoadSocialPopAnswers()
    {
        Answers[] a = Resources.LoadAll<Answers>("Answers/Social/Pop");
        
        socialPopResponse = new Answers[a.Length];

        for (int i = 0; i < a.Length; i++)
        {
            socialPopResponse[i] = a[i];
        }
    }
    void LoadSocialPolAnswers()
    {
        Answers[] a = Resources.LoadAll<Answers>("Answers/Social/Pol");
        
        socialPolResponse = new Answers[a.Length];

        for (int i = 0; i < a.Length; i++)
        {
            socialPolResponse[i] = a[i];
        }
    }
    void LoadSocialEconAnswers()
    {
        Answers[] a = Resources.LoadAll<Answers>("Answers/Social/Eco");
        
        socialEconResponse = new Answers[a.Length];

        for (int i = 0; i < a.Length; i++)
        {
            socialEconResponse[i] = a[i];
        }
    }
    void LoadSocialEnviroAnswers()
    {
        Answers[] a = Resources.LoadAll<Answers>("Answers/Social/Env");
        
        socialEnviroResponse = new Answers[a.Length];

        for (int i = 0; i < a.Length; i++)
        {
            socialEnviroResponse[i] = a[i];
        }
    }
    void LoadSocialScienceAnswers()
    {
        Answers[] a = Resources.LoadAll<Answers>("Answers/Social/Sci");
        
        socialScienceResponse = new Answers[a.Length];

        for (int i = 0; i < a.Length; i++)
        {
            socialScienceResponse[i] = a[i];
        }
    }
    void LoadFunTechAnswers()
    {
        Answers[] a = Resources.LoadAll<Answers>("Answers/Fun/Technology");
        
        funTechResponse = new Answers[a.Length];

        for (int i = 0; i < a.Length; i++)
        {
            funTechResponse[i] = a[i];
        }
    }
    void LoadFunPopAnswers()
    {
        Answers[] a = Resources.LoadAll<Answers>("Answers/Fun/Pop");
        
        funPopResponse = new Answers[a.Length];

        for (int i = 0; i < a.Length; i++)
        {
            funPopResponse[i] = a[i];
        }
    }
    void LoadFunPolAnswers()
    {
        Answers[] a = Resources.LoadAll<Answers>("Answers/Fun/Pol");
        
        funPolResponse = new Answers[a.Length];

        for (int i = 0; i < a.Length; i++)
        {
            funPolResponse[i] = a[i];
        }
    }
    void LoadFunEconAnswers()
    {
        Answers[] a = Resources.LoadAll<Answers>("Answers/Fun/Eco");
        
        funEconResponse = new Answers[a.Length];

        for (int i = 0; i < a.Length; i++)
        {
            funEconResponse[i] = a[i];
        }
    }
    void LoadFunEnviroAnswers()
    {
        Answers[] a = Resources.LoadAll<Answers>("Answers/Fun/Env");
        
        funEnviroResponse = new Answers[a.Length];

        for (int i = 0; i < a.Length; i++)
        {
            funEnviroResponse[i] = a[i];
        }
    }
    void LoadFunScienceAnswers()
    {
        Answers[] a = Resources.LoadAll<Answers>("Answers/Fun/Sci");
        
        funScienceResponse = new Answers[a.Length];

        for (int i = 0; i < a.Length; i++)
        {
            funScienceResponse[i] = a[i];
        }
    }
    
}
