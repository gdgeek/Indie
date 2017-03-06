using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour {
	private GameInterface gameInterface_ = null;
	// Use this for initialization
	void Awake () {
		gameInterface_ = this.GetComponentInParent<GameInterface> ();
	}	
	void Start () {
		//int id = gameInterface_.createPeople("name");
		//gameInterface_.move (id, "door");
	}

}
