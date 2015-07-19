using UnityEngine;
using System.Collections;

public class ShapeButton_OnChange : GameEvent{
	private ShapeEnum value;
	private bool pressed;
	public ShapeButton_OnChange(ShapeEnum value, bool pressed){
	}
}

public class ShapeButton : MonoBehaviour {

	public ShapeEnum Value;
	bool pressed = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnMouseDown()
	{
		pressed = !pressed;

		var spriteRender = GetComponent<SpriteRenderer> ();
		
		spriteRender.color = new Color (
			spriteRender.color.r,
			spriteRender.color.g,
			spriteRender.color.b,
			(pressed ? 0.5f : 1));

		Events.instance.Raise (new ShapeButton_OnChange (Value,pressed));
	}


}
