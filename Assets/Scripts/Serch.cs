using UnityEngine;
using System.Collections;

public class NewBehaviourScript {

	public Graph graph;
	public List<Node> reachable;
	public List<Node> explored;
	public List<Node> path;
	public Node goalNode;
	public int iterations;
	public bool finished;

	public search(Graph graph){
		this.graph = graph;
	}

	public void start(node start, node goal){
		reachable = new List<Node> ();
		reachable.Add (start);

		goalNode = goal;

		explored = new List<Node> ();
		path = new List<Node> ();
		iterations = 0;

		for(var i = 0; i <graph.nodes.Length; i++){
			graph.nodes[i].Clear();
		}
	}

	public void Step(){
		if(path.Count > 0){
			return;}

		if(reachable.Count == 0){
			finished = true;
			return;}

		iterations ++;
		var node = ChooseNode ();
		if (node == goalNode) {
			while(node != null){
				path.Insert(0, node);
				node = node.previous;
			}
			finished = true;
			return;
		}

		reachable.Remove (node);
		explored.Add (node);

		for (var i = 0; i < node.adjacent.Count; i++){
			AddAdjacent(node, node.adjacent[i]);
		}
	
	}
	public void AddAdjacent (Node Node, Node adjacent){

	}

	public bool FindNode(Node Node, List<Node> list){

	}


	public Node ChooseNode(){
		return reachable [Random.Range (0, reachable.Count)]
	}
	}