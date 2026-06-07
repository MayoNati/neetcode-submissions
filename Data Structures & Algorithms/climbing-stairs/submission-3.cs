public class Solution {
    public int ClimbStairs(int n) {   

        int result=0;
        if (n <= 2) return n;        
        int prev = 1;                   // ways של לפני-שתיים
        int curr = 2;                   // ways של הקודמת
        for(int i=3;i<=n;i++){
            int next= prev+curr;
            prev=curr;
            curr=next;
        }
        return curr;
    }
}
