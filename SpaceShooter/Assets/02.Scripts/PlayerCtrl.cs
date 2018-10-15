using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour {

	private float h = 0.0f;
	private float v = 0.0f;

	// 접근 해야 하는 컴포넌트는 반드시 변수에 할당한 후 사용
	private Transform tr;

	//이동 속도 변수
	public float moveSpeed = 10.0f;

	// Use this for initialization
	void Start () {
		//스크립트가 실행된 후 처음 수행되는 Start 함수에서  Transform 컴포넌트를 할당
		tr = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
		h = Input.GetAxis ("Horizontal");
		v = Input.GetAxis ("Vertical");

		Debug.Log ("h=" + h.ToString());
		Debug.Log ("v=" + v.ToString());

		//Tanslate(이동 방향 * 속도 * 변위값 * Time.deltaTime, 기준 좌표)
		tr.Translate(Vector3.forward * moveSpeed * v * Time.deltaTime, Space.Self);

	}
}
