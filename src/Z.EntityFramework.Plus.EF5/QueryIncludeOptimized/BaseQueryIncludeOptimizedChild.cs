﻿// Description: EF Bulk Operations & Utilities | Bulk Insert, Update, Delete, Merge from database.
// Website & Documentation: https://github.com/zzzprojects/Entity-Framework-Plus
// Forum: https://github.com/zzzprojects/EntityFramework-Plus/issues
// License: http://www.zzzprojects.com/license-agreement/
// More projects: http://www.zzzprojects.com/
// Copyright (c) 2015 ZZZ Projects. All rights reserved.

using System;
using System.Linq;

namespace Z.EntityFramework.Plus
{
    /// <summary>Base class for query include optimized child.</summary>
    public abstract class BaseQueryIncludeOptimizedChild
    {
        /// <summary>Creates the query to use to load related entities.</summary>
        /// <param name="rootQuery">The root query.</param>
        public virtual void CreateIncludeQuery(IQueryable rootQuery)
        {
            throw new Exception(ExceptionMessage.GeneralException);
        }
    }
}