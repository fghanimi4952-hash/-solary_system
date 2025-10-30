using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeLook : MonoBehaviour
{
    //Declare a game object variable which defines the target  where the camera should look at
    public GameObject target;

    void Start()
    {
        if (target == null) {
            target = this.gameObject;
            Debug.Log("Change look target is not specified. Defaulting to parent object .");
        }
    }

    private void OnMouseDown()
    {
        //Assign the target variable of LookAt script to the target defined in this script
        LookAt.target = target;
        Camera.main.fieldOfView = Mathf.Clamp(60 * target.transform.localScale.x, 10 ,100);
    }
}
