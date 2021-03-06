﻿using System;
using System.Collections.Generic;

namespace Executor.Contracts
{
    public interface ICourse : IComparable<ICourse>
    {
        string Name { get; }

        IReadOnlyDictionary<String, IStudent> StudentsByName { get; }

        void EnrollStudent(IStudent student);
    }
}
