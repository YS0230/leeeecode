class Solution:
    def floodFill(self, image: List[List[int]], sr: int, sc: int, color: int) -> List[List[int]]:
        old_color = image[sr][sc]

        def DFS(x: int, y: int):
            if x < 0 or x >= len(image) or y < 0 or y >= len(image[0]):
                return        
            if image[x][y] != old_color:
                return
            image[x][y] = color
      
            DFS(x - 1, y)            
            DFS(x + 1, y)
            DFS(x, y - 1)
            DFS(x, y + 1)
        
            return
        
        if old_color != color:
            DFS(sr, sc)

        return image