impl Solution {
    pub fn get_concatenation(nums: Vec<i32>) -> Vec<i32> {
        let mut a:Vec<i32> = Vec::from(nums.clone());
        a.extend(nums);
        a
    }
}


struct Solution {

}

pub fn run() {
    let nums:Vec<i32> = vec![1,2,1];
    let result:Vec::<i32> = Solution::get_concatenation(nums);
    println!("Expectations:");
    println!("Input: nums = [1,2,1]");
    println!("Output: [1,2,1,1,2,1]");

    println!("Results:");
    println!("{:?}", result);
}