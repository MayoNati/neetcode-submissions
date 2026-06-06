/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> neighbors;

    public Node() {
        val = 0;
        neighbors = new List<Node>();
    }

    public Node(int _val) {
        val = _val;
        neighbors = new List<Node>();
    }

    public Node(int _val, List<Node> _neighbors) {
        val = _val;
        neighbors = _neighbors;
    }
}
*/

public class Solution {
    private Dictionary<Node, Node> map = new Dictionary<Node, Node>();

    public Node CloneGraph(Node node) {
        if (node == null) return null; 
            return Clone(node);
    }

    private Node Clone(Node node) {
       
       
       if(map.ContainsKey(node)){
            return map[node];
       }
     
        Node newNode = new Node(node.val);
        map.Add(node, newNode);

        foreach (Node neighbor in node.neighbors){
            newNode.neighbors.Add(Clone(neighbor));
        }
        return newNode;
    }
}
