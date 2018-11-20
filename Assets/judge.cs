using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class judge : MonoBehaviour {

	public GameObject p1_gu;
	public GameObject p1_choki;
	public GameObject p1_pa;
	public GameObject p2_gu;
	public GameObject p2_choki;
	public GameObject p2_pa;
	public Text text;
	public GameObject win_effect;
	public GameObject lose_effect;



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnClick(){
		Renderer ren_p1_gu = p1_gu.GetComponent<Renderer>();
		Renderer ren_p1_choki = p1_choki.GetComponent<Renderer>();
		Renderer ren_p1_pa = p1_pa.GetComponent<Renderer>();
		Renderer ren_p2_gu = p2_gu.GetComponent<Renderer>();
		Renderer ren_p2_choki = p2_choki.GetComponent<Renderer>();
		Renderer ren_p2_pa = p2_pa.GetComponent<Renderer>();

		string p1_card = "";
		string p2_card = "";

		if (ren_p1_gu.enabled == true) {
			p1_card = "gu";
		}

		if (ren_p1_choki.enabled == true) {
			p1_card = "choki";
		}

		if (ren_p1_pa.enabled == true) {
			p1_card = "pa";
		}

		if (ren_p2_gu.enabled == true) {
			p2_card = "gu";
		}

		if (ren_p2_choki.enabled == true) {
			p2_card = "choki";
		}

		if (ren_p2_pa.enabled == true) {
			p2_card = "pa";
		}

		//judg
		switch (p1_card){
		case "gu":
			if( p2_card == "gu"){
				//even
				text.text = "EVEN";
			} else if (p2_card == "choki"){
				//won
				text.text = "won";
				Instantiate (win_effect, p1_gu.transform.position, p1_gu.transform.rotation);
				Instantiate (lose_effect,p2_choki.transform.position, p2_choki.transform.rotation);
			} else if (p2_card == "pa"){
				//loose
				text.text = "lose";
				Instantiate (win_effect, p2_pa.transform.position, p2_pa.transform.rotation);
				Instantiate (lose_effect,p1_gu.transform.position, p1_gu.transform.rotation);
			}
			break;
		case "choki":
			if (p2_card == "choki"){
				//even
				text.text = "EVEN";
			}else if (p2_card == "pa"){
				//won
				text.text = "WON";
				Instantiate (win_effect, p1_choki.transform.position, p1_choki.transform.rotation);
				Instantiate (lose_effect,p2_pa.transform.position, p2_pa.transform.rotation);
			}else if (p2_card == "gu"){
				//lose
				text.text = "LOSE";
				Instantiate (win_effect, p2_gu.transform.position, p2_gu.transform.rotation);
				Instantiate (lose_effect,p1_choki.transform.position, p1_choki.transform.rotation);
			}
			break;
		case "pa":
			if (p2_card == "pa"){
				//even
				text.text = "EVEN";
			}else if (p2_card == "gu"){
				//won
				text.text = "WON";
				Instantiate (win_effect, p1_pa.transform.position, p1_pa.transform.rotation);
				Instantiate (lose_effect,p2_gu.transform.position, p2_gu.transform.rotation);
				}else if (p2_card == "choki"){
				//loose
				text.text = "LOSE";
				Instantiate (win_effect, p2_choki.transform.position, p2_choki.transform.rotation);
				Instantiate (lose_effect,p1_pa.transform.position, p1_pa.transform.rotation);
			}
			break;
		}

	}
}
