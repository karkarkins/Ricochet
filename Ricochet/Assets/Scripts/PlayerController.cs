using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float angle;
    public GameObject projectilePrefab;
    public GameObject laser;
    // Start is called before the first frame update
    void Start()
    {
        //Vector2 laserOffset = new Vector2(transform.position.x + 0.46f, transform.position.y + 0.08f);
        //laser.transform.position = laserOffset;
        Instantiate(laser, transform);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mouseScreenPos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, -Camera.main.transform.position.z);
        Vector3 mouseWorldPosition = Camera.main.ScreenToWorldPoint(mouseScreenPos);
        angle = Mathf.Atan2(mouseScreenPos.y, mouseScreenPos.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));

        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(projectilePrefab, transform.position, transform.rotation);
        }

    }
}
