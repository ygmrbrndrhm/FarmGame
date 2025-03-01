using UnityEngine;

public class ItemDrag : MonoBehaviour
{
    public GameObject itemPrefab;
    private GameObject currentItem;
    private bool isDragging = false;

    public void StartDragging()
    {
        isDragging = true;
        Vector3 worldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        worldPosition.z = 0;
        currentItem = Instantiate(itemPrefab, worldPosition, Quaternion.identity);
    }

    public void StopDragging()
    {
        isDragging = false;
        Destroy(currentItem);
        currentItem = null;
    }

    void Update()
    {
        if (isDragging && currentItem != null)
        {
            Vector3 worldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            worldPosition.z = 0;
            currentItem.transform.position = worldPosition;
        }
    }
}

