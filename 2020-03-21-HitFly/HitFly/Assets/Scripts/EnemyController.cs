using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Transform transform = this.GetComponent<Transform>();

        Vector3 target = Vector3.zero;
        Vector3 self = transform.position;
        Vector3 deltaVec = (target - self);
        Vector3 movement = (target - self).normalized * 3.3f * Time.deltaTime;
        transform.Translate(movement);

        if(transform.position.x < 0 && transform.localScale.x > 0)
        {
            Vector3 scaleVec = transform.localScale;
            transform.localScale = new Vector3(scaleVec.x * -1, scaleVec.y, scaleVec.z);
        }
        else if (transform.position.x > 0 && transform.localScale.x < 0)
        {
            Vector3 scaleVec = transform.localScale;
            transform.localScale = new Vector3(scaleVec.x * -1, scaleVec.y, scaleVec.z);
        }
        // UiManager uiManager = GameObject.Find("UiManager").GetComponent<UiManager>();
        // uiManager.ShowDeadText();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            LifeManager lifeManager = GameObject.Find("_lifeManager").GetComponent<LifeManager>();
            lifeManager.GameOver();
        }
    }
}
