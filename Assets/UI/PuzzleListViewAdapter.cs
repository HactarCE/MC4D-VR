using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuzzleListViewAdapter : MonoBehaviour {

	public Button contentPrefab;

	// Use this for initialization
	void Start () {
		string[] puzzles = new string[] {
			"{3,3,3} Simplex",
			"{3}x{4} Triangular Duoprism",
			"{4,3,3} Hypercube",
			"{5}x{4} Pentagonal Duoprism",
			"{6}x{4} Hexagonal Duoprism",
			"{7}x{4} Heptagonal Duoprism",
			"{8}x{4} Octogonal Duoprism",
			"{9}x{4} Nonogonal Duoprism",
			"{10}x{4} Decagonal Duoprism",
			"{3}x{3}",
			"{3}x{5}",
			"{5}x{10}",
			"{5}x{5}",
			"{6}x{6}",
			"{7}x{7}",
			"{8}x{8}",
			"{9}x{9}",
			"{10}x{10}",
			"{5,3}x{} Dodecahedral Prism",
			"{5,3,3} Hypermegaminx (BIG!)",
			"Invent your own!"
		};
		foreach (string puzzle in puzzles) {
			Button newContentThing = Instantiate<Button> (contentPrefab, transform);
			Debug.Log (newContentThing);
			newContentThing.GetComponentInChildren<Text> ().text = " " + puzzle;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}

}
