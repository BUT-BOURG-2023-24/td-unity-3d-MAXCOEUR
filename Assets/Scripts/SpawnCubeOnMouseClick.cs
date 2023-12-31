using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using EnhancedTouch = UnityEngine.InputSystem.EnhancedTouch;

public class SpawnCubeOnMouseClick : MonoBehaviour
{
    // Start is called before the first frame update
    public InputActionReference ClickAction;
    public LayerMask groundLayer;
    public GameObject prefabToCube;
    public float spawnHeightOffset = 0.0f;
    public Joystick joystick;

    private void OnEnable()
    {
        //ClickAction.action.performed += Action_performed;
        EnhancedTouch.TouchSimulation.Enable();
        EnhancedTouch.EnhancedTouchSupport.Enable();
        EnhancedTouch.Touch.onFingerDown += Touch_onFingerDown;
    }

    

    private void OnDisable()
    {
        //ClickAction.action.performed -= Action_performed;
        EnhancedTouch.TouchSimulation.Disable();
        EnhancedTouch.EnhancedTouchSupport.Disable();
        EnhancedTouch.Touch.onFingerDown -= Touch_onFingerDown;
    }
    private void Action_performed(InputAction.CallbackContext obj)
    {
        spawnCube(Input.mousePosition);
    }
    private void Update()
    {
        
    }

    private void Touch_onFingerDown(EnhancedTouch.Finger finger)
    {
        RectTransform joystickRect = (joystick.transform as RectTransform);

        bool xIn = joystickRect.offsetMin.x <= finger.screenPosition.x && finger.screenPosition.x <= joystickRect.offsetMax.x;
        bool yIn = joystickRect.offsetMin.y <= finger.screenPosition.y && finger.screenPosition.y <= joystickRect.offsetMax.y;

        if (!(xIn && yIn))
        {
            spawnCube(finger.screenPosition);
        }        
    }

    void spawnCube(Vector2 screenPosition)
    {
        Ray ray = Camera.main.ScreenPointToRay(screenPosition);
        RaycastHit hit;
        // V�rifier si le rayon frappe quelque chose
        if (Physics.Raycast(ray, out hit,1000f,groundLayer))
        {
            Vector3 spawnPoint = hit.point;
            spawnPoint.y += spawnHeightOffset;
            // Instancier le prefab � la position du point d'impact
            GameObject instance = Instantiate(prefabToCube, spawnPoint, Quaternion.identity);
            Debug.Log($"Objet instanci� � la position : {spawnPoint}");
        }

    }
}
