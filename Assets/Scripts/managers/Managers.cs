using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(InventoryManager))]
[RequireComponent(typeof(Score_Counter_Manager))]

public class Managers : MonoBehaviour {
	public static InventoryManager Inventory {get; private set;}
	public static Score_Counter_Manager ScoreCounter {get; private set;}

	private List<IGameManager> startSequence;
	
	void Awake() {
		Inventory = GetComponent<InventoryManager>();
		ScoreCounter = GetComponent<Score_Counter_Manager>();

		startSequence = new List<IGameManager>();
		startSequence.Add(Inventory);
		startSequence.Add(ScoreCounter);

		StartCoroutine(StartupManagers());
	}

	private IEnumerator StartupManagers() {
		foreach (IGameManager manager in startSequence) {
			manager.Startup();
		}

		yield return null;

		int numModules = startSequence.Count;
		int numReady = 0;

		while (numReady < numModules) {
			int lastReady = numReady;
			numReady = 0;

			foreach (IGameManager manager in startSequence) {
				if (manager.status == ManagerStatus.Started) {
					numReady++;
				}
			}

			if (numReady > lastReady)
				Debug.Log($"Progress: {numReady}/{numModules}");
			
			yield return null;
		}
		
		Debug.Log("All managers started up");
	}
}
