using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalTrigger : MonoBehaviour 
{
   
    private void OnCollisionEnter(Collision collision) {
        Debug.Log("Goal");
    }
}
