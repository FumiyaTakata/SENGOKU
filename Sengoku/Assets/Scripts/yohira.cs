using UnityEngine;
using System.Collections;

public class yohira : Token {

	// Use this for initialization
	void Start () {
		SetSize(SpriteWidth / 2, SpriteHeight / 2);
		float dir = Random.Range (0, 359);
		float spd = 2;
		SetVelocity (dir, spd);
	}
	
	// Update is called once per frame
	void Update () {
		// カメラの左下座標を取得
		Vector2 min = GetWorldMin();
		// カメラの右上座標を取得する
		Vector2 max = GetWorldMax();

		if (X < min.x || max.x < X)
		{
			// 画面外に出たので、X移動量を反転する
			VX *= -1;
			// 画面内に移動する
			ClampScreen();
		}
		if (Y < min.y || max.y < Y)
		{
			// 画面外に出たので、Y移動量を反転する
			VY *= -1;
			// 画面内に移動する
			ClampScreen();
		}
	}

	public void OnMouseDown()
	{

		DestroyObj ();
	}
}
