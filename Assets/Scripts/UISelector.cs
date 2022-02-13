using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UISelector : MonoBehaviour
{
	[SerializeField] private Color[] drinkColor;
	[SerializeField] private Image alcohol, chaser;
	private RecipeManager recipe;
	private int alcoholID, chaserID;

	private void Start()
	{
		recipe = GameObject.Find("RecipeManager").GetComponent<RecipeManager>();
	}
	private void ResetColors()
	{
		alcohol.color = Color.white;
		chaser.color = Color.white;
	}


	public void AddAlcohol(int aID)
	{
		Debug.Log(aID);

		alcoholID = aID;
		alcohol.color = drinkColor[aID];
	}
	public void AddChaser(int cID)
	{
		Debug.Log(cID);

		chaserID = cID;
		chaser.color = drinkColor[cID];
	}

	public void Submit()
	{
		if(recipe.IsOrderCorrect(alcoholID,chaserID))
		{
			
			Debug.Log("correct");
			GameManager.Instance.RewardPlayer();
			ResetColors();
		}
		else
		{
			Debug.Log("not correct");
			
		}
	}
}
