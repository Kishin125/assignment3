using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.UI;
using UnityEngine.UI;
using UnityEditor;

/// <summary>
/// On startup, adds event handlers for every Interactable aka button
/// in the scene that logs the name of the button pressed.
/// You can similarly add such a listener when adding the buttons dynamically
/// </summary>
public class one : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject cube;
    public GameObject sphere;


    void Start()
    {
        
        var allInteractables = GameObject.FindObjectsOfType<Interactable>();
        foreach (var i in allInteractables)
        {
            i.OnClick.AddListener(() => dothis());
        }
    }

    void dothis()
    {
        cube.transform.position = new Vector3(-1.926f, 0.795f, 2.583f);
        sphere.transform.position = new Vector3(-1.917f, 0.8f, 3.19f);
        cube.GetComponent<Rigidbody>().velocity = Vector3.zero;
        sphere.GetComponent<Rigidbody>().velocity = Vector3.zero;
    }
}