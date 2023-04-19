using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirtuluGenerators : MonoBehaviour {
	public GameObject[] virtuluSagataves;
	public float laikaIntervals = 1.0f;
	float minPoz, maxPoz;
	Transform krasnsTransform;

	// Use this for initialization
	void Start () {
		krasnsTransform = GetComponent<Transform> ();

	}

	public void SagatavotVirtulus(bool stavoklis){
		if (stavoklis)
			StartCoroutine(Generet());

		else
			StopAllCoroutines();
	}

	IEnumerator Generet(){
		while(true)
		{
			minPoz = krasnsTransform.position.x - 20;
			maxPoz = krasnsTransform.position.x + 20;
			var cipars = Random.Range (minPoz, maxPoz);
			var pozicija = 
				new Vector2 (cipars, transform.position.y);
			GameObject virtulis = 
				Instantiate (virtuluSagataves [Random.Range (0, virtuluSagataves.Length)],
					pozicija, Quaternion.identity, krasnsTransform);


			yield return new WaitForSeconds (laikaIntervals);
		}
	}
}
