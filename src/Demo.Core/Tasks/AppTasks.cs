using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Abp.Timing;

namespace Demo.Tasks
{
    public class AppTasks : Entity, IHasCreationTime
    {
        public const int MaxTitleLength = 256;
        public const int MaxDescriptionLength = 64 * 1024; //64KB

        [Required]
        [StringLength(MaxTitleLength)]
        public string Title { get; set; }

        [StringLength(MaxDescriptionLength)]
        public string Description { get; set; }

        public DateTime CreationTime { get; set; }

        public TaskState State { get; set; }

        public AppTasks()
        {
            CreationTime = Clock.Now;
            State = TaskState.Open;
        }

        public AppTasks(string title, string description = null)
            : this()
        {
            Title = title;
            Description = description;
        }
    }

    public enum TaskState : byte
    {
        Open = 0,
        Completed = 1
    }
}
