public class TaskManager {
    private Dictionary<int, (int user, int proirity)> taskUserMap;
    private SortedSet<(int priority, int taskId)> sortedSet;
    public TaskManager(IList<IList<int>> tasks) {
        sortedSet = new SortedSet<(int, int)>(
            Comparer<(int, int)>.Create((a, b) =>{
                int cmp = b.Item1.CompareTo(a.Item1);
                if(cmp == 0) cmp = b.Item2.CompareTo(a.Item2);
                return cmp;
            })
        );
        taskUserMap = new Dictionary<int, (int, int)>();

        foreach(var task in tasks)
        {
            var userId = task[0];
            var taskId = task[1];
            var priority = task[2];
            sortedSet.Add((priority, taskId));
            taskUserMap[taskId] = (userId, priority);
        }
    }
    
    public void Add(int userId, int taskId, int priority) {
        sortedSet.Add((priority, taskId));
        taskUserMap[taskId] = (userId, priority);
    }
    
    public void Edit(int taskId, int newPriority) {
        var (userId, priority) = taskUserMap[taskId];
        sortedSet.Remove((priority,taskId));
        sortedSet.Add((newPriority, taskId));
        taskUserMap[taskId] = (userId, newPriority);
    }
    
    public void Rmv(int taskId) {        
        var (userId, priority) = taskUserMap[taskId];
        sortedSet.Remove((priority, taskId));
    }
    
    public int ExecTop() {
        if(!sortedSet.Any()) return -1;
        var (priority, taskId) = sortedSet.Min;
        sortedSet.Remove((priority, taskId));
        
        return taskUserMap[taskId].Item1;
    }
}

/**
 * Your TaskManager object will be instantiated and called as such:
 * TaskManager obj = new TaskManager(tasks);
 * obj.Add(userId,taskId,priority);
 * obj.Edit(taskId,newPriority);
 * obj.Rmv(taskId);
 * int param_4 = obj.ExecTop();
 */