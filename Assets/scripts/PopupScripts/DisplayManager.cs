﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;




public class DisplayManager : MonoBehaviour {

       // public float displayTime; 
	    //public Text displayText;
		//public float fadeTime;
		//private IEnumerator fadeAlpha;

		private static DisplayManager displayManager;

         public static DisplayManager Instance () {

		if (!displayManager) {
		
			displayManager = FindObjectOfType (typeof(DisplayManager)) as DisplayManager;
			if (!displayManager)
				Debug.LogError ("There needs to be one active DisplayManager script on a GameObject in your scene.");

		}

         return displayManager;       

    }

	/*public void DisplayMessage (string message) {
         displayText.text = message;  

		//SetAlpha ();
	
	}  */
     
	/*void SetAlpha () {   
		if (fadeAlpha != null) {
			StopCoroutine (fadeAlpha);  }    

         fadeAlpha = FadeAlpha ();       

         StartCoroutine (fadeAlpha);
	}  

     IEnumerator FadeAlpha () {   
		Color resetColor = displayText.color;
          resetColor.a = 1;  
		 
          displayText.color = resetColor;
          yield return new WaitForSeconds (displayTime);
		   
		  while (displayText.color.a > 0) {
			Color displayColor = displayText.color;
             displayText.color = displayColor; 
			  displayColor.a -= Time.deltaTime / fadeTime;
			yield return null;
         }       

		yield return null;

     }      */

} 