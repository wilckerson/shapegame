using UnityEngine;
using System.Collections;

public enum ShapeEnum{
	Circle = 0,
	Triangle = 1,
	Square = 2,
	Rectangle = 3,
	Arc = 4,
	Elipse = 5,
	Parallelogran = 6,
	Pentagon=7,
	Hexagon=8,
	Line=9,
	Moon = 10,
	TriangleRec=11
}

public class ShapeInfo : MonoBehaviour {

	public ShapeEnum[] Info;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
