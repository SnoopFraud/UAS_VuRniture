using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWalk : MonoBehaviour
{
    public int _DistanceRay = 20;
    private RaycastHit _hit;
    public int _playerSpeed;

    // Start is called before the first frame update
    void Start()
    {
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0f));

        if (Physics.Raycast(ray, out _hit, _DistanceRay))
        {
            if (Input.GetButton("Fire1"))
            {
                if(_hit.transform.CompareTag("Furniture"))
                {
                    Debug.Log("NO MOVE");
                }
                else
                {
                    transform.position
                    = transform.position + Camera.main.transform.forward * _playerSpeed * Time.deltaTime;
                }
            }
            
        }
        
    }
}
