enum Color {
    RED,
    BLACK
}

class SimpleNode {
    int value;
    Color color;
    SimpleNode left;
    SimpleNode right;

    SimpleNode(int value, Color color) {
        this.value = value;
        this.color = color;
        this.left = null;
        this.right = null;
    }
}


public class SimpleRedBlackTreeExample{
    public static void printTree(SimpleNode node, String prefix) {
        if (node != null) {
            System.out.println(prefix + node.value + "(" + node.color + ")");
            printTree(node.left, prefix + "--");
            printTree(node.right, prefix + "--");
        }
    }


    public static void main(String[] args) {
        SimpleNode root = new SimpleNode(10, Color.BLACK);
        root.left = new SimpleNode(5, Color.RED);
        root.right = new SimpleNode(15, Color.BLACK);
        root.left.left = new SimpleNode(3, Color.BLACK);
        root.left.right = new SimpleNode(7, Color.BLACK);
        root.right.left = new SimpleNode(13, Color.RED);
        root.right.right = new SimpleNode(17, Color.RED);

        printTree(root, "");
    }
}
