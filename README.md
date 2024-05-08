# Intuition
The problem asks us to determine the rank of athletes based on their scores. Since the scores are unique, we can sort them to determine the order of ranking. The challenge lies in providing the appropriate labels for the top three ranks ("Gold Medal", "Silver Medal", and "Bronze Medal"), while the rest of the athletes are assigned their placement as an integer.

# Approach
The approach involves the following steps:

1. Mapping Scores with Indices: Create a list of tuples containing the score and its index in the original array. This will help us track the original position of each athlete.
2. Sort the Scores: Sort the list of tuples based on the scores in descending order. This places the highest scores at the beginning of the list.
3. Assign Ranks: Iterate through the sorted list and assign the top three athletes the respective ranks of "Gold Medal", "Silver Medal", and "Bronze Medal". For athletes placed fourth or lower, assign their respective placement number as their rank.
4. Prepare the Output: Use the indices from the sorted list to place the assigned ranks into an array in the same order as the original scores.
This approach efficiently ranks the athletes based on their scores and provides the correct rank for each athlete.

# Complexity
- Time complexity:
The overall time complexity is O(nlogn) due to sorting the list of tuples based on scores. Creating the list and iterating through it to assign ranks each take O(n), but the sorting step dominates the complexity.
- Space complexity:
The space complexity is O(n) since we create a list of tuples (to store scores and indices) and an output array (to store the ranks).
