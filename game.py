class Person:
  def __init__(self, firstName, lastName):
    self.firstName = firstName
    self.lastName = lastName

  def getName(self):
    return "{} {}".format(self.firstName, self.lastName)

a = Person("test", "zaza")
print(a.getName())
