class WasRun:
    def __init__(self, name):
        self.WasRun = None
    def run(self):
        self.testMethod()
    def testMethod(self):
        self.WasRun = 1

test = WasRun("testMethod")
print(test.WasRun)
test.testMethod()
print(test.WasRun)
