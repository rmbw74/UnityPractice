using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByBoundry : MonoBehaviour 
{
	void OnTriggerExit(Collider other)
	{
		//destroy everything that leaves the trigger
		Destroy(other.gameObject);
	}
}
