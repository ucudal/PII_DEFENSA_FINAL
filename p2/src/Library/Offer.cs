using System;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Ucu.Poo.Defense
{
    public class Offer
    {
        public DateTime EndDate { get; set; }

        public IReadOnlyCollection<OfferItem> Items
        {
            get
            {
                return new ReadOnlyCollection<OfferItem>(this.items);
            }
        }

        private IList<OfferItem> items = new List<OfferItem>();

        public Offer(DateTime endDate)
        {
            this.EndDate = endDate;
        }

        public void AddItem(OfferItem item)
        {
            this.items.Add(item);
        }

        public void RemoveItem(OfferItem item)
        {
            this.items.Remove(item);
        }

        public StringBuilder TextoOferta = new StringBuilder();
        
        public string AsText(){
            
            foreach(OfferItem item in items){
                TextoOferta.Append(item.Quantity);
                TextoOferta.Append(" de ");
                TextoOferta.Append(item.Residue);
                TextoOferta.Append(" a ");
                TextoOferta.Append(item.Price);
            }
            return TextoOferta;
        }
    }
}