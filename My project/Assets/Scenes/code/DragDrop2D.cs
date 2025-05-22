using UnityEngine;

public class DragDrop2D : MonoBehaviour
{
    Vector3 offset;
    private Collider2D collider2d;
    public string destinationTag = "DropArea";

    void Awake()
    {
        collider2d = GetComponent<Collider2D>();
    }

    void OnMouseDown()
    {
        offset = transform.position - MouseWorldPosition();
    }

    void OnMouseDrag()
    {
        transform.position = MouseWorldPosition() + offset;
    }

    Vector3 MouseWorldPosition()
    {
        var mouseScreenPos = Input.mousePosition;
        mouseScreenPos.z = Camera.main.WorldToScreenPoint(transform.position).z;
        return Camera.main.ScreenToWorldPoint(mouseScreenPos);
    }
}
