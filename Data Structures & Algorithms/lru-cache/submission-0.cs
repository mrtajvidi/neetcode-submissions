public class Node {
    public int Key { get; set; }
    public int Val { get; set; }
    public Node Prev { get; set; }
    public Node Next { get; set; }

    public Node(int key, int val) {
        Key = key;
        Val = val;
        Prev = null;
        Next = null;
    }
}

public class LRUCache {
    private int _cap;
    private Dictionary<int, Node> _cache;
    private Node left;
    private Node right;

    public LRUCache(int capacity) {
        _cap = capacity;
        _cache = new Dictionary<int, Node>();
        left = new Node(0, 0);
        right = new Node(0, 0);
        left.Next = right;
        right.Prev = left;
    }
    
    public int Get(int key) {
        if (_cache.ContainsKey(key))
        {
            Node node = _cache[key];
            Remove(node);
            Insert(node);
            return node.Val;
        }
        return -1;
    }

    private void Remove(Node node)
    {
        var next = node.Next;
        var prev = node.Prev;

        next.Prev = prev;
        prev.Next = next;
    }

    // insert in the right
    private void Insert(Node node)
    {   
        var prev = right.Prev;
        prev.Next = node;
        node.Prev = prev;
        node.Next = right;
        right.Prev = node;
    }
    
    public void Put(int key, int value) {
        if (_cache.ContainsKey(key))
        {
            Remove(_cache[key]);
        }
        Node node = new Node(key, value);
        Insert(node);
        _cache[key] = node;

        if (_cache.Count > _cap)
        {
            Node lru = left.Next;
            Remove(lru);
            _cache.Remove(lru.Key);
        }
    }
}
