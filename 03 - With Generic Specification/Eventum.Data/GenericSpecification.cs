﻿using System;
using System.Linq.Expressions;

namespace Eventum.Data
{
    public class GenericSpecification<T>
    {
        //TODO : 01 - Implemento GenericSpecification
        public Expression<Func<T, bool>> Expression { get; }

        public GenericSpecification(Expression<Func<T, bool>> expression)
        {
            Expression = expression;
        }

        public bool IsSatisfiedBy(T entity)
        {
            return Expression.Compile().Invoke(entity);
        }
    }
}