
using Sprint2Project.Models;
using System.Collections.Generic;

namespace Sprint2Project.Interface
{
    public interface ITaskModule
    {

        List<TaskModule> GetAllTask();
        TaskModule GetTaskById(int id);
        TaskModule AddTask(TaskModule task);
        TaskModule UpdateTask(int id, TaskModule task);
        void DeleteTask(int id);


    }
}
