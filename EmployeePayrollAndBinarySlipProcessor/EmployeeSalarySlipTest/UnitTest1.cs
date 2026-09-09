using System.Text;
using System.Text.Json;

namespace EmployeeSalarySlipTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void Test_UnknownGradeException()
        {
            string csv = "EmpId,Name,Grade,GrossSalary\nE04,Suresh Iyer,Z,60000";
            //var (valid, errors) = ExecuteCsv(csv);

            //Assert.That(valid.Count, Is.EqualTo(0));
            //Assert.That(errors.Count, Is.EqualTo(1));
            //Assert.That(errors[0], Does.Contain("Unknown grade encountered: 'Z'"));
        }

    }
}