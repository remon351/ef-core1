using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ef_task1.models
{
    internal class Resource
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public ResourceType ResourceType { get; set; }
        public int CourseId { get; set; }
        public Course course { get; set; }
        

    }
    public enum ResourceType
    {
        Video,
        Presentation,
        Document,
        Other
    }
}
