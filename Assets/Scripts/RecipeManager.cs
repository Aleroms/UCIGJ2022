using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecipeManager : MonoBehaviour
{
    [SerializeField] private bool cranberry, oj, coke;
	[SerializeField] private bool JackDaniels, Vodka, Gin;

	/*
	 ID 0 = jack and coke
	 ID 1 = vodka and cranberry
	 ID 2 = gin and juice
	*/
    public bool IsOrderCorrect(int alcoholID, int chaserID)
	{
		if (alcoholID == 0 && chaserID == 5 && GameManager.Instance.GetCurrentOrder() == 0) return true;
		else if (alcoholID == 1 && chaserID == 4 && GameManager.Instance.GetCurrentOrder() == 1) return true;
		else if (alcoholID == 2 && chaserID == 3 && GameManager.Instance.GetCurrentOrder() == 2) return true;

		return false;
	}
}
