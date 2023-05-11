using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pos : MonoBehaviour
{
    public GameObject gameObjectToMove;
    public float x= -10f;
       public float y= 0.5f;

    public float z= 20f;

   
    // Start is called before the first frame update
    
         public float num;

   void Start() {
         StartCoroutine(ActivateRoutine());
    }
    private IEnumerator ActivateRoutine() {
       yield return new WaitForSeconds(num * 60.0f);    // and now we wait !
     
        // make a list of all children
           gameObjectToMove.transform.position = new Vector3(x, y,z);

    }
}
