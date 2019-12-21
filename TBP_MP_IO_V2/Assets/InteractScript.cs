using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractScript : MonoBehaviour {
    public Image Cuser;
    public GameObject Main;
	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {

        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Cuser.transform.position);//touch.position
        if (Physics.Raycast(ray, out hit))
            if (hit.collider != null && hit.distance < 10 && Input.GetButtonDown("Mine"))
            {
                // Debug.Log("HIT:" + hit.collider.name + "DIS:" + hit.distance);
                // destroy it too....
                // first add it to inv
                // add it to inv
                Debug.Log("Player got [" + hit.collider.gameObject.name + "]");
                if (Main.GetComponent<MainMan>().AddThingToInv(hit.collider.gameObject.name))
                {
                    Main.GetComponent<MainMan>().RemoveBlock(hit.collider.gameObject);
                    GameObject.Destroy(hit.collider.gameObject); // YOU HAVE TO TELL MAIN?!!!!!

                    // ask main to make stone!
                    Main.GetComponent<MainMan>().MakeStone(hit.collider.transform.position);
                }
                else
                {
                    Debug.Log("For some odd reson main is keeping [" + hit.collider.gameObject + "] from the player");
                }
            }
        if (hit.collider != null && hit.distance < 10 && Input.GetButtonDown("Place Block"))
        {
            // Debug.Log("HIT:" + hit.collider.name + "DIS:" + hit.distance);
            // destroy it too....
            
            // ask main to make stone!
            Main.GetComponent<MainMan>().PlaceBlock(hit.collider.transform.position);
        }

    }
}
