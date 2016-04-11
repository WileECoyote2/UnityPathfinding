﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Search {

	public Graph graph;
	public List<Node> reachable;
	public List<Node> explored;
	public List<Node> path;
	public Node goalNode;
	public int iterations;
	public bool finished;

	public Search(Graph graph){
		this.graph = graph;
	}

	public void Start(Node start, Node goal){
		reachable = new List<Node> ();
		reachable.Add (start);

		goalNode = goal;

		explored = new List<Node> ();
		path = new List<Node> ();
		iterations = 0;

		for (var i = 0; i < graph.nodes.Length; i++) {
			graph.nodes[i].Clear();
		}
	}

	public void Step(){
		if (path.Count > 0)
			return;

		if (reachable.Count == 0) {
			finished = true;
			return;
		}


		iterations ++;

		var node = ChoseNode ();
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

		for (var i = 0; i < node.adjecent.Count; i++) {
			AddAdjacent(node, node.adjecent[i]);
		}
	}

	public void AddAdjacent(Node node, Node adjacent){

	}

	public Node ChoseNode(){
		return reachable [Random.Range (0, reachable.Count)];
	}

}
