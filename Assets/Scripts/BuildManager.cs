using UnityEngine;

public class BuildManager : MonoBehaviour {
    public static BuildManager instance;
    private void Awake() {
        if (instance != null) {
            return;
        }
        instance = this;
    }
    private GameObject turretToBuild;
    public GameObject standardTurretPrefab;
    public GameObject missleLauncherPrefab;
    public GameObject GetTurretToBuild() {
        return turretToBuild;
    }

    public void SetTurretToBuild(GameObject turret) {
        turretToBuild = turret;
    }
}
