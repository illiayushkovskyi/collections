using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Dictionary
{
    class Dictionary<index, content>
    {
        KeyValuePair<index, content>[] kvp = new KeyValuePair<index, content>[0];

        int position = -1;
        public object Current
        {
            get { return kvp[position]; }
        }
        public bool MoveNext()
        {
            if(position < kvp.Length -1)
            {
                position++;
                return true;
            }
            Reset();
                return false;
        }
        public void Reset()
        {
            position = -1;
        }

        public void Add(index index, content value)
        {
            KeyValuePair<index, content>[] newkvp = new KeyValuePair<index, content>[kvp.Length + 1];

            for (int i = 0; i < kvp.Length; i++)
            {
                newkvp[i] = kvp[i];
            }
            newkvp[newkvp.Length - 1] = new KeyValuePair<index, content>(index, value);
            kvp = newkvp;
        }
        public int Count
        {
            get { return kvp.Length; }
        }
        public KeyValuePair<index, content> this[int index1]
        {
            get
            {
                if (index1 >= 0 && index1 < kvp.Length)
                    return kvp[index1];
                return default;
            }
        }
        public KeyValuePair<index, content> this[index number]
        {
            get
            {
                for (int i = 0; i < kvp.Length; i++)
                {
                    if (kvp[i].Key.Equals(number))
                    {
                        return kvp[i];
                    }
                }
                return default(KeyValuePair<index, content>);
            }
        }
        public KeyValuePair<index, content> this[content text]
        {
            get
            {
                for (int i = 0; i < kvp.Length; i++)
                {
                    if (kvp[i].Value.Equals(text))
                    {
                        return kvp[i];
                    }
                }
                return default(KeyValuePair<index, content>);
            }
        }
        public IEnumerator<KeyValuePair<index, content>> GetEnumerator()
        {
            for (int i = 0; i < kvp.Length; i++)
                yield return new KeyValuePair<index, content>();
        }

        
        
            
    }
}

