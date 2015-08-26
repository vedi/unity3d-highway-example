using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour {

	public Text ResultText;

	// Use this for initialization
	void Start () {
//		ProfileEvents.OnSoomlaProfileInitialized += delegate() {
//			Debug.Log("OnSoomlaProfileInitialized");
//		};
//		SoomlaProfile.Initialize();
	}
	
	public void OnSync() {
        ResultText.text = "OnSync";
	}

	public void OnLeaderboards() {
        ResultText.text = "OnLeaderboards";
    }

	public void OnGifting() {
        ResultText.text = "OnGifting";
    }

	public void OnInsights() {
        ResultText.text = "OnInsights";
    }
}
