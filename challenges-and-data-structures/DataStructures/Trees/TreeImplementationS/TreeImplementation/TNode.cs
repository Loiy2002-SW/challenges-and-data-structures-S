
namespace TreeImplementation
{
    public class TNode
    {
        public int Data { get; set; }
        public TNode Left { get; set; }
        public TNode Right { get; set; }

        public TNode(int data)
        {
            Data = data;
            Left = null;
            Right = null;
        }
    }
}
