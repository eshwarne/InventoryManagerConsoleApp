using System;
using System.Text;

namespace InventoryModels
{
    public class Book
    {
        string ISBN { get; set; }
        string Name { get; set; }
        public double _originalCost { get; }
        public double _discountRate { get; }
        public double Cost
        {
            get
            {
                return _originalCost - (_originalCost * _discountRate);
            }
        }
        
        public Book(string ISBN, string name, double cost, double discountRate)
        {
            this.ISBN = ISBN;
            this.Name = name;
            this._originalCost = cost;
            this._discountRate = discountRate;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("ISBN: ");
            stringBuilder.Append(this.ISBN);
            stringBuilder.Append("\n");
            stringBuilder.Append("Name: ");
            stringBuilder.Append(this.Name);
            stringBuilder.Append("\n");
            stringBuilder.Append("Cost: ");
            stringBuilder.Append(this.Cost);
            stringBuilder.Append("\n");
            return stringBuilder.ToString();
        }
    }


}
