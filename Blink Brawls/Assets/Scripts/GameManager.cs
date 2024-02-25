using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject wheelPrefab; // Assign the wheel troop prefab in the inspector
    private bool isWheelSelected = false;

    // This method is called when the circle button is clicked
    public void OnWheelButtonClicked()
    {
        Debug.Log("Wheel selected");
        isWheelSelected = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (isWheelSelected && Input.GetMouseButtonDown(0))
        {
            Debug.Log("Mouse clicked while wheel is selected");
            Vector3 clickPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            clickPosition.z = 0;

            RaycastHit2D hit = Physics2D.Raycast(clickPosition, Vector2.zero);
            if (hit.collider != null && hit.collider.CompareTag("lane"))
            {
                SpawnWheel(hit.collider.gameObject);
                isWheelSelected = false; // Reset the selection
            }
        }
    }

    void SpawnWheel(GameObject lane)
    {
        // Assuming you want to spawn the 'wheel' at a specific point within the lane
        Debug.Log("Spawning wheel at lane: " + lane.name);
        Vector3 spawnPoint = lane.transform.position; // Modify this to be the correct spawn location
        Instantiate(wheelPrefab, spawnPoint, Quaternion.identity);
    }
}
