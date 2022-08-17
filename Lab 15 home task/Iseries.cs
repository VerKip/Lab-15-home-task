using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_15_home_task
{
    interface Iseries
    {
        void setStart(int x);
        int getNext();
        void reset(); 
    }

    class ArithProgression : Iseries
    {
        int step;
        int setValue;
        int currentValue;
        public int getNext()
        {
            currentValue += step;
            return currentValue;
        }

        public void reset()
        {
            currentValue = setValue;
        }

        public void setStart(int x)
        {
            setValue=x;
            currentValue=setValue;
        }
        public void setStep(int s)
        {
            step=s;
        }
    }

    class GeomProgression : Iseries
    {
        int step;
        int setValue;
        int currentValue;
        public int getNext()
        {
            currentValue = step*currentValue;
            return currentValue;
        }

        public void reset()
        {
            currentValue = setValue;
        }

        public void setStart(int x)
        {
            setValue = x;
            currentValue = setValue;
        }
        public void setStep(int s)
        {
            step = s;
        }
    }
}
