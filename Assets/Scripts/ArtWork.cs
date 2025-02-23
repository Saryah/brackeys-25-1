using UnityEngine;

public class ArtWork : MonoBehaviour
{
    [SerializeField] private Material material;
    [SerializeField] private Texture[] prints;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int rand = Random.Range(0, prints.Length);
        material.mainTexture = prints[rand];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
