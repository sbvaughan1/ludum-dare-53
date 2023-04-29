using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RatSwapperBehavior : MonoBehaviour
{
    public List<RatControllerBehavior> RatControllers;
    private int controlledIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        RatControllers[controlledIndex].ChangeControl(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            controlledIndex++;
            if (controlledIndex >= RatControllers.Count)
            {
                controlledIndex = 0;
            }

            for (int i = 0; i < RatControllers.Count; i++)
            {
                var ratController = RatControllers[i];
                ratController.ChangeControl(controlledIndex == i);
            }
        }
    }
}
