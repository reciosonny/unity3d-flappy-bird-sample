using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrndGenerator : MonoBehaviour {

    [SerializeField]
    private Transform groundToClone;
    public static GrndGenerator instance;
    //this field is a workaround for some bug in the ground with small gap or space
    [SerializeField]
    public float groundWidth = 7.17f;

    public void GenerateGround() {
        float groundCloneXCoordinate = groundToClone.position.x;
        // bool firstRun = true;

        for (int i = 1; i <= 7; i++) {
            var newGameObject = Instantiate(groundToClone);
            float groundXCoordinateFormula = groundWidth * i;
            newGameObject.parent = transform;
            newGameObject.transform.position = new Vector3(groundXCoordinateFormula, groundToClone.position.y, -5f);
        }

    }

    /// <summary>
    /// Awake is called when the script instance is being loaded.
    /// </summary>
    void Awake()
    {
        // instance = instance == null ? this : instance;
        if (instance == null) {
            instance = this;
        }
    }

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }
}
