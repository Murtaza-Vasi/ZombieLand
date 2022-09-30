using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SniperScopeActive : MonoBehaviour {
    public GameObject playerCam;
    public GameObject sniperScopeTex;
    public GameObject originalCursor;
    public int fieldView = 60;
    public bool zoomingIn = false;
    public bool GunPicked = CheckGunPicked.GunPicked;

    void Update()
    {
        if ((Input.GetMouseButtonDown(1))&&(TypeOfGun.GunName=="BarrettM107"))
        {
            
            if (zoomingIn == false)
            {

                sniperScopeTex.SetActive(true);
                originalCursor.SetActive(false);
                StartCoroutine(ZoomingCam());
                zoomingIn = true;
            }
        }
        if (Input.GetMouseButtonUp(1) && (TypeOfGun.GunName =="BarrettM107"))
        {
            StopAllCoroutines();
            fieldView = 60;
            playerCam.GetComponent<Camera>().fieldOfView=fieldView;
            sniperScopeTex.SetActive(false);
            originalCursor.SetActive(true);
            zoomingIn = false;
        }
    }
    IEnumerator ZoomingCam()
    {
        while(fieldView>25)
        {
         playerCam.GetComponent<Camera>().fieldOfView = fieldView;
         fieldView-=2;
        yield return new WaitForSeconds(0.01f);
        }
    }
}
