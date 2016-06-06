﻿using Company_HJer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company_HJer.Models
{
    class Project : IProject
    {
        private string name;

        public Project(string name, string details, DateTime startDate)
        {
            this.Name = name;
            this.Details = details;
            this.StartDate = startDate;
            this.State = ProjectState.Open;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Project name cannot be empty.");
                }

                this.name = value;
            }
        }

        public string Details { get; set; }

        public DateTime StartDate { get; set; }

        public ProjectState State { get; set; }

        public void CloseProject()
        {
            this.State = ProjectState.Closed;
        }
    }
}
