using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace collectionofstamp.Models
{
    public static class DisplayManager
    {
        public static void DisplayAllStamps(DataGridView dataGridView, List<Stamp> stamps)
        {
            dataGridView.Rows.Clear();
            foreach (var stamp in stamps)
            {
                dataGridView.Rows.Add(
                    stamp.Naming,
                    stamp.Country,
                    stamp.Price,
                    stamp.Year,
                    stamp.Circulation,
                    stamp.Features);
            }
        }
        public static void DisplayAllCollectors(DataGridView dataGridView, List<Collector> collectors)
        {
            dataGridView.Rows.Clear();
            foreach (var collector in collectors)
            {
                dataGridView.Rows.Add(
                    collector.Country,
                    collector.Name,
                    collector.ContactData,
                    collector.RareStamps);
            }
        }
        public static void DisplayAllMyCollection(DataGridView dataGridView, List<Stamp> myCollection)
        {
            dataGridView.Rows.Clear();
            foreach (var stamp in myCollection)
            {
                dataGridView.Rows.Add(
                    stamp.Naming,
                    stamp.Country,
                    stamp.Price,
                    stamp.Year,
                    stamp.Circulation,
                    stamp.Features);
            }
        }
    }
}
