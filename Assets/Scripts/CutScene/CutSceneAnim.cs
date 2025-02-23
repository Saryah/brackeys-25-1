using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CutSceneAnim : MonoBehaviour
{
    [SerializeField] private Animator charAnimator, deviceAnimator;
    [SerializeField] private GameObject character;
    [SerializeField] private Transform[] waypoints;
    [SerializeField] Transform target;
    [SerializeField] int currentWaypoint = 0;
    [SerializeField] float speed;
    [SerializeField] private float explosionWait, lookWait, pickUpWait;
    [SerializeField] private AnimationClip ecplodeAnim, coverEyesAnim, lookAnim;
    [SerializeField] private Vector3 dir;
    [SerializeField] bool stopMoving, isLanding, isPickingUp;

    void Start()
    {
        target = waypoints[currentWaypoint];
        //explosionWait = coverEyesAnim.length;
        //lookWait = lookAnim.length;
    }
    void Update()
    {
        if (stopMoving)
            return;
        MoveCharacter();
        
    }

    void MoveCharacter()
    {
        dir = target.position - character.transform.position;
        character.transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);
        
        if (Vector3.Distance(character.transform.position, target.position) < 0.2f)
        {
            stopMoving = true;
            if (currentWaypoint == 0 && stopMoving)
            {
                deviceAnimator.SetTrigger("Crash");
                StartCoroutine(Crash(explosionWait));
            }

            if (currentWaypoint == 1 && stopMoving)
            {
                StartCoroutine(PickUP(pickUpWait));
            }
                
        }
    }

    IEnumerator Crash(float wait)
    {
        yield return new WaitForSeconds(wait);
        charAnimator.SetTrigger("CoverEyes");
        StartCoroutine(Look());
    }

    IEnumerator Look()
    {
        yield return new WaitForSeconds(lookWait);
        speed = 5f;
        stopMoving = false;
        currentWaypoint++;
        target = waypoints[currentWaypoint];
        
    }

    IEnumerator PickUP(float wait)
    {
        yield return new WaitForSeconds(wait);
        charAnimator.SetTrigger("PickUp");
        SceneManager.LoadScene("Game");
    }
}
