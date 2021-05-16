using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBookLib
{
    public delegate int Compare<T>(T obj);
    public class RedBlackTree<T> where T : IComparable<T>
    {
        private readonly List<RedBlackNode<T>> list = new List<RedBlackNode<T>>(); //нужен только для удобной конвертации в массив и поиска по другим свойствам
        public RedBlackNode<T> Root
        {
            get
            {
                return list.Where(o => o.Owner == null).FirstOrDefault();
            }
        }
        public int Count
        {
            get
            {
                return list.Count;
            }
        }
        public List<T> List
        {
            get
            {
                return list.Select(s => s.Value).ToList();
            }
        }
        //public RedBlackNode<T> Root { get; set; }
        public void Add(T value)
        {
            if (Root == null)
            {
                list.Add(new RedBlackNode<T>(value) { IsBlack = true });
                return;
            }
            RedBlackNode<T> target = Root;
            RedBlackNode<T> parent = null;
            while (target != null)
            {
                int compare = target.Value.CompareTo(value);
                if (compare == 0)
                    return;
                parent = target;
                if (compare > 0)
                {
                    //меньше
                    target = target.Left;
                }
                else
                {
                    //больше
                    target = target.Right;
                }
            }
            int c = parent.Value.CompareTo(value);
            var newNode = new RedBlackNode<T>(value);
            list.Add(newNode);
            if (c > 0)
            {
                parent.Left = newNode;
                parent.Left.Balance();
            }
            else
            {
                parent.Right = newNode;
                parent.Right.Balance();
            }

        }
        public void Delete(T value)
        {
            var node = findNode(value);
            list.Remove(node);
            if (!node.HasChildren)
            {
                if (Root == node)
                {
                    list.Remove(node);
                }
                else
                {
                    if (node.Owner.Left == node)
                        node.Owner.Left = null;
                    else
                        node.Owner.Right = null;
                }
                return;
            }
            RedBlackNode<T> y = null;
            if (node.OneChild)
            {
                var child = node.Left != null ? node.Left : node.Right;
                if (node.Owner == null)
                {
                    node.Right.Owner = null;
                }
                else
                {
                    if (node.Owner.Left == node)
                    {
                        node.Owner.Left = child;
                    }
                    else
                    {
                        node.Owner.Right = child;
                    }
                }
            }
            else
            {

                y = node.Right;
                while (y.Left != null)
                    y = y.Left;
                if (y.Right != null)
                    y.Right.Owner = y.Owner;
                if (Root == y)
                    y.Right.Owner = null;
                else
                {
                    if (y.Owner.Left == y)
                    {
                        y.Owner.Left = y.Left;
                    }
                    else
                    {
                        y.Owner.Right = y.Left;
                    }
                }
            }
            if (y != null)
            {
                if (y != node)
                {
                    node.IsRed = y.IsRed;
                    node.Value = y.Value;
                }
                if (y.IsBlack)
                    y.FixDelete();
            }

        }
        private RedBlackNode<T> findNode(T value)
        {
            var p = Root;
            int c = value.CompareTo(p.Value);
            while (c != 0)
            {
                if (c > 0)
                {
                    p = p.Right;
                }
                else
                {
                    p = p.Left;
                }
                if (p == null)
                    return null;
                c = value.CompareTo(p.Value);
            }
            return p;
        }
        public T Find(Compare<T> compare)
        {
            var p = Root;
            int c = compare(p.Value);
            while (c != 0)
            {
                if (c > 0)
                {
                    p = p.Left;
                }
                else
                {
                    p = p.Right;
                }
                if (p == null)
                    return (T)(object)null;
                c = compare(p.Value);
            }
            return p.Value;
        }
    }
}
