using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Axis0 : MonoBehaviour
{

    public Light pointLight;
    public Light areaLight;
    public bool isWelding = false;
    public void rotateLeft_2_3_deg() {
        transform.LeanRotate(new Vector3(0, -6f, 0), 1f);
    }

    public void rotateToCenter() {
        transform.LeanRotate(new Vector3(0, 1, 0), 1f);
    }

    public void rotateRight_2_3_deg() {
        transform.LeanRotate(new Vector3(0, -2.3f, 0), 1f);
    }

    public void startWelding() {
        Invoke("rotateToCenter", 1f);
        isWelding = true;
        ActivateLight();
        Invoke("rotateLeft_2_3_deg", 3f);
        Invoke("rotateToCenter", 4f);
        Invoke("rotateLeft_2_3_deg", 5f);
        Invoke("rotateToCenter", 6f);
        Invoke("rotateRight_2_3_deg", 7f);
        Invoke("rotateToCenter", 8f);
        Invoke("rotateRight_2_3_deg", 9f);
        Invoke("rotateToCenter", 10f);
        isWelding = false;
        ActivateLight();
        Invoke("return0", 11f);
    }

    public void ActivateLight() {
        pointLight.enabled = !pointLight.enabled;
        areaLight.enabled = !areaLight.enabled;
    }

    
    public void return0() {
        transform.LeanRotate(new Vector3(0, 0, 0), 2f);
    }
}