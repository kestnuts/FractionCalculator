using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FractionCalculator___Michael_Kestner
{
    public class Fraction
    {
        private int _Numerator;
        private int _Denominator;
        public Fraction(int theNumerator, int theDenominator)
        {

            _Numerator = theNumerator;
            _Denominator = theDenominator;

            if (_Numerator == 0)
            {
                throw new System.ArgumentException("Parameter cannot be Zero!", "numerator");
            }
            else if (_Denominator == 0)
            {
                throw new System.ArgumentException("Parameter cannot be Zero!", "denominator");
            }
            else
            {
                Reduce(_Numerator, _Denominator);
            }
        }
        public int Numerator//read only property for numerator
        {
            get
            {
                return _Numerator;
            }
        }//end Numerator
        public int Denominator//read only property for denominator
        {
            get
            {
                return _Denominator;
            }
        }//end Denominator

            
        
        //allows the user to create an "empty" fraction
        //by initializing a fraction of 1/1
        public Fraction() : this(1, 1) { }

        private int GCF(int left, int right)//method that takes in two numbers and finds the 
            //Greatest Common Factor (GCF)
        {
            int GCF;
            int remainder;
            int a = left;
            int b = right;
            
            while (b != 0)
            {
                remainder = a % b;
                a = b;
                b = remainder;
            }//end while
            GCF = a;
            return GCF;
        }
        private void Reduce(int numerator, int denominator)
        {
            if (numerator < 0 && denominator < 0)//if numerator and denominator are both negative, 
            {                                    // convert both to a positive
                numerator *= -1;
                denominator *= -1;

            }
            else if (numerator > 0 && denominator < 0)//if numerator is positive, but the denominator is negative
                //convert the numerator to a negative and the denominator to a positive
            {
                numerator *= -1;
                denominator *= -1;
            }
            

            int a = GCF(numerator, denominator);
            
            _Numerator = numerator / a;//reduce the numerator
            _Denominator = denominator / a;//reduce the denominator

            
        }//end Reduce
        public Fraction Add(Fraction rightFrac)
        {

            if(this.Denominator == rightFrac.Denominator)
            {
               return new Fraction((_Numerator + rightFrac.Numerator), _Denominator);
                
            }
            else
            {
            return new Fraction((_Numerator * rightFrac.Denominator) + (rightFrac.Numerator * _Denominator),
                                  ( _Denominator * rightFrac.Denominator));
            
            }
            
            
        }
        public Fraction Subtract(Fraction rightFrac)
        {
            return new Fraction(((this.Numerator * rightFrac.Denominator) - (rightFrac.Numerator * this.Denominator)),
                (this.Denominator * rightFrac.Denominator));
            
        }
        public Fraction Multiply(Fraction rightFrac)
        {
            int newNum = this.Numerator * rightFrac.Denominator;
            int newDenom = this.Denominator * rightFrac.Denominator;
            return new Fraction(newNum, newDenom);

        }
        public Fraction Divide(Fraction rightFrac)
        {
            return new Fraction((this.Numerator * rightFrac.Denominator), (rightFrac.Numerator * this.Denominator));

        }
        public override string ToString()
        {
            return Numerator + "/" + Denominator;
        }
        public string ToFloatString(int digits)
        {
            if (digits < 1)
            {
                throw new ArgumentOutOfRangeException("Digits must be a non negative integer!");
            }
           
            double fractionAsNum = Numerator / Denominator;
            return fractionAsNum.ToString("f" + digits);
        }
    }
}
