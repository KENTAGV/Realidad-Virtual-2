using UnityEngine;
namespace IntroDemoVR.Scripts
{
public class VRInputListeners : MonoBehaviour
{
    private VRInputManager inputManager;

    private void Start()
    {
        // Buscamos el componente Manager en la escena
        inputManager = FindAnyObjectByType<VRInputManager>();

        if (inputManager != null)
        {
            // SUSCRIPCIÓN DE 3 LISTENERS AL EVENTO 1 (Gatillo Izquierdo)
            inputManager.OnLeftTriggerPressed += ListenerIzquierdoUno;
            inputManager.OnLeftTriggerPressed += ListenerIzquierdoDos;
            inputManager.OnLeftTriggerPressed += ListenerIzquierdoTres;

            // SUSCRIPCIÓN DE 3 LISTENERS AL EVENTO 2 (Gatillo Derecho)
            inputManager.OnRightTriggerPressed += ListenerDerechoUno;
            inputManager.OnRightTriggerPressed += ListenerDerechoDos;
            inputManager.OnRightTriggerPressed += ListenerDerechoTres;

            // SUSCRIPCIÓN DE 3 LISTENERS AL EVENTO 3 (Botón A Derecho)
            inputManager.OnRightButtonAPressed += ListenerBotonUno;
            inputManager.OnRightButtonAPressed += ListenerBotonDos;
            inputManager.OnRightButtonAPressed += ListenerBotonTres;
        }
    }

    // --- ESCUCHADORES / LISTENERS DEL EVENTO 1 ---
    private void ListenerIzquierdoUno() => Debug.Log("[XRI Input] Gatillo Izquierdo - Listener 1 Ejecutado");
    private void ListenerIzquierdoDos() => Debug.Log("[XRI Input] Gatillo Izquierdo - Listener 2 Ejecutado");
    private void ListenerIzquierdoTres() => Debug.Log("[XRI Input] Gatillo Izquierdo - Listener 3 Ejecutado");

    // --- ESCUCHADORES / LISTENERS DEL EVENTO 2 ---
    private void ListenerDerechoUno() => Debug.Log("[XRI Input] Gatillo Derecho - Listener 1 Ejecutado");
    private void ListenerDerechoDos() => Debug.Log("[XRI Input] Gatillo Derecho - Listener 2 Ejecutado");
    private void ListenerDerechoTres() => Debug.Log("[XRI Input] Gatillo Derecho - Listener 3 Ejecutado");

    // --- ESCUCHADORES / LISTENERS DEL EVENTO 3 ---
    private void ListenerBotonUno() => Debug.Log("[XRI Input] Botón A Derecho - Listener 1 Ejecutado");
    private void ListenerBotonDos() => Debug.Log("[XRI Input] Botón A Derecho - Listener 2 Ejecutado");
    private void ListenerBotonTres() => Debug.Log("[XRI Input] Botón A Derecho - Listener 3 Ejecutado");
}
}