public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        
        int[] array = new int[2001];
        List<int>[] buckets = new List<int>[nums.Length + 1];

        foreach(int num in nums){
            array[num+1000]++;
        }

        for(int i=0;i<array.Length;i++)
        {
           
            int freq=array[i];
            if(freq>0){
                int originalNum=i-1000;

                if(buckets[freq]==null){
                    buckets[freq]=new List<int>();
                }
                buckets[freq].Add(originalNum);
            }
        }

        int[] result = new int[k];
        int resultIndex = 0;
        for(int f=buckets.Length-1;f>=0 && resultIndex < k;f--){
            if(buckets[f]!=null){
                foreach(int num in buckets[f]){
                    result[resultIndex]=num;
                    resultIndex++;

                    if (resultIndex == k) {
                        return result;
                    }
                }
            }
        }
        return result;

    }
}
