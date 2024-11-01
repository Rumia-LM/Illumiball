using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameClearDetector : MonoBehaviour
{
    public Hole holeRed;
    public Hole holeBlue;
    public Hole holeGreen;
    //Holeクラスを付与されたコンポーネントを登録できるようになる
    void OnGUI(){
        GUI.matrix = Matrix4x4.Scale(Vector3.one*2);
        if (holeRed.IsHolding && holeBlue.IsHolding && holeGreen.IsHolding){
            GUI.Label(new Rect(10, 10, 100, 30), "Game Clear!");
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
