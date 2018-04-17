using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityController : MonoBehaviour {
	// 重力加速度
	const float Gravity = 9.81f;

	// 重力の適用具合
	[SerializeField] float gravityScale = 1.0f;

	// Update is called once per frame
	void Update () {
		// 重力ベクトルの初期化
		Vector3 vector = new Vector3 ();

		// キー入力を検知してベクトル設定
		vector.x = Input.GetAxis ("Horizontal");
		vector.z = Input.GetAxis ("Vertical");

		// 高さ方向の判定はzキーで行う
		if (Input.GetKey ("z")) {
			vector.y = 1.0f;
		} else {
			vector.y = -1.0f;
		}

		// シーンの重力を入力ベクトルの方向に合わせて変化させる
		Physics.gravity = Gravity * vector.normalized * gravityScale;
	}
}
