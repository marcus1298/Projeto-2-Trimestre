using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GM : MonoBehaviour {

	// Use this for initialization
	public static GM instance = null;
	public float yMinLive = -10f;
	public Transform spawnPoit;
	public GameObject playerPrefab;
	public PlayerController player;

	public float timeToRespaw = 2f;


	void Awake(){
	if(instance == null){
		instance = this;
		}	
	}
	

	void Start () {
		if(player==null){
			RespawnPlayer();
		}
	}
	
	// Update is called once per frame
	void Update () {
		if(player == null){
			GameObject obj = GameObject.FindGameObjectWithTag("Player");
		if(obj != null){
			player = obj.GetComponent<PlayerController>();
		}		
		}
	}
	public void RespawnPlayer(){
		Instantiate(playerPrefab, spawnPoit.position, spawnPoit.rotation);
	}
	public void KillPlayer(){
		if(player!=null){
			Destroy(player.gameObject);
			Invoke("RespawnPlayer", timeToRespaw);
		}
	}
}
