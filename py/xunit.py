# 親クラス
class TestCase:
    def __init__(self, name):
        self.name = name
    def setUp(self):
        pass
    def run(self):
        self.setUp()
        method = getattr(self, self.name)
        method()

# 子クラス
class WasRun(TestCase):
    def __init__(self, name):
        self.WasRun = None
        super().__init__(name)
    def setUp(self):
        self.wasSetUp = 1
    def testMethod(self):
        self.WasRun = 1

# TestCaseクラスのテスト
class TestCaseTest(TestCase):
    def testRunning(self):
        test = WasRun("testMethod")
        assert(not test.WasRun)
        test.run()
        assert(test.WasRun)
    def testSetUp(self):
        test = WasRun("testMethod")
        test.run()
        assert(test.wasSetUp)

TestCaseTest("testRunning").run()
TestCaseTest("testSetUp").run()
