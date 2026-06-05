public class Solution {
    public int CharacterReplacement(string s, int k) {
        
        int[] ch = new int[26];
        int maxWindow=1;
        int left=0;
        int maxf=0;
        for(int right=0;right<s.Length; right++){

            int windowSize=right-left+1;
            ch[s[right]-'A']++;
            maxf=ch.Max();
            if((windowSize-maxf)>k){
                ch[s[left]-'A']--;
                left++;
                windowSize=right-left+1;
            }
            maxWindow=Math.Max(maxWindow,windowSize);          
        }
        return maxWindow;
    }
}
