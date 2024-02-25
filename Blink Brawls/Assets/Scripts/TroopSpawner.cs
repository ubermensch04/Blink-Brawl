using UnityEngine;

public class TroopSpawner : MonoBehaviour
{
    public void SpawnSelectedTroop(Vector3 spawnPosition)
    {
        // Check if there is a selected troop prefab
        if (TroopSelectionManager.Instance.selectedTroopPrefab != null)
        {
            Instantiate(TroopSelectionManager.Instance.selectedTroopPrefab, spawnPosition, Quaternion.identity);
        }
        else
        {
            Debug.LogWarning("No troop selected to spawn.");
        }
    }
}
