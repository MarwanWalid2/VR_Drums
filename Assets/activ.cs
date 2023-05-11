using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activ : MonoBehaviour
{
         public float num;

   void Start() {
         StartCoroutine(ActivateRoutine());
    }
    private IEnumerator ActivateRoutine() {
       yield return new WaitForSeconds(num * 60.0f);    // and now we wait !
     
        // make a list of all children
        Transform[] ChildrenTransforms = this.gameObject.GetComponentsInChildren<Transform>(false);
        foreach( Transform t in ChildrenTransforms)
            t.gameObject.SetActive (false);      
   
    }
}
