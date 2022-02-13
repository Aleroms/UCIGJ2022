using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class OrderSystem : MonoBehaviour
{
	/*
	 ID 0 = jack and coke
	 ID 1 = vodka and cranberry
	 ID 2 = gin and juice
	*/

	//[SerializeField] private string currentOrder;
    [SerializeField] private Text currOrderTxt;
	private int currentOrder;

	private void Start()
	{
		currentOrder = Random.Range(0, 3);
		Debug.Log("Current order is " + currentOrder);
	}
	public int StartNextOrder()
	{
		//maybe insert crossout effect then remove before next order

		currentOrder = Random.Range(0, 3);
		Debug.Log("Current order is " + currentOrder);

		if (currentOrder == 0)      currOrderTxt.text = "Jack and Coke";
		else if(currentOrder == 1) currOrderTxt.text = "Vodka and Cranberry";
		else if(currentOrder == 2) currOrderTxt.text = "Gin and Juice";

		return currentOrder;
	}
}
