using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerScript : MonoBehaviour {
	public Transform[] waypoints;
	public Transform[] waypoints2;
	private bool forwards = true;
	private bool safe = false;
	private int cur = 0;
	private int cur2 = 0;
	public float speed = 0.3f;
	private int ButtonClicks = 0;
	public GameObject Player;
	public GameObject Board;
	public GameObject Circles;
	public GameObject GameoverScreen;
	public int score = 0;
	public int basis = 0;
	public Text scoreText;
	public Text gameoverText;

	public GameObject point1;
	public GameObject point2;
	public GameObject point3;
	public GameObject point4;
	public GameObject point5;
	public GameObject point6;
	public GameObject point7;
	public GameObject point8;
	public GameObject point9;
	public int randNumber;

	IEnumerator Wait(){
		yield return new WaitForSeconds (2.0f);
		Application.LoadLevel("game");
	}
	void Start () {
		Board.SetActive (true);
		Circles.SetActive (true);
		GameoverScreen.SetActive (false);
		gameoverText.text = "";
		randNumber = Random.Range (1, 9);
		point1.SetActive (false);
		point2.SetActive (false);
		point3.SetActive (false);
		point4.SetActive (false);
		point5.SetActive (false);
		point6.SetActive (false);
		point7.SetActive (false);
		point8.SetActive (false);
		point9.SetActive (false);
		if (randNumber == 1) {
			point1.SetActive (true);
		}if (randNumber == 2) {
			point2.SetActive (true);
		}if (randNumber == 3) {
			point3.SetActive (true);
		}if (randNumber == 4) {
			point4.SetActive (true);
		}if (randNumber == 5) {
			point5.SetActive (true);
		}if (randNumber == 6) {
			point6.SetActive (true);
		}if (randNumber == 7) {
			point7.SetActive (true);
		}if (randNumber == 8) {
			point8.SetActive (true);
		}if (randNumber == 9) {
			point9.SetActive (true);
		}
	}
	//destroy mario if collision occurs
	public void OnTriggerStay2D(Collider2D other) {
		safe = true;
	}
	public void OnTriggerExit2D(Collider2D other) {
		safe = false;
	}
	// Update is called once per frame
	void FixedUpdate () {
		if (ButtonClicks == 1) {
			speed = speed + .02f;
			ButtonClicks = 0;
		}
		//if waypoint not reached, move forward
		if (forwards == true) {
			if (transform.position != waypoints [cur].position) {
				Vector2 p = Vector2.MoveTowards (transform.position, waypoints [cur].position, speed);
				GetComponent<Rigidbody2D> ().MovePosition (p);
			}// if waypoint reached, select next one
			else {
				cur = (cur + 1) % waypoints.Length;
			}
		}if (forwards == false) {
			if (transform.position != waypoints2 [cur2].position) {
				Vector2 q = Vector2.MoveTowards (transform.position, waypoints2 [cur2].position, speed);
				GetComponent<Rigidbody2D> ().MovePosition (q);
			}// if waypoint reached, select next one
			else {
				cur2 = (cur2 + 1) % waypoints2.Length;
			}
		}
	}
	public void SwitchDirection() {
		if (safe == true) {
			ButtonClicks = ButtonClicks + 1;
			score = score + 1;
			if (forwards == true) {
				forwards = false;
				cur2 = basis - cur;
				if (score < 10) {
					scoreText.text = "00" + score.ToString ();
				}
				if (score > 10 && score < 100) {
					scoreText.text = "0" + score.ToString ();
				}
				if (score > 100) {
					scoreText.text = score.ToString ();
				}
				gameoverText.text = "";
				randNumber = Random.Range (1, 9);
				point1.SetActive (false);
				point2.SetActive (false);
				point3.SetActive (false);
				point4.SetActive (false);
				point5.SetActive (false);
				point6.SetActive (false);
				point7.SetActive (false);
				point8.SetActive (false);
				point9.SetActive (false);
				if (randNumber == 1) {
					point1.SetActive (true);
				}if (randNumber == 2) {
					point2.SetActive (true);
				}if (randNumber == 3) {
					point3.SetActive (true);
				}if (randNumber == 4) {
					point4.SetActive (true);
				}if (randNumber == 5) {
					point5.SetActive (true);
				}if (randNumber == 6) {
					point6.SetActive (true);
				}if (randNumber == 7) {
					point7.SetActive (true);
				}if (randNumber == 8) {
					point8.SetActive (true);
				}if (randNumber == 9) {
					point9.SetActive (true);
				}
			} else 
				forwards = true;
				cur = 36 - cur2;
				if (score < 10) {
					scoreText.text = "00" + score.ToString ();
				}
				if (score > 10 && score < 100) {
					scoreText.text = "0" + score.ToString ();
				}
				if (score > 100) {
					scoreText.text = score.ToString ();
				}
				gameoverText.text = "";
			randNumber = Random.Range (1, 9);
			point1.SetActive (false);
			point2.SetActive (false);
			point3.SetActive (false);
			point4.SetActive (false);
			point5.SetActive (false);
			point6.SetActive (false);
			point7.SetActive (false);
			point8.SetActive (false);
			point9.SetActive (false);
			if (randNumber == 1) {
				point1.SetActive (true);
			}if (randNumber == 2) {
				point2.SetActive (true);
			}if (randNumber == 3) {
				point3.SetActive (true);
			}if (randNumber == 4) {
				point4.SetActive (true);
			}if (randNumber == 5) {
				point5.SetActive (true);
			}if (randNumber == 6) {
				point6.SetActive (true);
			}if (randNumber == 7) {
				point7.SetActive (true);
			}if (randNumber == 8) {
				point8.SetActive (true);
			}if (randNumber == 9) {
				point9.SetActive (true);
			}
			safe = false;
		} else if (safe == false) {
			Destroy (Player);
			Board.SetActive (false);
			Circles.SetActive (false);
			GameoverScreen.SetActive (true);
			scoreText.text = "";
			gameoverText.text = "Your score: " + score.ToString ();
		}
	}
}