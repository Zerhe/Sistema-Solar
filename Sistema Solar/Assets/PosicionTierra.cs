using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PosicionTierra : MonoBehaviour {
    static public Vector3 posTierra;
	void Start () {
        posTierra = transform.position;
    }
	void Update () {
        posTierra = transform.position;
    }
}
