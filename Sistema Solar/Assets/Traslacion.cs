using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Traslacion : MonoBehaviour {
    public float velTraslacion = 0.5f;
    void Start () {

	}
	void Update () {
		transform.RotateAround(Vector3.zero, Vector3.up,velTraslacion);
	}
}
