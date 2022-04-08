using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChessManager1 : MonoBehaviour
{
    string Objectname;
    Vector3 PP;
    void Go()
    {  
        if (transform.position.z >= -6){
            transform.position = transform.position + new Vector3(0, 0, -2.0f);
            Invoke("Update", 5f);   
        }
    }
    /*
    void SelectPawn()
    {
        while (check < 1){
            if (Input.GetMouseButton(0)){
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;
                if (Physics.Raycast(ray, out hit)){ 
                    Objectname = hit.collider.gameObject.name;
                    SelectField();
                    break;
                }
            }
        }
    }

    void SelectField()
    {
        while (check < 1){
            if (Input.GetMouseButton(0)){
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;
                if (Physics.Raycast(ray, out hit)){ 
                    Fieldname = hit.collider.gameObject.name;
                    CheckPosition();
                    break;
                }
            }
        }
    }

    void CheckPosition()
    {
        pawn = GameObject.Find(Objectname);
        field = GameObject.Find(Fieldname);
        if (pawn.transform.position + new Vector3(0, 0, 2.0f) == field.transform.position){
            AvailablePosition();
        }
    }

    void AvailablePosition()
    {
        pawn = GameObject.Find(Objectname);
        field = GameObject.Find(Fieldname);
        pawn.transform.position = field.transform.position;
        SelectPawn();
    }
    */

    // Start is called before the first frame update
    void Start()
    {
        PP = transform.position;    
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)){
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit)){
                Objectname = hit.collider.gameObject.name;
                if (transform.name == Objectname){
                    Go();
                }
            }
        }
    }
}