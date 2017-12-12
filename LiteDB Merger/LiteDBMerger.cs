using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LiteDB_Merger
{
    static class LiteDBMerger
    {
        public static int Merge(List<string> Ins, string Out)
        {
            Dictionary<string, int> indices = new Dictionary<string, int>();

            int num = 0;
            using (var Outdb = new LiteDatabase(Out))
            {
                foreach(string In in Ins)
                {
                    using (var Indb = new LiteDatabase(In))
                    {
                        foreach(string CollectionName in Indb.GetCollectionNames())
                        {
                            LiteCollection<object> OutCollection = Outdb.GetCollection<object>(CollectionName);

                            LiteCollection<object> Collection = Indb.GetCollection<object>(CollectionName);
                            List<object> Items = Collection.Find(Query.All()).ToList();

                            if (!indices.Keys.Contains<string>(CollectionName))
                            {
                                indices[CollectionName] = 0;
                            }


                            foreach(object Item in Items)
                            {
                                num++;
                                OutCollection.Insert(indices[CollectionName], Item);
                                indices[CollectionName]++;
                            }
                        }
                    }
                }
            }

            return num;
        }
    }
}
