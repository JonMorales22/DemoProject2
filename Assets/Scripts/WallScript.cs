using UnityEngine;
using System.Collections;

public class WallScript : MonoBehaviour {
	public GameObject player;
	private PlayerController script;
	void Start(){
		player.GetComponent<PlayerController> ();
	}
	/*
	public void OnCollisionEnter2D(Collision2D c){
		if(c.gameObject.tag == "Player")
			Debug.Log ("Collide");
		//script.Idle ();
	}*/
}
