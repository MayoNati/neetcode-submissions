public class Solution {
    public int NumIslands(char[][] grid) {

        int count=0;
        for(int row=0;row<grid.Length;row++)
        {
            for(int col=0;col<grid[0].Length;col++)
            {
                if(grid[row][col]=='1'){
                    count++;
                    DeepIsland(grid,row,col);
                }
            }
        } 
        return count;

    }

    private void DeepIsland(char[][] grid,int row,int col){

        if(row>=grid.Length || row<0 || col >= grid[0].Length || col < 0 ){
            return;
        }

        if(grid[row][col]=='1'){
            grid[row][col]='0';

            if(row+1<grid.Length && grid[row+1][col]=='1')
                DeepIsland(grid,row+1,col);
            
            if(col+1<grid[0].Length && grid[row][col+1]=='1')    
                DeepIsland(grid,row,col+1);

            if(row-1>=0 && grid[row-1][col]=='1')
                DeepIsland(grid,row-1,col);

            if(col-1>=0 && grid[row][col-1]=='1')
                DeepIsland(grid,row,col-1);

        }

        return;
    }
}
