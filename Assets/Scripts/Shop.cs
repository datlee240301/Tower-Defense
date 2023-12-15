using UnityEngine;

public class Shop : MonoBehaviour
{
    public TurretBlueprint standardTurret;
    public TurretBlueprint missleLauncher;
    BuildManager buildManager;

    private void Start() {
        buildManager = BuildManager.instance;
    }

    public void SelectStandardTurret() {
        buildManager.SelectTurretToBuild(standardTurret);
    }

    public void SelectMisslelauncher() {
        buildManager.SelectTurretToBuild(missleLauncher);
    }
}
