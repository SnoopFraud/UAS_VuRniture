using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWalk : MonoBehaviour
{
    public int _DistanceRay = 20;
    private RaycastHit _hit;
    public int _playerSpeed;

    //Other Components
    GameObject UIM;
    UiManagement ManagerUI;

    private void Awake()
    {
        UIM = GameObject.Find("MenuManagement");
        ManagerUI = UIM.GetComponent<UiManagement>();
    }

    // Start is called before the first frame update
    void Start()
    {
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
        
        //Cari object by name
    }

    // Update is called once per frame
    void Update()
    {
        raycastobject();
    }

    void raycastobject()
    {
        Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0f));

        if (Physics.Raycast(ray, out _hit, _DistanceRay))
        {
            if (Input.GetButton("Fire1"))
            {
                if (_hit.transform.gameObject.CompareTag("Furniture"))
                {
                    //Switch if object
                    /*switch (_hit.transform.gameObject.name)
                    {
                        case "Objek":
                            ManagerUI.objek_price = "Cube is Rp. 2500";
                            ManagerUI.url = "https://youtu.be/53xLO-Asq3w";
                            break;
                        case "Objek2":
                            ManagerUI.objek_price = "Cube2 is Rp. 1500";
                            ManagerUI.url = "https://youtu.be/MtZTFMwxgNo";
                            break;
                    }*/

                    
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
