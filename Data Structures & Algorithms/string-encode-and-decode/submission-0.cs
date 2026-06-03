public class Solution {

    public string Encode(IList<string> strs) {
        
        if(strs.Count==0)
        {
            return "";
        }
        StringBuilder sb = new StringBuilder();
        foreach(string str in strs){
            sb.Append(str.Length).Append('#').Append(str);
       }
       return sb.ToString();
    }

    public List<string> Decode(string s) 
    {
        List<string> result = new List<string>();
        if(s.Length==0){
            return result;
        }
        int i=0;
        
        while(i<s.Length)
        {
            
            int seperator=s.IndexOf('#',i);
            int size=int.Parse(s.Substring(i,seperator-i));
            
            string str_result=s.Substring(seperator+1,size);
            result.Add(str_result);
            i=seperator+size+1;
        }
        return result;
    }
}
