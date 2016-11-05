using System;
using System.Collections.Generic;

namespace Executor.Contracts
{
    public interface Course
    {
        string Name { get; }

        IReadOnlyDictionary<String, Student> StudentsByName { get; }

        void EnrollStudent(Student student);
    }
}
