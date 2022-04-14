using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerController : MonoBehaviour
{

    [SerializeField] GameObject [] _trees;
    [SerializeField] [Range(1, 5)] float _minSpawnTime; 
    [SerializeField] [Range(2, 6)] float _maxSpawnTime;
    float _randomSpawnTimeDragon, _randomSpawnTimeTree, _currentTimeDragon,_currentTimeTree;
    [SerializeField] UnityEngine.Transform _treeTransform, _dragonTransform;
    [SerializeField] GameObject _dragon;
    


    void TreeSpawnStart() 
    {
        int _randomIndex = Random.Range(0, _trees.Length);
        Instantiate(_trees[_randomIndex], _treeTransform.position, _treeTransform.rotation,_treeTransform);
        ResetTimeTree();
    }
    
    void DragonSpawnStart() 
    {
       
        Instantiate(_dragon, _dragonTransform.position, _dragonTransform.rotation,_dragonTransform);
        ResetTimeDragon();
    }

    

    private void FixedUpdate()
    {
        _currentTimeDragon += Time.deltaTime;
        if (_currentTimeDragon > _randomSpawnTimeDragon)
        {
            
            DragonSpawnStart();
        }
        _currentTimeTree += Time.deltaTime;
        if (_currentTimeTree > _randomSpawnTimeTree)
        {
            TreeSpawnStart();
        }

        


    }

    void ResetTimeDragon() 
    {
        _currentTimeDragon = 0;
        _randomSpawnTimeDragon = Random.Range(_minSpawnTime, _maxSpawnTime);
    }
    void ResetTimeTree() 
    {
        _currentTimeTree = 0;
        _randomSpawnTimeTree = Random.Range(_minSpawnTime, _maxSpawnTime);
    }
}
