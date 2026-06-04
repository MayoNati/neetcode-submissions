public class Solution {
    public bool IsPalindrome(string s) {
        s=s.ToLower();
        int low=0;
        int high=s.Length-1;

        while(low<high){

            while(low<high && !char.IsLetterOrDigit(s[low]))
            {
               low++;     
            }
            while(low<high && !char.IsLetterOrDigit(s[high])){
               high--;     
            }
            if(s[low]!=s[high]){
                return false;
            }
            low++;  
            high--;   
        }
        
        return true;
        
    }
}
