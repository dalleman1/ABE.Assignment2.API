using ABE.Assignment2.DomainLogic.Querys;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Text;
using System.Web.Mvc;

namespace ABE.Assignment2.DomainLogic.Schemas
{
    public class GraphQLSchema : Schema
    {
        public GraphQLSchema(IDependencyResolver resolver) : base(resolver)
        {
            Query = resolver.Resolve<TeacherQuery>();
        }
    }
}
