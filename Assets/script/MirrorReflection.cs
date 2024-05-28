using UnityEngine;

public class MirrorReflection : MonoBehaviour
{
    public Camera camaraPrincipal;
    public Camera camaraEspejo;
    public Transform transformacionEspejo;

    void LateUpdate()
    {
        if (!camaraPrincipal || !camaraEspejo || !transformacionEspejo)
            return;

        // Calcular la posición del reflejo
        Vector3 direccionCamaraEspacioMundo = camaraPrincipal.transform.forward;
        Vector3 arribaCamaraEspacioMundo = camaraPrincipal.transform.up;

        camaraEspejo.transform.position = transformacionEspejo.position + Vector3.Reflect(camaraPrincipal.transform.position - transformacionEspejo.position, transformacionEspejo.forward);
        camaraEspejo.transform.rotation = Quaternion.LookRotation(Vector3.Reflect(direccionCamaraEspacioMundo, transformacionEspejo.forward), Vector3.Reflect(arribaCamaraEspacioMundo, transformacionEspejo.forward));
    }
}