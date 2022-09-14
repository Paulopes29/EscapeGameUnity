using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.XR.Interaction.Toolkit;

public class EventTriggerSocket : MonoBehaviour
{	
	private ScoreManagement _scoreManager;

	void OnSelectEnter(XRBaseInteractable interactable)
	{
		Debug.Log("select enter");
	}

	public void OnEntered(SelectEnterEventArgs args)
	{
		_scoreManager = GameObject.Find("Canvas").GetComponent<ScoreManagement>();
		_scoreManager.AddRemovePoint(1);
	}

	public void OnExited(SelectExitEventArgs args)
	{
		_scoreManager = GameObject.Find("Canvas").GetComponent<ScoreManagement>();
		_scoreManager.AddRemovePoint(-1);
	}	
}
