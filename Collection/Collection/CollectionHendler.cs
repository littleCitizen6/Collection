using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Collection
{
    class CollectionHendler
    {
        public void ListOperations(List<string> list)  
        {
            if (list.Count() > 1)
            {
                list.RemoveAt(list.Count / 2);
                if (list.Contains("mamas"))
                {
                    list.Add("6");
                }
                if (list.IndexOf("aram") % 2 == 1)
                {
                    list.Reverse();
                }
                if (list.Distinct().Count() == 3)
                {
                    list.InsertRange(2, new[] { "2", "3", "4" });
                }
            }
        }

        public void DictionaryOperations(Dictionary<string,int> dict)
        {
            string scubaKey = dict.Keys.FirstOrDefault(key => key == "scuba");
            int scubaValue;
            if(scubaKey!=null && dict.TryGetValue(scubaKey, out scubaValue) && scubaValue == 6)
            {
                dict.Add("Empire", 6);
            }
        } 

        public void StackOperations(Stack<DateTime> st)
        {
            if (st.Count > 0)
            {
                if (st.Peek() < DateTime.Now)
                {
                    st.Pop();
                    st.Push(DateTime.Now);
                }
            }
            Console.WriteLine("inserted empty stack");
        }
    }
}
