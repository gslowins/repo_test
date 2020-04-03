import unittest
from selenium import webdriver


class MainTests(unittest.TestCase):
    def test_global(self):
        driver = webdriver.Chrome(executable_path=r"C:\TestFiles\chromedriver.exe")
        driver.get('https://www.ubs.com/global/en.html')
        title = driver.title
        print(title)
        assert 'UBS financial services around the globe | Global topics' == title
        driver.quit()

    def test_carers(self):
        driver = webdriver.Chrome(executable_path=r"C:\TestFiles\chromedriver.exe")
        driver.get('https://www.ubs.com/global/en/careers.html')
        title = driver.title
        print(title)
        assert 'Careers | UBS Global topics' == title
        driver.quit()

    def test_why(self):
        driver = webdriver.Chrome(executable_path=r"C:\TestFiles\chromedriver.exe")
        driver.get('https://www.ubs.com/global/en/careers/bsc-poland/why-ubs.html')
        title = driver.title
        print(title)
        assert 'All over the world and right here. | UBS Global topics' == title
        driver.quit()