# ООП Концепции:
# Создайте класс Person, который имеет атрибуты name, age и метод introduce(), выводящий 
# информацию о человеке. Создайте несколько объектов этого класса и вызовите метод introduce() для каждого из них.
# ----------------------------------------------------------

class Person:
    def __init__(self, name, age):
        self.name = name
        self.age = age

    def introduce(self):
        print(f"Hello, my name is {self.name} and I am {self.age} years old.")

person1 = Person("Alice", 30)
person2 = Person("Bob", 25)

person1.introduce()
person2.introduce()