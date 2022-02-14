using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishGame : MonoBehaviour
{
    public HorseMovementManager horse;
    public PauseMenu pause;

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player" && horse.Cheater)
        {
            pause.FinishedGame();
        }
    }
}
