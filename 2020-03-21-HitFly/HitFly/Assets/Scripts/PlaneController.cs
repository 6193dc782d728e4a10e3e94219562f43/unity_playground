using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneController : MonoBehaviour
{
    public BulletController BulletModel;
    public Transform gunpoint;

    private Vector3 _prevMousePos;
    private List<BulletController> _bullets;

    // Start is called before the first frame update
    void Start()
    {
        _bullets = new List<BulletController>();
    }

    // Update is called once per frame
    void Update()
    {
        Transform transform = this.gameObject.GetComponent<Transform>();

        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
        {
            BulletController bullet = Instantiate<BulletController>(BulletModel);
            bullet.transform.position = gunpoint.position;
            bullet.direction = (gunpoint.position - transform.position);
            _bullets.Add(bullet);
            // shoot prefab straightly
        }
    }

    private void FixedUpdate()
    {
        Transform transform = this.gameObject.GetComponent<Transform>();

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(new Vector3(0, 0, 1), 10);
        }
        if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(new Vector3(0, 0, 1), -10);
        }
    }

    public void HotReset()
    {
        this.enabled = true; 
        transform.rotation = Quaternion.AngleAxis(0, new Vector3(0, 0, 1));
        foreach(BulletController bullet in _bullets)
        {
            if (bullet != null)  GameObject.Destroy(bullet.gameObject);
        }
        _bullets.Clear();

    }

    public void Pause()
    {
        this.enabled = false;
        foreach (BulletController bullet in _bullets)
        {
            if (bullet != null) bullet.gameObject.SetActive(false);
        }
    }

    public void Resume()
    {
        this.enabled = true;
        foreach (BulletController bullet in _bullets)
        {
            if (bullet != null) bullet.gameObject.SetActive(true);
        }
    }

}
