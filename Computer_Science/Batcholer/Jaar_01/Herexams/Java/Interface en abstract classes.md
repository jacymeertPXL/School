**1. Let’s create an Interface at first:**
````java
// creating an interface named GFG
interface GFG {
	void learnCoding();
	void learnProgrammingLanguage();
	void contribute();
}
`````
Here the three  non-implemented methods are the abstract methods

**2. Now let’s implement the interface in an Abstract class named Student:**
````java
// creating an abstract class named Student which is
// implementing the interface,GFG
abstract class Student implements GFG {

	// Overriding two methods of the interfacem,GFG
	@Override public void learnCoding()
	{
		System.out.println(
			"Let's make coding a habit with GFG");
	}
	@Override public void learnProgrammingLanguage()
	{
		System.out.println(
			"Let's master all fundamentals of java with the help of GFG");
	}
}
`````
Here we have overridden two abstract methods of the interface  GFG.

**3. Now let’s create a class GEEK which extends the abstract class, Student:**

As previously mentioned, we can’t create an instance of our abstract class therefore we need to make a non-abstract class.
````java
// creating an non-abstract class
// GEEK which is extending Student
class GEEK extends Student {

	// overriding the remaining method of the interface,GFG
	@Override public void contribute()
	{
		System.out.println(
			"Now let's help others by contributing in GFG");
	}
}
`````

Here we have overridden the remaining method of the interface GFG.

Below is the overall implementation of the problem statement:

````java
// Implementation of Interface using Abstract Class in Java

// Interface GFG
interface GFG {
	void learnCoding();
	void learnProgrammingLanguage();
	void contribute();
}

// Abstract class Student implementing from GFG interface
abstract class Student implements GFG {

	// Overriding the methods
	@Override public void learnCoding()
	{
		System.out.println(
			"Let's make coding a habit with GFG");
	}
	@Override public void learnProgrammingLanguage()
	{
		System.out.println(
			"Let's master all fundamentals of java with the help of GFG");
	}
}

// Extend the GEEK class by Student abstract class
class GEEK extends Student {
	@Override public void contribute()
	{
		System.out.println(
			"Now let's help others by contributing in GFG");
	}
}

// Driver code
public class Main {
	public static void main(String[] args)
	{
		// New GEEK object is created
		GEEK gfgStudent = new GEEK();

		// Calls to the multiple functions
		gfgStudent.learnCoding();
		gfgStudent.learnProgrammingLanguage();
		gfgStudent.contribute();
	}
}
`````

**Output:**

	Let's make coding a habit with GFG
	Let's master all fundamentals of java with the help of GFG
	Now let's help others by contributing in GFG

#java