class Person:
  # def __init__(self):
  firstName = "haha"
  lastName = "eiei"
  def getName(self, firstName, lastName):
    return firstName + lastName

print(Person().getName("haha", "eiei"))

a = Person()
a.firstName = "test"
a.lastName = "zaza"
print(a.firstName)
