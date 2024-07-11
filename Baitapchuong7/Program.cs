using System.Text;
using System.Collections.Generic;

namespace Bai47
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Dictionary<int, string> dictionary = new Dictionary<int, string>();

            dictionary.Add(1, "Apple");
            dictionary.Add(2, "Banana");
            dictionary.Add(3, "Chery");
            dictionary.Add(4, "Watermelon");

            int keyToCheck = 1;
            if(dictionary.ContainsKey(keyToCheck))
            {
                Console.WriteLine($"key {keyToCheck} tồn tại trong từ điển");
            }
            else
            {
                Console.WriteLine($"key {keyToCheck} không tồn tại");
            }

            int keyToRetrieve = 2;
            if(dictionary.TryGetValue(keyToRetrieve, out string value))
            {
                Console.WriteLine($"Giá trị với key {keyToRetrieve} là: {value}");
            }
            else
            {
                Console.WriteLine($"key {keyToRetrieve} không tìm thấy trong từ điển");
            }
            Console.WriteLine("DANH SÁCH");
            foreach(KeyValuePair<int, string> kvp in  dictionary)
            {
                Console.WriteLine($"Key: {kvp.Key}, value: {kvp.Value}");
            }
        }
    }
}
