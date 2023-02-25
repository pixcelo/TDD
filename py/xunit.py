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

# TestCaseクラスのテスト
class TestCaseTest(TestCase):
    def testRunning(self):
        test = WasRun("testMethod")
        assert(not test.WasRun)
        test.run()
        assert(test.WasRun)

TestCaseTest("testRunning").run()
