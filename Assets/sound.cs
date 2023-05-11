using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sound : MonoBehaviour
{
   public AudioSource audioSource;
      private void Awake()
     {
         audioSource = GetComponent<AudioSource>();
     }
  
           void OnCollisionEnter ()  //Plays Sound Whenever collision detected
     {
          audioSource.Play();
     }
      
          
}
