public class Solution {
    public bool IsPalindrome(string s) {
        char[] poli = s.ToCharArray();
        string clean="";
        for(int i=0;i<poli.Length;i++)
        {
            if( poli[i]>='a' && poli[i]<='z' ||
                poli[i]>='A' && poli[i]<='Z' ||
                poli[i]>='0' && poli[i]<='9' 
             )
            {
                clean+=poli[i];
            }
        }
        
        clean=clean.ToLower();
        char[] poli_clean = clean.ToCharArray();

        int size = poli_clean.Length;
        int low=0;
        int high= size-1;
        while(low<high){
            if(poli_clean[low] != poli_clean[high]){
                return false;
            }
            low++;
            high--;
        }
        return true;
        
    }
}
