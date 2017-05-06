using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotacion : MonoBehaviour {
    public float velRotacion = 0.5f;
	void Start () {

	}
	void Update () {
        transform.RotateAround(transform.position, Vector3.up, velRotacion);
	}
}
