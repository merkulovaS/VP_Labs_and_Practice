using System;
using System.Collections.Generic;
using Exception;


namespace Exception
{
    
    [Serializable]
    public class ExistingItemCodeException : ApplicationException
    {
        private Item _item;

        public ExistingItemCodeException() { }

        public ExistingItemCodeException(Item item)
        {
            this._item = item;

            // Заполняем Data (как в методичке)
            this.Data.Add("Артикул", _item.Code);
            this.Data.Add("Наименоваие", item.Name);
            this.Data.Add("Цвет", item.Color);
            this.Data.Add("Цена", item.Price);
        }
    }
}  