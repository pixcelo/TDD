# 親クラス
class TestCase:
    def __init__(self, name):
        self.name = name
    def run(self):
        method = getattr(self, self.name)
        method()

# 子クラス
class WasRun(TestCase):
    def __init__(self, name):
        self.WasRun = None
        super().__init__(name)
    def testMethod(self):
        self.WasRun = 1

test = WasRun("testMethod")
print(test.WasRun)
test.testMethod()
print(test.WasRun)
