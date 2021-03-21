using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public EnemyController EnemyPrefab;
    private List<EnemyController> _enemyControllers;
    private float _spawnTimer = 3.0f;

    private void Start()
    {
        _enemyControllers = new List<EnemyController>();
    }

    // Update is called once per frame
    void Update()
    {
        _spawnTimer -= Time.deltaTime;
        if (_spawnTimer < 0)
        {
            EnemyController enemy = Instantiate<EnemyController>(EnemyPrefab);
            Vector3 leftTop = Camera.main.ScreenToWorldPoint(new Vector3(0, Screen.height));
            enemy.transform.position = leftTop;
            _enemyControllers.Add(enemy);
            _spawnTimer = 3.0f;
        }

    }

    public void Pause()
    {
        foreach (EnemyController enemy in _enemyControllers)
        {
            if(enemy != null) enemy.gameObject.SetActive(false);
        }
    }

    public void Resume()
    {
        foreach (EnemyController enemy in _enemyControllers)
        {
            if (enemy != null) enemy.gameObject.SetActive(true);
        }
    }

    public void HotReset()
    {
        foreach(EnemyController enemy in _enemyControllers)
        {
            if (enemy != null) GameObject.Destroy(enemy);
        }
        _enemyControllers.Clear();
    }
}
