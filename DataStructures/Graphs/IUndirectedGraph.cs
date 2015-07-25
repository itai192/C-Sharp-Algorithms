﻿using System;
using System.Collections.Generic;

using DataStructures.Lists;

namespace DataStructures.Graphs
{
	public interface IUndirectedGraph<T> where T : IComparable<T>
	{
		/// <summary>
		/// Gets the count of vetices.
		/// </summary>
		int VerticesCount { get; }

		/// <summary>
		/// Gets the count of edges.
		/// </summary>
		int EdgesCount { get; }

		/// <summary>
		/// Returns the list of Vertices.
		/// </summary>
		ArrayList<T> Vertices { get; }

		/// <summary>
		/// Connects two vertices together.
		/// </summary>
		bool AddEdge(T firstVertex, T secondVertex);

		/// <summary>
		/// Deletes an edge, if exists, between two vertices.
		/// </summary>
		bool RemoveEdge(T firstVertex, T secondVertex);

		/// <summary>
		/// Adds a list of vertices to the graph.
		/// </summary>
		void AddVertices(IList<T> collection);

		/// <summary>
		/// Adds a new vertex to graph.
		/// </summary>
		bool AddVertex(T vertex);

		/// <summary>
		/// Removes the specified vertex from graph.
		/// </summary>
		bool RemoveVertex(T vertex);

		/// <summary>
		/// Checks whether two vertices are connected (there is an edge between firstVertex & secondVertex)
		/// </summary>
		bool AreConnected(T firstVertex, T secondVertex);

		/// <summary>
		/// Determines whether this graph has the specified vertex.
		/// </summary>
		bool HasVertex(T vertex);

		/// <summary>
		/// Returns the neighbours doubly-linked list for the specified vertex.
		/// </summary>
		DLinkedList<T> Neighbours(T vertex);

		/// <summary>
		/// Returns the degree of the specified vertex.
		/// </summary>
		int Degree(T vertex);

		/// <summary>
		/// Returns a human-readable string of the graph.
		/// </summary>
		string ToReadable();
	}
}

