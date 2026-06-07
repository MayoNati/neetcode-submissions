/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

public class Solution {    
    public bool IsSubtree(TreeNode root, TreeNode subRoot) {

        if(root==null){
            return false;
        }
        
        else if(root==null && subRoot==null)
        {
            return true;
        }
        else if(root!=null && subRoot!=null){
            if(!IsSameTree(root,subRoot))
            {
                return IsSubtree(root.left,subRoot) || IsSubtree(root.right,subRoot);
            }
            else
            {
                return true;
            }
        }
        return false;
    }

    public bool IsSameTree(TreeNode p, TreeNode q) {
        
        if(p==null && q==null){
            return true;
        }
        else if(p!=null && q!=null){
            if(p.val==q.val)
                return IsSameTree(p.right,q.right) && IsSameTree(p.left,q.left);
        }
        
        return false;
    }
}
