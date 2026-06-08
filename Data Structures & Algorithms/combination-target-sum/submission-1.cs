public class Solution {
    public List<List<int>> CombinationSum(int[] nums, int target) 
    {
       var result = new List<List<int>>();
        var currentCombination = new List<int>();

        // מיון המערך כדי לאפשר עצירה מוקדמת (Pruning)
        Array.Sort(nums);

        // קריאה לפונקציית העזר שמבצעת את הרקורסיה
        FindCombinations(nums, target, 0, 0, currentCombination, result);

        return result;
    }

    private void FindCombinations(int[] nums, int target, int startIndex, int currentSum, List<int> currentCombination, List<List<int>> result) 
    {
        // תנאי עצירה: מצאנו קומבינציה שסכומה שווה ליעד
        if (currentSum == target) 
        {
            // חשוב: שומרים עותק חדש של הרשימה
            result.Add(new List<int>(currentCombination));
            return;
        }

        // מעבר על כל המספרים החל מהאינדקס הנוכחי
        for (int i = startIndex; i < nums.Length; i++) 
        {
            // אם הסכום חורג מהיעד, אין טעם להמשיך לבדוק (בזכות המיון שביצענו בפונקציה הראשית)
            if (currentSum + nums[i] > target) 
            {
                break;
            }

            // 1. הוספת המספר הנוכחי לקומבינציה (Choose)
            currentCombination.Add(nums[i]);
            
            // 2. קריאה רקורסיבית (Explore)
            // מעבירים את אותו אינדקס i כדי לאפשר שימוש חוזר באותו מספר
            FindCombinations(nums, target, i, currentSum + nums[i], currentCombination, result);
            
            // 3. חזרה לאחור (Un-choose / Backtrack)
            // מוחקים את המספר האחרון שהוספנו כדי לנסות מסלולים אחרים בעץ הרקורסיה
            currentCombination.RemoveAt(currentCombination.Count - 1);
        }
    }
}
