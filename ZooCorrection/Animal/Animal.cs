using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooCorrection
{
    abstract class Animal
    {
        public Animal()
        {
            Random rand = new Random();
            IsNice = rand.Next(0, 2) == 0;
        }
        protected bool m_bIsHuntable;

        protected float m_fHeight;

        public float getIndiceMassCorporel()
        {
            return m_fHeight / m_fWeight;
        }

        public bool IsNice { get; set; }

        protected float m_fWeight;
        public float Weight
        {
            get => m_fWeight;
            set
            {
                if (value > 0)
                    m_fWeight = value;
                else
                    throw new ArgumentException();
            }
        }

        //public void setWeight(float p_fWeight)
        //{
        //    if (p_fWeight > 0)
        //        m_fWeight = p_fWeight;
        //    else
        //        throw new ArgumentException();
        //}


        //protected bool m_bIsNice;
        //public bool isNice() 
        //{ 
        //    return m_bIsNice; 
        //}
        //public void setIsNice(bool p_bIsNice) 
        //{ 
        //    m_bIsNice = p_bIsNice; 
        //}


        public bool canBeHunt() { return m_bIsHuntable; }

        abstract public void eat();
        abstract public void heal();
        abstract public void accept(VisitorCaretaker visitor);
    }
}
