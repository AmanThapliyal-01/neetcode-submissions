class MyHashMap {

    private int[] bol;
    public MyHashMap() {
        bol = new int[1000001];
        java.util.Arrays.fill(bol, -1);
    }
    
    public void put(int key, int value) {
        bol[key]=value;
    }
    
    public int get(int key) {
        return bol[key];
    }
    
    public void remove(int key) {
        bol[key]=-1;
    }
}

/**
 * Your MyHashMap object will be instantiated and called as such:
 * MyHashMap obj = new MyHashMap();
 * obj.put(key,value);
 * int param_2 = obj.get(key);
 * obj.remove(key);
 */