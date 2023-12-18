using UnityEngine;
using UnityEngine.EventSystems;

public class Node : MonoBehaviour
{
    public Color hoverColor;
    private Color startColor;
    private Renderer rend;
    public GameObject turret;
    BuildManager buildManager;
    public Color notEnoughMoneyColor; 
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;
        buildManager = BuildManager.instance;
    }

    public Vector3 GetBuildPosition() {
        return transform.position;
    }

    private void OnMouseDown() {
        if (EventSystem.current.IsPointerOverGameObject()) return; 
        if (!buildManager.CanBuild) return;
        if (turret != null) { 
            return;
        }
        buildManager.BuildTurretOn(this );
    }

    private void OnMouseEnter() {
        if(EventSystem.current.IsPointerOverGameObject()) return;
        if (!buildManager.CanBuild) return;
        if (buildManager.HasMoney) {
            rend.material.color = hoverColor;
        } 
        else {
            rend.material.color = notEnoughMoneyColor;
        }
    }

    private void OnMouseExit() {
        rend.material.color = startColor;
    }
}
