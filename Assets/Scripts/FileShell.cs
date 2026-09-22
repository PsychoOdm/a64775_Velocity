using UnityEngine;

public class FileShell : MonoBehaviour
{
    public GameObject bullet;
    public GameObject Turret;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void CreateBullet()
    {
        Instantiate(bullet, Turret.transform.position, Turret.transform.rotation);
    }

    void CalculateTrajectory()
    {}
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space));
        {
            CalculateTrajectory();
            CreateBullet();
        }
    }
}
