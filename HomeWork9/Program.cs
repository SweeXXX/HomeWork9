using HomeWork;
using System;
using System.Reflection.Emit;

namespace Home
{
    class Program
    {
        static void Taker(int t, Executor executor1, Executor executor2)
        {
            if (t == 0)
            {
                executor1.StartProblem();
            }
            if (t == 2 )
            {
                executor2.StartProblem();
            }
        }
         
        static void MbDelete(int t1, Executor Oleg, Executor Pavel, TeamLead Vova, Project MakeBot, Problem problem)
        {
            try
            {
                if (t1 != 1)
                    Taker(t1, Oleg, Pavel);
                else
                    Vova.DeleteProblem(MakeBot, problem);
            }
            catch { }
        }

        static void R(Executor name, string t, DateTime date, TeamLead Vova)
        {
            var R1 = name.MakeReport(name.GetAndSetProblem, t, new DateTime(2022, 11, 27), name); bool b1 = Vova.CheckReport(R1);
            if (b1)
            {
                name.GetAndSetProblem.GetAndSetStatus = StatusOfProblem.Closed;
                Console.WriteLine($"Репорт от {name.GetName} принят");
            }
            else
                Console.WriteLine("Репорт не принят. Переделывай");
        }
        static void Main(string[] args)
        {
            TeamLead Vova = new TeamLead("Владимир");
            Customer Vika = new Customer("Виктория");

            Executor Pavel = new Executor("Павел");
            Executor Oleg = new Executor("Олег");
            Executor Katya = new Executor("Екатерина");
            Executor Dina = new Executor("Дина");//не Диана))
            Executor Daniil = new Executor("Данёк");
            Executor Vitaliy = new Executor("Виталий");
            Executor Leysan = new Executor("Лейсан");
            Executor Maria = new Executor("Мария");
            Executor Nikita = new Executor("Никита");
            Executor Maksim = new Executor("Максим");//10
            Executor Tumakokokov = new Executor("Нудный чел");
            Executor Sidorov = new Executor("Умный чел");
            Executor Garnik = new Executor("Гарник");
            //Executor  =new Executor("л");
            //Executor = new Executor("");
            Project MakeBot = Vika.MakeOrder("ну, кароче, надо бота сделать для тг, чтобы он был круче, чем Facebook и VK. " +
                "Вам 2 дня на все про всё. Заплачу 40 гривен", new DateTime(2022, 12, 12), Vika, Vova);
            Vova.MakeTaskInProject(MakeBot, "Сделай кнопочки для бота", new DateTime(2022, 12, 1), Vova);
            Vova.MakeTaskInProject(MakeBot, "Сделай лучше, чем вк", new DateTime(2022, 12, 2), Vova);
            Vova.MakeTaskInProject(MakeBot, "Сделай лучше, чем Facepook", new DateTime(2022, 12, 3), Vova);
            Vova.MakeTaskInProject(MakeBot, "Сделай вид, что работаешь", new DateTime(2022, 12, 4), Vova);//4
            Vova.MakeTaskInProject(MakeBot, "Изучи новый фремворк вдоль и поперек", new DateTime(2022, 12, 5), Vova);
            Vova.MakeTaskInProject(MakeBot, "Создай новый язык программирования, быстрее c++ без ASSэмблера", new DateTime(2022, 12, 6), Vova);
            Vova.MakeTaskInProject(MakeBot, "Подключи базу данных к боту", new DateTime(2022, 12, 7), Vova);
            Vova.MakeTaskInProject(MakeBot, "Создай что-то на подобии SQL, но лучше", new DateTime(2022, 12, 8), Vova);
            Vova.MakeTaskInProject(MakeBot, "Объясни заказчику, что мы не успеваем и нам нужно больше времени.Хотя наверное он это уже понял", new DateTime(2022, 12, 9), Vova);//9
            Vova.MakeTaskInProject(MakeBot, "Купи пивка для рывка", new DateTime(2022, 11, 29), Vova);
            //Console.WriteLine(MakeBot.problems.Count);
            Console.ReadKey();
            int t1 = Vova.GiveAProblem(Oleg, Pavel, MakeBot.problems[0]);
            int t2 = Vova.GiveAProblem(Pavel, Katya, MakeBot.problems[1]); Taker(t2, Pavel, Katya);
            int t3 = Vova.GiveAProblem(Katya, Daniil, MakeBot.problems[2]); Taker(t3, Katya, Daniil);
            int t4 = Vova.GiveAProblem(Daniil, Leysan, MakeBot.problems[3]); Taker(t4, Daniil, Leysan);
            int t5 = Vova.GiveAProblem(Leysan, Nikita, MakeBot.problems[4]); Taker(t5, Leysan, Nikita);
            int t6 = Vova.GiveAProblem(Nikita, Maksim, MakeBot.problems[5]); Taker(t6, Nikita, Maksim);
            int t7 = Vova.GiveAProblem(Maksim, Sidorov, MakeBot.problems[6]); Taker(t7, Maksim, Sidorov);
            int t8 = Vova.GiveAProblem(Sidorov,Tumakokokov, MakeBot.problems[7]); Taker(t8, Sidorov, Tumakokokov);
            int t9 = Vova.GiveAProblem(Tumakokokov, Garnik, MakeBot.problems[8]); Taker(t9, Tumakokokov, Garnik);
            int t10 = Vova.GiveAProblem(Dina, Vitaliy, MakeBot.problems[9]);Taker(t10, Dina, Vitaliy);

            try
            {
                MbDelete(t1, Oleg, Pavel, Vova, MakeBot, MakeBot.problems[0]);
                MbDelete(t2, Pavel, Katya, Vova, MakeBot, MakeBot.problems[1]);
                MbDelete(t3, Katya, Daniil, Vova, MakeBot, MakeBot.problems[2]);
                MbDelete(t4, Daniil, Leysan, Vova, MakeBot, MakeBot.problems[3]);
                MbDelete(t5, Leysan, Nikita, Vova, MakeBot, MakeBot.problems[4]);
                MbDelete(t6, Nikita, Maksim, Vova, MakeBot, MakeBot.problems[5]);
                MbDelete(t7, Maksim, Sidorov, Vova, MakeBot, MakeBot.problems[6]);
                MbDelete(t8, Sidorov, Tumakokokov, Vova, MakeBot, MakeBot.problems[6]);
                MbDelete(t9, Tumakokokov, Garnik, Vova, MakeBot, MakeBot.problems[7]);
                MbDelete(t10, Dina, Vitaliy, Vova, MakeBot, MakeBot.problems[8]);
            }
            catch { }
            Console.ReadKey();
            Console.WriteLine($"{MakeBot.problems.Count} - Количество ост Задач\n");
            Console.ReadKey();
            MakeBot.GetAndSetStatusOfProject = StatusOfProject.execution; // Проект перешел в статус в процессе
            Console.WriteLine("Проект перешел в статус в процессе\n");
            Console.ReadKey();
            Console.WriteLine("Делают Репортики Жеские");
            Console.ReadKey();
            //Executor name, string t, DateTime date, TeamLead Vova
            if (Oleg.GetAndSetProblem!=null)
                R(Oleg, "Гатова", new DateTime(2022, 11, 29),Vova);
            if (Pavel.GetAndSetProblem != null)
                R(Pavel, "Сделаль", new DateTime(2022, 11, 30), Vova);
            if (Katya.GetAndSetProblem != null)
                R(Katya, "Работает ПУШКА-БОМБА", new DateTime(2022, 11, 28), Vova);
            if (Daniil.GetAndSetProblem != null)
                R(Daniil, "Ну, работает и ладно", new DateTime(2022, 12, 1), Vova);
            if (Leysan.GetAndSetProblem != null)
                R(Leysan, "Сделаля)", new DateTime(2022, 12, 1), Vova);
            if (Nikita.GetAndSetProblem != null)
                R(Nikita, "Mission Complete", new DateTime(2022, 12, 2), Vova);
            if (Maksim.GetAndSetProblem != null)
                R(Maksim, "Нормас", new DateTime(2022, 12, 2), Vova);
            if (Sidorov.GetAndSetProblem != null)
                R(Sidorov, "Исходя из всего, что я сделал, можно сделать вывод, что с задачей я справился", new DateTime(2022, 12, 2), Vova);
            if (Tumakokokov.GetAndSetProblem != null)
                R(Tumakokokov, "Бла-Бля-Бла", new DateTime(2022, 12, 3), Vova);
            if (Dina.GetAndSetProblem != null)
                R(Dina, "Говно, но работает", new DateTime(2022, 12, 3), Vova);
            var pr1 = MakeBot.problems.Select(x => x.GetAndSetStatus!=StatusOfProblem.Deleted).ToList();
            Console.WriteLine($"{string.Join(" ", pr1)} Статусы задачи != Удалены?");
            Console.WriteLine("Проект Выполнен. Заказчик доволен(наверное)");
        }
    }
}