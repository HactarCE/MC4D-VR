using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderScript : MonoBehaviour {

	public Text valueLabel;
	public float minValue;
	public float maxValue;
	public float defaultValue;

	public delegate float roundValue(float unrounded);
	public roundValue valueRounder = new roundValue (delegate(float unrounded) {
		return Mathf.Round (100 * unrounded) / 100;
	});

	// Use this for initialization
	void Start () {
		this.value = defaultValue;
		GetComponent<Slider> ().onValueChanged.AddListener (delegate(float arg0) {
			updateValueLabel ();
		});
	}

	public float value {
		get {
			return valueRounder(GetComponent<Slider> ().value * (maxValue - minValue) + minValue);
		}
		set {
			GetComponent<Slider> ().value = (value - minValue) / (maxValue - minValue);
			updateValueLabel ();
		}
	}

	public void updateValueLabel() {
		valueLabel.text = this.value.ToString();
	}

}
