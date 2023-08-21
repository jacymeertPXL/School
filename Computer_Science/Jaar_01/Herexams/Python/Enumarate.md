![[Copy of python enumerate_42023-1.webp]]
![[Copy of python enumerate_42023.webp]]
The code above would throw an error — TypeError: ‘set’ object is not subscriptable. This is because targeting an index is incompatible in a set. However, if we enumerate the set, we can use the counter as an index to find our item.

![Python enumerate function example](https://blog.hubspot.com/hubfs/Google%20Drive%20Integration/Copy%20of%20python%20enumerate_42023-4.png)

The above code would print to the console the following result. But remember, sets are unordered, so the items returned may vary.

![Python enumerate function example](https://blog.hubspot.com/hubfs/Google%20Drive%20Integration/Copy%20of%20python%20enumerate_42023-Jun-07-2023-01-36-40-6466-PM.png)

It's important to note that this does not alter the value of pizza. Printing it to the console will give us the same set we declared, likely in a different order.

![Python enumerate function example](https://blog.hubspot.com/hubfs/Google%20Drive%20Integration/Copy%20of%20python%20enumerate_42023-Jun-07-2023-01-36-41-1816-PM.png)

To preserve the effect of the enumerate function on a set, you will need to convert the results to a different data type. Let's look at an example of how we can do that using the list constructor function.

![Python enumerate function example](https://blog.hubspot.com/hubfs/Google%20Drive%20Integration/Copy%20of%20python%20enumerate_42023-Jun-07-2023-01-36-40-8032-PM.png)

First, we create the set. Then we run the enumerate function providing our set and save that to a new variable. Finally, the result of the enumeration is then provided to the list constructor and saved as a new list object. The data inside of this new setlist object would look like a list of key/value pairs.

![Python enumerate function example](https://blog.hubspot.com/hubfs/Google%20Drive%20Integration/Copy%20of%20python%20enumerate_42023-Jun-07-2023-01-36-40-4596-PM.png)

#Python