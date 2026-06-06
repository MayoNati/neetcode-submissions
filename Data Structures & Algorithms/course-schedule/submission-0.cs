public class Solution {
    public bool CanFinish(int numCourses, int[][] prerequisites) {

        List<int>[] graph = new List<int>[numCourses];

        for(int i=0;i<numCourses;i++){
            graph[i]=new List<int>();
        }


        foreach (int[] pair in prerequisites) {
            graph[pair[1]].Add(pair[0]);
        } 

        int[] state = new int[numCourses];   // 0=לבן, 1=אפור, 2=שחור

        for (int i = 0; i < numCourses; i++) {
           if(HasCycle(graph,state,i)) return false;
        }

        return true;   // אף הזנקה לא מצאה מעגל
    }
    
    

    private bool HasCycle(List<int>[] graph, int[] state, int course) {

        if(state[course] == 1) return true;
        if(state[course] == 2) return false;

        state[course]=1;

        foreach(int next in graph[course]){
            if(HasCycle(graph,state,next)) return true;
        }

        state[course] = 2;   
        return false;
    }
    
}
