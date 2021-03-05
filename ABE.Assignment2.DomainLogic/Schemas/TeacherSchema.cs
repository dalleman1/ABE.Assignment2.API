using ABE.Assignment2.DomainLogic.Querys;
using GraphQL.Types;
using GraphQL.Utilities;
using System;

namespace ABE.Assignment2.DomainLogic.Schemas
{
    public class TeacherSchema : Schema
    {
        public TeacherSchema(IServiceProvider provider) : base(provider)
        {
            Query = provider.GetRequiredService<TeacherQuery>();
        }
    }
}
