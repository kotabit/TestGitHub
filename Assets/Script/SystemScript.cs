using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SystemScript : MonoBehaviour
{
    [SerializeField] GameObject _blockPrefab = null;
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Instantiate<GameObject>(_blockPrefab);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
