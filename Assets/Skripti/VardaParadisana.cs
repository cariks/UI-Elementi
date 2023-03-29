using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VardaParadisana : MonoBehaviour {
	//Mainīgais, kurā ieglabās tekstu no input field
	private string teksts;
	private string[] varianti = {"Sveiks, ", "Labdien, ","Prieks Tevi redzēt, "};

	//Uzglabās noģenerēto random skaitli
	int nejausais;

	//Lauks, no kura ievada tekstu
	public GameObject ievadesLauks;

	//Text, kurā attēlos tekstu
	public GameObject tekstaAttelosana;

	public void UzglabatTekstu(){
		nejausais = Random.Range (0, varianti.Length);
		teksts = ievadesLauks.GetComponent<Text> ().text;
		tekstaAttelosana.GetComponent<Text> ().text = 
			varianti [nejausais] + teksts.ToUpper () + "!";
	}
}