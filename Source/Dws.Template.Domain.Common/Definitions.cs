using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace Dws.Template.Domain.Common
{
    public class Definitions
    {
        public static JsonSerializerOptions DefaultSerializeOptions => new JsonSerializerOptions() { PropertyNameCaseInsensitive = true };
        public const string AdminRoleId = "89333180-b978-4f90-9dbd-a7040bc93f41";
        public const string AdminRoleName = "admin";
        public const string OrganizationIdClaim = "organization-id";
        public const string OrganizationNameClaim = "organization-name";
        public const string HeaderTotalCount = "totalcount";
        public const string HeaderTotalPages = "totalpages";
        public struct CookieNames
        {
            public const string CurrentProjectId = "Current.Project.Id";
            public const string CurrentProjectName = "Current.Project.Name";
        }

        public const string SystemUserSchemaId = "aee85b10-8d3a-4434-9e7c-e0c144e98cc5";
        public const string TeamSchemaId = "829b6521-93bd-4eb8-b134-17cdd0fa722b";
        public const string UserTeamSchemaId = "2681db40-1e05-4025-a46f-4ff20bfb2f13";

        public const string SystemUserSchemaName = "SystemUser";
        public const string TeamSchemaName = "Team";
        public const string UserTeamSchemaName = "UserTeam";

        public const string NewLine = "\r\n";

        public const int MaxCountQuery = 10000;

        public struct SettingsNames
        {
            public const string GithubToken = "Github.Token";
        }
    }
}
