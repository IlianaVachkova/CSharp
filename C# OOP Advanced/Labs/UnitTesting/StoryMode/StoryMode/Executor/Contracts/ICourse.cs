using System;
using System.Collections.Generic;

namespace Executor.Contracts
{
    public interface ICourse : IComparable<ICourse>
    {
        string Name { get; }

        IReadOnlyDictionary<String, Student> StudentsByName { get; }

        void EnrollStudent(Student student);
    }
}
