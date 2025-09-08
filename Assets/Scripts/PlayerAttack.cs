using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField] private GameObject projectilePrefab;   // assign prefab in inspector
    [SerializeField] private Transform projectileSpawner;   // assign child empty spawner

    void Update()
    {
        if (Input.GetMouseButtonDown(0))   // 0 = left click
        {
            Instantiate(projectilePrefab, projectileSpawner.position, Quaternion.identity);
        }
    }
}
