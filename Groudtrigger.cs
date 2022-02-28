using UnityEngine;
using System.Collections;

public class Groudtrigger : MonoBehaviour
{
	GameObject bg;

	void Start()
	{
		bg = new GameObject();
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Player"))
		{
			
				bg = GameObject.FindGameObjectWithTag("groud1");
				bg.transform.position = new Vector3(0, 0, bg.transform.position.z + 300);

		}
	}
}





