using System;

namespace Assets.Scripts.PatternsPovideniya.Mediator
{
    public class Program
    {
        static void Main(string[] args)
        {
            ManagerMediator mediator = new ManagerMediator();
            Colleague customer = new CustomerColleague(mediator);
            Colleague programmer = new ProgrammerColleague(mediator);
            Colleague tester = new TesterColleague(mediator);
            mediator.Customer = customer;
            mediator.Programmer = programmer;
            mediator.Tester = tester;
            customer.Send("���� �����, ���� ������� ���������");
            programmer.Send("��������� ������, ���� ��������������");
            tester.Send("��������� �������������� � ������ � �������");

            Console.Read();
        }

    }

}