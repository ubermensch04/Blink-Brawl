using UnityEngine;

public class TroopSelectionManager : MonoBehaviour
{
    public static TroopSelectionManager Instance { get; private set; }

    public GameObject selectedTroopPrefab;

    private void Awake()
    {
        // Ensure there's only one instance of this manager using a singleton pattern
        Debug.Log("TroopSelectionManager is awake and running.");
        if (Instance == null) Instance = this;
        else Destroy(gameObject);
    }

    public void SelectTroop(GameObject troopPrefab)
    {
        Debug.Log("Circle clicked. Troop selected: " + troopPrefab.name);
        selectedTroopPrefab = troopPrefab;

        // You can add more code here to handle UI updates or other logic
    }
}
