## C# method definition:
A method is a code block containing a series of statements. Methods must be declared within a class, struct, or interface. It is a good programming practice that methods do only one specific task. Methods bring modularity to programs. Proper use of methods bring the following advantages:

* Reducing duplication of code
* Decomposing complex problems into simpler pieces
* Improving clarity of the code
* Reuse of code
* Information hiding


## C# method parameters
A parameter is a value passed to the method. Methods can take one or more parameters. If methods work with data, we must pass the data to the methods. We do it by specifying them inside the parentheses. In the method definition, we must provide a name and type for each parameter.

## C# anonymous methods
Anonymous methods are inline methods that do not have a name. Anonymous methods reduce the coding overhead by eliminating the need to create a separate method. Without anonymous methods developers often had to create a class just to call one method.

## C# passing arguments by value, by reference
C# supports two ways of passing arguments to methods: by value and by reference. The default passing of arguments is by value. When we pass arguments by value, the method works only with the copies of the values. This may lead to performance overheads when we work with large amounts of data.

We use the ref keyword to pass a value by reference. When we pass values by reference, the method receives a reference to the actual values. The original values are affected when modified. This way of passing values is more time and space efficient. On the other hand, it is more error prone.

## C# method overloading
Method overloading allows the creation of several methods with the same name which differ from each other in the type of the input.

## C# recursion
Recursion, in mathematics and computer science, is a way of defining methods in which the method being defined is applied within its own definition. In other words, a recursive method calls itself to do its job. Recursion is a widely used approach to solve many programming tasks.

## C# method scope
A variable declared inside a method has a method scope. The scope of a name is the region of program text within which it is possible to refer to the entity declared by the name without the qualification of the name. A variable which is declared inside a method has a method scope. It is also called a local scope. The variable is valid only in this particular method.

A variable defined inside a method has a local/method scope. If a local variable has the same name as an instance variable, it shadows the instance variable. The class variable is still accessible inside the method by using the this keyword.


## C# static methods
Static methods are called without an instance of the object. To call a static method, we use the name of the class and the dot operator. Static methods can only work with static member variables. Static methods are often used to represent data or calculations that do not change in response to object state. An example is a math library which contains static methods for various calculations. We use the static keyword to declare a static method. When no static modifier is present, the method is said to be an instance method. We cannot use the this keyword in static methods. It can be used in instance methods only.

## C# hiding methods
When a derived class inherits from a base class, it can define methods that are already present in the base class. We say that we hide the method of the class that we have derived from. To explicitly inform the compiler about our intention to hide a method, we use the new keyword. Without this keyword, the compiler issues a warning.

## C# overriding methods
Now we introduce two new keywords: the virtual keyword and the override keyword. They are both method modifiers. They are used to implement polymorphic behaviour of objects.

The virtual keyword creates a virtual method. Virtual methods can be redefined in derived classes. Later in the derived class we use the override keyword to redefine the method in question. If the method in the derived class is preceded with the override keyword, objects of the derived class calls that method rather than the base class method.

* C# local functions
* C# sealed methods