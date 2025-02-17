﻿using Sprint2Project.Models;
using System.Collections.Generic;

namespace Sprint2Project.Interface
{
    public interface IProjectModule
    {
        List<ProjectModule> GetAllProject();
        ProjectModule GetProjectById(int id);
        ProjectModule AddProject(ProjectModule project);
        ProjectModule UpdateProject(int id, ProjectModule project);
        void DeleteProject(int id);
       
    }
}
