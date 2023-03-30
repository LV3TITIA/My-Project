using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UIElements;

public class TrayControler : MonoBehaviour
{
    [SerializeField]
    private float _force;

    [SerializeField]
    public Transform _contactPoint;

    //[SerializeField]
    //private GameObject LooseMenu;

    // Start is called before the first frame update
    void Start()
    {
        _TrayRigidbody = GetComponent<Rigidbody>();
        //menuManager = GetComponent<MenuManager>();
        //LooseMenu = GetComponentInChildren<GameObject>();
    }


    // Update is called once per frame
    private void Update()
    {
        
    }

    void FixedUpdate()
    {
        Vector3 force = new Vector3(0, _force, 0);

        if (Input.GetButton("Jump"))
        {
            _TrayRigidbody.AddForceAtPosition(force, _contactPoint.position);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        //Tray.name = "Tray"; 

        if (collision.gameObject.CompareTag("Terrain"))
        {
            Time.timeScale = 0;
            //Debug.Log("Game Over !");
            //LooseMenu.SetActive(true);
            MenuManager.instance.OnPlayerLoose();
        }
    }

    private MenuManager menuManager;
    private Rigidbody _TrayRigidbody;
    //private GameObject Tray;
}
