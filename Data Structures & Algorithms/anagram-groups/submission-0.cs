public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        
        Dictionary<string, List<string>> anagramGroups = new Dictionary<string, List<string>>();
        foreach(string str in strs)
        {
            char[] chars = str.ToCharArray();
            Array.Sort(chars);
            string signature = new string(chars);
            if(anagramGroups.ContainsKey(signature))
            {
                anagramGroups[signature].Add(str);
            }
            else{
                anagramGroups.Add(signature,new List<string>{str});
            }
        }
        return new List<List<string>>(anagramGroups.Values);
    
    }
}
