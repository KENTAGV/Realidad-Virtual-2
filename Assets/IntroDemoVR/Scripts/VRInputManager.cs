using System;
using UnityEngine;
using UnityEngine.InputSystem;
namespace IntroDemoVR.Scripts 
{
public class VRInputManager : MonoBehaviour
{
    [Header("XRI Default Input Actions")]
    // Estas propiedades te permitirán enlazar las acciones del control desde el Inspector
    public InputActionProperty leftHandTrigger;
    public InputActionProperty rightHandTrigger;
    public InputActionProperty rightHandButtonA;

    // LOS 3 EVENTOS SOLICITADOS (Usando event Action)
    public event Action OnLeftTriggerPressed;
    public event Action OnRightTriggerPressed;
    public event Action OnRightButtonAPressed;

    private void OnEnable()
    {
        // Habilitamos las acciones de entrada de forma segura al iniciar
        leftHandTrigger.action?.Enable();
        rightHandTrigger.action?.Enable();
        rightHandButtonA.action?.Enable();
    }

    private void Update()
    {
        // 1. Detectar si el Trigger Izquierdo fue presionado en este frame
        if (leftHandTrigger.action != null && leftHandTrigger.action.WasPressedThisFrame())
        {
            OnLeftTriggerPressed?.Invoke();
        }

        // 2. Detectar si el Trigger Derecho fue presionado en este frame
        if (rightHandTrigger.action != null && rightHandTrigger.action.WasPressedThisFrame())
        {
            OnRightTriggerPressed?.Invoke();
        }

        // 3. Detectar si el Botón A del mando derecho fue presionado en este frame
        if (rightHandButtonA.action != null && rightHandButtonA.action.WasPressedThisFrame())
        {
            OnRightButtonAPressed?.Invoke();
        }
    }
}
}
