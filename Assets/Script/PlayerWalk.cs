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
                    switch (_hit.transform.gameObject.name)
                    {
                        //Testing
                        
                        case "Objek":
                            ManagerUI.objek_price = "Cube is Rp. 2500";
                            ManagerUI.url = "https://youtu.be/53xLO-Asq3w";
                            break;
                        case "Objek2":
                            ManagerUI.objek_price = "Cube2 is Rp. 1500";
                            ManagerUI.url = "https://youtu.be/MtZTFMwxgNo";
                            break;

                        //Furniture Interact
                        case "Kasur":
                            ManagerUI.objek_price = "Kasur - Rp. 2.229.000";
                            ManagerUI.url = "https://bit.ly/3Pg6GIw";
                            break;
                        case "Meja Belajar":
                            ManagerUI.objek_price = "Meja belajar - Rp. 3.339.000";
                            ManagerUI.url = "https://bit.ly/3W4AMRn";
                            break;
                        case "Meja Kecil":
                            ManagerUI.objek_price = "Meja kecil - Rp. 1.499.000";
                            ManagerUI.url = "https://bit.ly/3V1wgCB";
                            break;
                        case "Sofa":
                            ManagerUI.objek_price = "Sofa - Rp. 5.395.000";
                            ManagerUI.url = "https://bit.ly/3UQ3UuG";
                            break;
                        case "KursiKerja":
                            ManagerUI.objek_price = "Kursi - Rp. 1.505.000";
                            ManagerUI.url = "https://bit.ly/3hfvBzn";
                            break;
                        case "Lemari buku":
                            ManagerUI.objek_price = "Lemari buku - Rp. 799.000";
                            ManagerUI.url = "https://bit.ly/3uC1eX5";
                            break;
                        case "Lemari Kecil":
                            ManagerUI.objek_price = "Lemari kecil - Rp. 629.000";
                            ManagerUI.url = "https://bit.ly/3W7N6AA";
                            break;
                        case "Lampu":
                            ManagerUI.objek_price = "Lampu - Rp. 449.000";
                            ManagerUI.url = "https://bit.ly/3Hn07Sv";
                            break;
                    }

                    
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
