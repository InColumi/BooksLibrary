using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBookLib
{
    public class RedBlackNode<T>
    {
        private RedBlackNode<T> _left;
        private RedBlackNode<T> _right;
        private bool _color = true; //R-1 B-0
        public T Value { get; set; }
        public RedBlackNode<T> Left
        {
            get => _left;
            set
            {
                _left = value;
                if (value != null)
                    value.Owner = this;
            }
        }
        public RedBlackNode<T> Right
        {
            get => _right;
            set
            {
                _right = value;
                if(value != null)
                    value.Owner = this;
            }
        }
        public RedBlackNode<T> Owner { get; set; }
        public RedBlackNode<T> Root { get
            {
                var own = this;
                while (own.Owner != null)
                {
                    own = own.Owner;
                }
                return own;
            }
        }
        public RedBlackNode<T> GrandFather
        {
            get
            {
                return Owner.Owner;
            }
        }
        public RedBlackNode<T> Uncle
        {
            get
            {
                if (GrandFather.Left == Owner)
                    return GrandFather.Right;
                return GrandFather.Left;
            }
        }
        public RedBlackNode<T> Brother
        {
            get
            {
                if (Owner.Left == this)
                    return Owner.Right;
                return Owner.Left;
            }
        }
        public bool IsRed
        {
            get
            {
                return _color;
            }
            set
            {
                _color = value;
            }
        }
        public bool IsBlack
        {
            get
            {
                return !_color;
            }
            set
            {
                _color = !value;
            }
        }
        public bool HasChildren
        {
            get
            {
                return Left != null || Right != null;
            }
        }
        public bool OneChild
        {
            get
            {
                return Left != null ^ Right != null;
            }
        }
        public RedBlackNode(T value)
        {
            this.Value = value;
        }
        public void Balance()
        {
            if (Check())
            {
                while (Owner.IsRed)
                {
                    if(Owner == GrandFather.Left)
                    {
                        if(Uncle != null)
                        {
                            if (Uncle.IsRed)
                            {
                                Owner.IsBlack = true;
                                Uncle.IsBlack = true;
                                GrandFather.IsRed = true;
                                IsRed = GrandFather.IsRed;
                            }
                        }
                        else
                        {
                            if(Owner.Right == this)
                            {
                                IsRed = Owner.IsRed;
                                this.LeftRotate();
                            }
                            Owner.IsBlack = true;
                            GrandFather.IsRed = true;
                            GrandFather.RightRotate();
                        }
                    }
                    else
                    {
                        if (Uncle != null)
                        {
                            if (Uncle.IsRed)
                            {
                                Owner.IsBlack = true;
                                Uncle.IsBlack = true;
                                GrandFather.IsRed = true;
                                IsRed = GrandFather.IsRed;
                            }
                        }
                        else
                        {
                            if (Owner.Left == this)
                            {
                                IsRed = Owner.IsRed;
                                this.RightRotate();
                            }
                            Owner.IsBlack = true;
                            GrandFather.IsRed = true;
                            GrandFather.LeftRotate();
                        }
                    }
                }
                Root.IsBlack = true;
                Owner.Balance();
            }
        }
        public void FixDelete()
        {
            var p = this;
            while(IsBlack & Root != this)
            {
                if(p.Owner.Left == this)
                {
                    if (p.Brother.IsRed)
                    {
                        p.Brother.IsBlack = true;
                        p.Owner.IsRed = true;
                        p.Owner.LeftRotate();
                    }
                    if(p.Brother.HasChildren && (p.Brother.Left != null && p.Brother.Left.IsBlack || p.Brother.Right != null && p.Brother.Right.IsBlack))
                    {
                        p.Brother.IsRed = true;
                    }
                    else
                    {
                        if (p.Brother.Right.IsBlack)
                        {
                            p.Brother.Left.IsBlack = true;
                            p.Brother.IsRed = true;
                            p.Brother.RightRotate();
                        }
                        p.Brother.IsRed = p.Owner.IsRed;
                        p.Owner.IsBlack = true;
                        p.Brother.Right.IsBlack = true;
                        p.Owner.LeftRotate();
                        p = Root;
                    }
                }
                else
                {
                    if (p.Brother.IsRed)
                    {
                        p.Brother.IsBlack = true;
                        p.Owner.IsRed = true;
                        p.Owner.RightRotate();
                    }
                    if (p.Brother.HasChildren && (p.Brother.Left != null && p.Brother.Left.IsBlack || p.Brother.Right != null && p.Brother.Right.IsBlack))
                    {
                        p.Brother.IsRed = true;
                    }
                    else
                    {
                        if (p.Brother.Left.IsBlack)
                        {
                            p.Brother.Right.IsBlack = true;
                            p.Brother.IsRed = true;
                            p.Brother.LeftRotate();
                        }
                        p.Brother.IsRed = p.Owner.IsRed;
                        p.Owner.IsBlack = true;
                        p.Brother.Right.IsBlack = true;
                        p.Owner.RightRotate();
                        p = Root;
                    }
                }
            }
        }
        public void LeftRotate()
        {
            var tOwner = Owner.Owner;
            Owner.Right = Left;
            Left = Owner;
            Owner = tOwner;
        }
        public void RightRotate()
        {
            var tOwner = Owner.Owner;
            Owner.Left = Right;
            Right = Owner;
            Owner = tOwner;
        }
        private bool Check()
        {
            if (IsRed)
            {
                return (Left != null && Left.IsRed) || (Right != null && Right.IsRed);
            }
            return false;
        }
    }
}
