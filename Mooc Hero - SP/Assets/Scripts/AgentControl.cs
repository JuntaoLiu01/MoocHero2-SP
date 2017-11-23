using UnityEngine;
using System.Collections;
using UnityEngine.AI;

public class AgentControl : MonoBehaviour {

	public Transform target;
	protected NavMeshAgent agent;

	void Start () {
		agent = GetComponent<NavMeshAgent>();	
	}


	void Update () {
		if (Input.GetButtonDown ("Fire1")) 
			SetDestination();
	}
	protected void SetDestination()
	{
		var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit = new RaycastHit();
		if (Physics.Raycast(ray, out hit))
		{
			target.position = hit.point;
			agent.destination = target.position;
		}
	}
}
