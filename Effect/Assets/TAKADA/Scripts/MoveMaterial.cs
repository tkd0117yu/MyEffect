using UnityEngine;
using System.Collections;

public class MoveMaterial : MonoBehaviour
{
	public float spead = 0.5f;
	void Update()
	{
		float scroll = Mathf.Repeat(Time.time * spead, 1);
		Vector2 offset = new Vector2(0, scroll);
		GetComponent<Renderer>().sharedMaterial.SetTextureOffset("_MainTex", offset);
	}
}