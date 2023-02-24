class WasRun:
    def __init__(self, name):
        self.WasRun = None
    def run(self):
        method = getattr(self, self.name)
        method()
    def testMethod(self):
        self.WasRun = 1

test = WasRun("testMethod")
print(test.WasRun)
test.testMethod()
print(test.WasRun)
