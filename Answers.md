/* 
1. What are the six combinations of access modifier keywords and what do they do? 
The 6 access modifiers are public (accessible everywhere), private (only inside class), protected (class + derived classes), internal (same project), protected internal (same project or derived), and private protected (same class or derived in same project).
2. What is the difference between the static, const, and readonly keywords when applied to
a type member?
Static is shared across all objects, const is compile-time constant, and readonly is set at runtime only for constructor.
3. What does a constructor do?
It initializes object when created.
4. Why is the partial keyword useful?
It can split class across multiple files.
5. What is a tuple?
It can group multiple values.
6. What does the C# record keyword do?
It makes an object immutable.
7. What does overloading and overriding mean?
Overloading means same name, different params, while overriding means to replace base method.
8. What is the difference between a field and a property?
Fields are variables used to store data, while properties are specialized methods that control access.
9. How do you make a method parameter optional?
By assigning the default value in the method's definition. 
10. What is an interface and how is it different from abstract class?
Interface doesn't have implementations for the most part while abstract can have implementation. 
11. What accessibility level are members of an interface?
Public by default
12. True/False. Polymorphism allows derived classes to provide different implementations
of the same method. True
13. True/False. The override keyword is used to indicate that a method in a derived class is
providing its own implementation of a method. True
14. True/False. The new keyword is used to indicate that a method in a derived class is
providing its own implementation of a method. False
15. True/False. Abstract methods can be used in a normal (non-abstract) class. False
16. True/False. Normal (non-abstract) methods can be used in an abstract class. True
17. True/False. Derived classes can override methods that were virtual in the base class. True
18. True/False. Derived classes can override methods that were abstract in the base class. True
19. True/False. In a derived class, you can override a method that was neither virtual non abstract in the
base class. False
20. True/False. A class that implements an interface does not have to provide an
implementation for all of the members of the interface. False
21. True/False. A class that implements an interface is allowed to have other members that
aren’t defined in the interface. True
22. True/False. A class can have more than one base class. False
23. True/False. A class can implement more than one interface. True*/