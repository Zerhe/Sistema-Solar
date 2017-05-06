using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TraslacionLuna : MonoBehaviour {
    public float velTraslacion = 0.5f;
    void Start () {
		
	}
	void Update () {
        transform.RotateAround(PosicionTierra.posTierra, Vector3.up, velTraslacion);
    }
}
