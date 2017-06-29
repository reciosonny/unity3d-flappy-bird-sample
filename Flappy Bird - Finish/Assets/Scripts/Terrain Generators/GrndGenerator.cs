using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrndGenerator : MonoBehaviour {

    [SerializeField]
    private Transform groundToClone;


    // Use this for initialization
    void Start() {
        float groundCloneXCoordinate = groundToClone.position.x;
        // bool firstRun = true;

        for (int i = 1; i <= 7; i++) {
            var newGameObject = Instantiate(groundToClone);
            float groundXCoordinateFormula = 7.17f * i;
            newGameObject.parent = transform;
            newGameObject.transform.position = new Vector3(groundXCoordinateFormula, groundToClone.position.y, -5f);
        }

    }

    // Update is called once per frame
    void Update() {

    }
}
