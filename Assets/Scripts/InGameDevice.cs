using UnityEngine;
using UnityEngine.UI;

public class InGameDevice : MonoBehaviour
{
    RaycastHit hit;
    [SerializeField] private LayerMask device, deviceButton;
    public AudioClip click;
    public AudioSource audioSource;

    void Update()
    {
        if (GameManager.instance.gameOver)
            return;
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, Mathf.Infinity, device))
            {
                Debug.Log("Device Found" + hit.collider.gameObject.name);
            }

            if (Physics.Raycast(ray, out hit, Mathf.Infinity, deviceButton))
            {
                hit.collider.GetComponent<Animator>().SetTrigger("Clicked");
                audioSource.PlayOneShot(click);
                if (hit.collider.GetComponent<ChoiceButtonInfo>() != null && PetInfo.instance.stopWants)
                {
                    hit.collider.GetComponent<ChoiceButtonInfo>().Selection();
                    
                }

                if (hit.collider.GetComponent<ConfirmButton>() != null && PetInfo.instance.stopWants)
                {
                    hit.collider.GetComponent<ConfirmButton>().Confirm();
                    GameManager.instance.totalCount++;
                }
            }
        }
    }
}
