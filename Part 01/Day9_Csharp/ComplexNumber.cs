using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9_Csharp
{
    internal class ComplexNumber
    {
        public int Real { get; set; }
        public int Imag { get; set; }

        public override string ToString()
        {
            return $"{Real} + {Imag}i";
        }

        // this
        public static ComplexNumber operator +(ComplexNumber Left, ComplexNumber Right)
        {
            // my own implementattion ?
            // Derefrencing
            return new ComplexNumber()
            {
                Real = (Left?.Real ?? 0) + (Right?.Real ?? 0),
                Imag = (Left?.Imag ?? 0) + (Right?.Imag ?? 0),
                // Left.real = lef.Real is not null ? left.Real : null >> ?  
            };
        }
        public static ComplexNumber operator -(ComplexNumber Left, ComplexNumber Right)
        {
            // my own implementattion ?
            return new ComplexNumber()
            {
                Real = Left.Real - Right.Real,
                Imag = Left.Imag - Right.Imag,
            };
        }
        public static ComplexNumber operator *(ComplexNumber Left, ComplexNumber Right)
        {
            // my own implementattion ?
            return new ComplexNumber()
            {
                Real = (Left?.Real??0) * (Right?.Real??0),
                Imag = (Left?.Imag??0) * (Right?.Imag??0)
            };
        }
    }
}
