using UnityEngine;
using System.Collections;

public class pathfindingTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
		int[,] map = new int[5,5]{
			{0,1,0,0,0}
			{0,1,0,0,0}
			{0,1,0,0,0}
			{0,1,0,0,0}
			{0,0,0,0,0}
		};

		var graph = new Graph (map);

		var search = new Search(Graph);
		search.Start(graph.nodes[0], graph.nodes[2]);

		while(!search.finished){
			search.Step();
		}

		print("Search done. Path length "+search.path.Count+"iterations "+search.iterations)
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
