public class Solution {
    public string MinWindow(string s, string t) {
        Dictionary<char,int> t_dic = new Dictionary<char,int>();

        var need = new Dictionary<char, int>();
        foreach (char c in t) {
            if (!need.TryAdd(c, 1)) need[c]++;
        }
        int needCount = need.Count;

        var window = new Dictionary<char, int>();
        int have = 0, left = 0;
        int minLen = Int32.MaxValue, minStart = 0;

        for (int right = 0; right < s.Length; right++) {
            char c = s[right];
            if (!window.TryAdd(c, 1)) window[c]++;
            if (need.ContainsKey(c) && window[c] == need[c]) {
                have++;
            }

            while (have == needCount) {
                if (right - left + 1 < minLen) {
                    minLen = right - left + 1;
                    minStart = left;
                }
                char d = s[left];
                window[d]--;
                if (need.ContainsKey(d) && window[d] < need[d]) {
                    have--;
                }
                left++;
            }
        }

        return minLen == Int32.MaxValue ? "" : s.Substring(minStart, minLen);

    }
}
