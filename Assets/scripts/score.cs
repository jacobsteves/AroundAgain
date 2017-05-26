using UnityEngine;
using System.Collections;

public class score : MonoBehaviour {
	public GameObject Colour1;
	public GameObject Colour2;
	public GameObject Colour3;
	public GameObject Colour4;
	public GameObject Colour5;
	public GameObject Colour6;
	public GameObject Colour7;
	public GameObject Colour8;
	public GameObject Colour9;
	public int number;

	// Use this for initialization
	void Start () {
		CreateBackgound ();
	}
	public void CreateBackgound () {
		number = Random.Range (1, 9);
		Colour1.SetActive (false);
		Colour2.SetActive (false);
		Colour3.SetActive (false);
		Colour4.SetActive (false);
		Colour5.SetActive (false);
		Colour6.SetActive (false);
		Colour7.SetActive (false);
		Colour8.SetActive (false);
		Colour9.SetActive (false);
		if (number == 1) {
			Colour1.SetActive (true);
		}if (number == 2) {
			Colour2.SetActive (true);
		}if (number == 3) {
			Colour3.SetActive (true);
		}if (number == 4) {
			Colour4.SetActive (true);
		}if (number == 5) {
			Colour5.SetActive (true);
		}if (number == 6) {
			Colour6.SetActive (true);
		}if (number == 7) {
			Colour7.SetActive (true);
		}if (number == 8) {
			Colour8.SetActive (true);
		}if (number == 9) {
			Colour9.SetActive (true);
		}
	}
	// Update is called once per frame
	public void Restart () {
		Application.LoadLevel("game");
	}
}
