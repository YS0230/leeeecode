class Solution {
    public boolean isValid(String s) {
        Stack<Character> stack = new Stack<>();
        HashMap<Character,Character> map = new HashMap<Character,Character>();
        map.put(')', '(');
        map.put(']', '[');
        map.put('}', '{');
        for(int i=0; i<s.length(); i++){
            char c = s.charAt(i);
            if(map.containsKey(c)){
                if(stack.empty() || !map.get(c).equals(stack.pop())){
                    return false;
                }
            }else{
                stack.push(c);
            }
        }

        return stack.empty();
    }
}