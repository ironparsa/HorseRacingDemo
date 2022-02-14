using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorseMovementManager : MonoBehaviour
{
    private float baseSpeed = 4f;
    public int SpeedUpModify = 1;
    public bool Cheater;
    public float speedWeight;

    public float HorsePounds;
    public float HorseAge;
    public float HorseHeight;
    
    void Start()
    {
        HorsePounds = Random.Range(1f,4f);
        HorseAge = Random.Range(1f,4f);
        HorseHeight = Random.Range(1f,4f);
    }
    
    void FixedUpdate()
    {
        speedWeight = (baseSpeed * (HorsePounds + HorseAge + HorseHeight));
        //MoveHorse(SpeedUpModify);
        StartCoroutine(MoveHorse(SpeedUpModify));
    }

    //public void MoveHorse(int modifier)
    // do action over time
    IEnumerator MoveHorse(int modifier)
    {
        CharacterController controller = GetComponent<CharacterController>();

        Vector3 forward = transform.TransformDirection(Vector3.forward);
        
        // Cheater puts horse's stats to max for max speed
        if(Cheater == true)
        {
            HorsePounds = 4.1f;
            HorseAge = 4.1f;
            HorseHeight = 4.1f;
        }
        controller.SimpleMove(forward * speedWeight * SpeedUpModify);
        yield return null;
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Speedup" && Cheater)
        {
            SpeedUpModify = 2;
            Debug.Log(SpeedUpModify);
        }
    }
}