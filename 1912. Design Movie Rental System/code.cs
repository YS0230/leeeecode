public class MovieRentingSystem {
    private SortedSet<(int price, int shop, int movie)> rentSet;
    private Dictionary<int,SortedSet<(int price, int shop)>> movieMap;
    private Dictionary<string,int> priceDict;

    public MovieRentingSystem(int n, int[][] entries) {
        priceDict = new Dictionary<string, int>();
        rentSet = new SortedSet<(int, int, int)>();
        movieMap = new Dictionary<int, SortedSet<(int, int)>>();
        foreach(var item in entries)
        {
            var shop = item[0];
            var movie = item[1];
            var price = item[2];
            priceDict[$"{shop}-{movie}"] = price;

            if(!movieMap.ContainsKey(movie))
                movieMap[movie] = new SortedSet<(int,int)>();
            movieMap[movie].Add((price, shop));
        }
    }
    
    public IList<int> Search(int movie) {
        if (!movieMap.ContainsKey(movie)) return [];
        var ans = new List<int>();
        foreach(var item in movieMap[movie])
        {
            if(ans.Count == 5) break;
            if(!rentSet.Contains((item.price, item.shop, movie)))
                ans.Add(item.shop);
        }
        return ans;
    }
    
    public void Rent(int shop, int movie) {
        rentSet.Add((priceDict[$"{shop}-{movie}"] , shop, movie));
    }
    
    public void Drop(int shop, int movie) {     
        rentSet.Remove((priceDict[$"{shop}-{movie}"] , shop, movie));
    }
    
    public IList<IList<int>> Report() {
        if(rentSet.Count == 0) return [];
        var min = Math.Min(5, rentSet.Count);
        var ans = new int[min][];
        var idx = 0;
        foreach(var item in rentSet)
        {
            if(min == idx) break;
            ans[idx] = new int[2];
            ans[idx][0] = item.shop;
            ans[idx][1] = item.movie;
            idx++;
        }
        return ans;
    }
}

/**
 * Your MovieRentingSystem object will be instantiated and called as such:
 * MovieRentingSystem obj = new MovieRentingSystem(n, entries);
 * IList<int> param_1 = obj.Search(movie);
 * obj.Rent(shop,movie);
 * obj.Drop(shop,movie);
 * IList<IList<int>> param_4 = obj.Report();
 */