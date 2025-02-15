﻿using DevFreela.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Core.Entities
{
    public class Project
    {
        public Project(string title, string description, int idCliente, int idFreelancer, decimal totalCost)
        {
            Title = title;
            Description = description;
            IdCliente = idCliente;
            IdFreelancer = idFreelancer;
            TotalCost = totalCost;

            CreateAt = DateTime.Now;
            Comments = new List<ProjectComment>();

        }

        public string Title { get; private set; }
        public string Description { get; private set; }
        public int IdCliente { get; private set; }
        public int IdFreelancer { get; private set; }

        public decimal TotalCost { get; private set; }

        public DateTime CreateAt { get; private set; }

        public DateTime? StartedAt { get; private set; }

        public DateTime FinishedAt { get; private set; }

        public ProjectStatusEnum Status { get; private set; }

        public List<ProjectComment> Comments { get; private set; }  


    }
}
