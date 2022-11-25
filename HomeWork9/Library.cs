using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    enum StatusOfProject
    {
        project = 0,
        execution = 1,
        closed = 2
    }
    enum StatusOfProblem
    {
        Appointed = 0,
        InProgress = 1,
        OnVerification = 2,
        Closed =3,
        Deleted =4
    }
    internal class Project
    {
        StatusOfProject status;
        string description;
        DateTime deadline; // крутая книга, кстати;
        Customer customer;
        TeamLead teamlead;
        public List<Problem?> problems = new List<Problem>() { };
        internal StatusOfProject GetAndSetStatusOfProject
        {
            get { return status; }
            set { status = (StatusOfProject)value; }
        }
        internal void AddProblem(Problem problem)
        {
            problems.Add(problem);
        }
        internal Project(string description, DateTime deadline, Customer customer, TeamLead teamLead)
        {
            status = StatusOfProject.project;
            this.description = description;
            this.deadline = deadline;
            this.customer = customer;
            this.teamlead = teamLead;
        }
    }
    internal class Customer 
    {
        string name;
        internal Customer(string name)
        {
            this.name = name;
        }

        internal Project MakeOrder(string description, DateTime deadline, Customer customer, TeamLead teamLead)
        {
            return new Project(description, deadline, customer, teamLead);
        }
    }
    internal class Problem 
    {
        string description;
        DateTime deadline;
        TeamLead teamlead;
        Executor executor;
        StatusOfProblem status;
        List<Report> reports = new List<Report>();
        internal string GetDesc
        {
            get { return description; }
        }
        internal StatusOfProblem GetAndSetStatus
        {
            get { return status; }
            set { value = status; }
        }
        internal Problem(string description, DateTime deadline, TeamLead teamlead, Executor executor)
        {
            this.description = description;
            this.deadline = deadline;
            this.teamlead = teamlead;
            this.executor = executor;
            status = StatusOfProblem.Appointed;
        }
        internal Problem(string description, DateTime deadline, TeamLead teamlead)
        {
            this.description = description;
            this.deadline = deadline;
            this.teamlead = teamlead;

            status = StatusOfProblem.Appointed;
        }
    }
    internal class TeamLead
    {
        string name;    
        internal TeamLead(string name)
        {
            this.name = name;
        }

        internal void MakeTaskInProject(Project project,string description, DateTime deadline, TeamLead teamLead)
        {
            Problem problem = new Problem(description, deadline, teamLead);
            project.AddProblem(problem);
        }
        internal void DeleteProblem(Project MakeBot, Problem problem)
        {
            MakeBot.problems.Remove(problem);
        }
        internal int GiveAProblem(Executor executor1 , Executor executor2, Problem problem)
        {
            var r = new Random();
            int num = r.Next(0, 3);
            if (num == 0)
            {
                Console.WriteLine($"{executor1.GetName} берет задачу: {problem.GetDesc}");
                executor1.GetAndSetProblem = problem;
                problem.GetAndSetStatus = StatusOfProblem.Appointed;
                return 0;
            }
            else if (num == 1)
            {
                Console.WriteLine($"{executor1.GetName} НЕ берет задачу: {problem.GetDesc}");
                
                return 1;
            }
            else
            {
                Console.WriteLine($"{executor1.GetName} делегирует задачу \"{problem.GetDesc}\" {executor2.GetName}");
                executor2.GetAndSetProblem = problem;
                problem.GetAndSetStatus = StatusOfProblem.Appointed;
                return 2;
            }


        }
        internal bool CheckReport(Report report)
        {
            string desc = report.GetText;
            Random rand = new Random(); 
            int r = rand.Next(0, 2);    
            if(r == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    internal class Executor
    {
        string name;
        Problem problem;
        public string GetName
        {
            get { return name; }    
        }
        internal Problem GetAndSetProblem
        {
             get { return problem; }
             set { problem = value; }
        }
        internal void CloseTask()
        {
            problem.GetAndSetStatus = StatusOfProblem.Closed;
        }
        internal Report MakeReport(Problem problem, string text, DateTime time, Executor executor)
        {
            problem.GetAndSetStatus = StatusOfProblem.OnVerification;
            return new Report(text, time, executor);
        }
        internal void StartProblem()
        {
            problem.GetAndSetStatus = StatusOfProblem.InProgress;
        }
        public Executor(string name, Problem problem)
        {
            this.name = name;
            this.problem = problem;
        }
        public Executor(string name)
        {
            this.name = name;
        }

    }
    internal class Report
    {
        
        string text;
        DateTime time;
        Executor executor;
        public String GetText
        {
            get { return text; }
        }
        internal Report(string text, DateTime time, Executor executor)
        {
            this.executor = executor;
            this.text = text;
            this.time = time;
        }
        private Report() { }
    }

}
