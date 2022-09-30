using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorOpen : MonoBehaviour
{
    public GameObject TextDisplay;
    public float TheDistance = PlayerCasting.DistanceFromTarget;

    public GameObject TheDoor;

    void Update()
    {
        TheDistance = PlayerCasting.DistanceFromTarget;
        if (Input.GetButtonDown("Action"))
        {            
            if(TheDistance <= 2)
            {
                StartCoroutine(OpenTheDoor());
            }
        }
    }

    private void OnMouseOver()
    {
        if(TheDistance <= 2)
        {
            TextDisplay.GetComponent<Text>().text = "Press e To Open The Door";
        }
    }

    private void OnMouseExit()
    {
        TextDisplay.GetComponent<Text>().text = "";
    }

    IEnumerator OpenTheDoor()
    {
        TheDoor.GetComponent<Animation>().Play("Door001");
        yield return new WaitForSeconds(5);
        TheDoor.GetComponent<Animation>().Play("Door002");
    }
}
