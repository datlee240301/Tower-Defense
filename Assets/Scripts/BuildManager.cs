using UnityEngine;

public class BuildManager : MonoBehaviour {
    public static BuildManager instance;
    private void Awake() {
        if (instance != null) {
            return;
        }
        instance = this;
    }
    private TurretBlueprint turretToBuild;
    public GameObject standardTurretPrefab;
    public GameObject missleLauncherPrefab;
    public bool CanBuild { get { return turretToBuild != null; } }  

    public void BuildTurretOn(Node node) {
        GameObject turret =  (GameObject)Instantiate(turretToBuild.prefab, node.GetBuildPosition(), Quaternion.identity);
        node.turret = turret;
    }

    public void SelectTurretToBuild(TurretBlueprint turret) {
        turretToBuild = turret; 
    }
}
