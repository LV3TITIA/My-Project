using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDrop : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private Vector3 GetMousePos()
    {
       return Camera.main.WorldToScreenPoint(transform.position);
    }

    private void OnMouseDown()
    {
        _mousePosition = Input.mousePosition - GetMousePos();
    }
    private void OnMouseDrag()
    { // Creer un nv vecteur 3 = a la nouvelle position
      // Condition = si y de la nv position ne convient pas on le change

        Vector3 NewPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition - _mousePosition);

        if (NewPosition.y < 1.7f)
        {
            NewPosition.y = 1.7f;
        }

        transform.position = NewPosition;
    }

    private Vector3 _mousePosition;
}
