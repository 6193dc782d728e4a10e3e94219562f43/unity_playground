using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class all_symbol_event : MonoBehaviour
{    
    public List<GameObject> symbols;

    // Start is called before the first frame update
    void Start()
    {
        symbols = new List<GameObject>();
        symbols.Add(GameObject.Find("single_symbol"));
        symbols.Add(GameObject.Find("single_symbol1"));
        symbols.Add(GameObject.Find("single_symbol2"));
        symbols.Add(GameObject.Find("single_symbol3"));
        symbols.Add(GameObject.Find("single_symbol4"));
        symbols.Add(GameObject.Find("single_symbol5"));
        symbols.Add(GameObject.Find("single_symbol6"));
        symbols.Add(GameObject.Find("single_symbol7"));
        symbols.Add(GameObject.Find("single_symbol8"));
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
