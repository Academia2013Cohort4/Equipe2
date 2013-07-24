using UnityEngine;
using System.Collections;

public class GameMaster : MonoBehaviour {
	public GameObject playerCharacter;
	public Camera mainCamera;
	
	public float zOffset;
	public float yOffset;
	public float xRotOffset;
	
	private GameObject _pc;

	// Use this for initialization
	void Start () {
		_pc = Instantiate(playerCharacter, Vector3.zero, Quaternion.identity) as GameObject;
		
		zOffset = -2.5f;
		yOffset = 2.5f;
		xRotOffset = 22.5f;
		
		mainCamera.transform.position = new Vector3(_pc.transform.position.x, _pc.transform.position.y + yOffset, _pc.transform.position.z + zOffset);
		mainCamera.transform.Rotate(xRotOffset, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
