using UnityEngine;
using UnityEngine.EventSystems;

public class Node : MonoBehaviour
{
    public Color hoverColor;
    private Color startColor;
    private Renderer rend;
    private GameObject turret;
    BuildManager buildManager;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;
        buildManager = BuildManager.instance;
    }

    private void OnMouseDown() {
        if (EventSystem.current.IsPointerOverGameObject()) return;
        if (buildManager.GetTurretToBuild() == null) return;
        if (turret != null) {
            return;
        }
        GameObject turretToBuild = buildManager.GetTurretToBuild();
        turret =  (GameObject)Instantiate(turretToBuild, transform.position, transform.rotation);
    }

    private void OnMouseEnter() {
        if(EventSystem.current.IsPointerOverGameObject()) return;
        if (buildManager.GetTurretToBuild() == null) return;    
        rend.material.color = hoverColor;
    }

    private void OnMouseExit() {
        rend.material.color = startColor;
    }
}
