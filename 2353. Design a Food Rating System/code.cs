public class FoodRatings {
    private Dictionary<string, (string cuisine, int rating)> foodMap;
    private Dictionary<string, SortedSet<(int rating, string food)>> cuisineMap;
    public FoodRatings(string[] foods, string[] cuisines, int[] ratings) {
        foodMap = new Dictionary<string, (string,int)>();
        cuisineMap = new Dictionary<string, SortedSet<(int,string)>>();
        
        for(int i = 0; i < foods.Length; i++)
        {
            var food = foods[i];
            var cuisine = cuisines[i];
            var rating = ratings[i];
            foodMap[food] = (cuisine,rating);

            if(!cuisineMap.ContainsKey(cuisine))
            {
                cuisineMap[cuisine] = new SortedSet<(int, string)>(
                    Comparer<(int, string)>.Create((a, b) => {
                        int cmp = b.Item1.CompareTo(a.Item1);
                        if(cmp == 0) cmp = a.Item2.CompareTo(b.Item2);
                        return cmp;
                    })
                );
            }
            cuisineMap[cuisine].Add((rating,food));
        }
    }
    
    public void ChangeRating(string food, int newRating) {
        var (cuisine, rating) =  foodMap[food];
        var sortedSet = cuisineMap[cuisine];

        foodMap[food] = (cuisine, newRating);

        sortedSet.Remove((rating, food));
        sortedSet.Add((newRating, food));

    }
    
    public string HighestRated(string cuisine) {
        var sortedSet = cuisineMap[cuisine];
        return sortedSet.Min.food;
    }
}

/**
 * Your FoodRatings object will be instantiated and called as such:
 * FoodRatings obj = new FoodRatings(foods, cuisines, ratings);
 * obj.ChangeRating(food,newRating);
 * string param_2 = obj.HighestRated(cuisine);
 */