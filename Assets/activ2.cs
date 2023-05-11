using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activ2 : MonoBehaviour
{
     public GameObject objectToActivate;
     public float num;
     void Start() {
        
         StartCoroutine(ActivateRoutine());
    }
    private IEnumerator ActivateRoutine() {
       yield return new WaitForSeconds(num * 60.0f);    // and now we wait !
     
        // make a list of all children
        objectToActivate.SetActive (true);
    //     Transform[] ChildrenTransforms = this.objectToActivate.GetComponentsInChildren<Transform>(true);
    //     foreach( Transform t in ChildrenTransforms)
    //         t.gameObject.SetActive (true);      
   
     }
}
