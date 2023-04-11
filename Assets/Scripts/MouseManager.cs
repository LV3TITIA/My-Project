using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseManager : MonoBehaviour
{
    [SerializeField]
    LayerMask layerMask;

    [SerializeField]
    Texture _mouseTextureMove;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit hit;

        //Debug.DrawRay(ray.origin, ray.direction * 100, Color.red);

        if (Physics.Raycast(ray, out hit, layerMask))
        {
             
            if (hit.collider != null)
            {
                Vector3 hotspot = new Vector2(0, 0);
                if (hit.collider.CompareTag("Move"))
                {
                    Debug.Log("D");
                    Cursor.SetCursor((Texture2D)_mouseTextureMove, hotspot, CursorMode.Auto);

                    if (Input.GetMouseButtonDown(0))
                    {
                        _activeObject = hit.collider.transform;
                    }

                    if (_activeObject != null)
                    {
                        _activeObject.transform.position = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);
                    }
                } 
            }
        }
        else
        {
            Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
        }
        if (Input.GetMouseButtonUp(0))
        {
            _activeObject = null;
        }
    }

    private Transform _activeObject;
}
