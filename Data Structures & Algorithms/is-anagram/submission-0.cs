public class Solution {
    public bool IsAnagram(string s, string t) {

        if(s.Length != t.Length){
            return false;
        }
        s=String.Concat(s.OrderBy(c => c));
        t=String.Concat(t.OrderBy(c => c));

        if(s==t){
            return true;
        }
        return false;

    }
}
