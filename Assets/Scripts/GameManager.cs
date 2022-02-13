using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
	public bool pause = false;

	[SerializeField] private GameObject pausePanel;
	[SerializeField] private TextMeshProUGUI tipsTxt;

	private OrderSystem orderSystem;
	private int tips;
	private int currentOrderNum;

	private void Awake()
	{
		if(Instance == null)
		{
			Instance = this;
		}
		else
		{
			Destroy(gameObject);
			return;
		}
	}

	private void Start()
	{
		orderSystem = GameObject.Find("Canvas").GetComponent<OrderSystem>();
		currentOrderNum = orderSystem.StartNextOrder();
		tips = 0;
	}
	private void Update()
	{
		if(Input.GetKeyDown(KeyCode.P))
		{
			if(!pause)
			{
				Pause();
			}
			else
			{
				Resume();
			}
		}
	}
	public void Pause()
	{
		pause = true;
		pausePanel.SetActive(true);
	}
	public void Resume()
	{
		pause = false;
		pausePanel.SetActive(false);
	}
	public void Quit()
	{
		Application.Quit();
	}
	public void RewardPlayer()
	{
		int t = Random.Range(6, 12);

		tips += t;
		tipsTxt.text = "Tip   $" + tips;

		currentOrderNum = orderSystem.StartNextOrder();
	}
	public int GetCurrentOrder()
	{
		return currentOrderNum;
	}
}
