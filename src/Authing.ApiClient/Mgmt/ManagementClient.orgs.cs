using Authing.ApiClient.Management.Types;
using Authing.ApiClient.Types;
using System;
using System.Collections.Generic;
using System.Text;
using Authing.ApiClient.Management.Types;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;
using Newtonsoft.Json;
using Authing.ApiClient.Extensions;
using Authing.ApiClient.Utils;

namespace Authing.ApiClient.Mgmt
{
    public partial class ManagementClient
    {
        public OrgManagementClient Orgs { get; private set; }

        public class OrgManagementClient
        {
            private readonly ManagementClient client;
            

            /// <summary>
            /// 构造方法
            /// </summary>
            /// <param name="client"></param>
            public OrgManagementClient(ManagementClient client)
            {
                this.client = client;
            }

            public async Task<Types.Org> Create(string name, string description = null, string code = null, CancellationToken cancellationToken = default)
            {
                var param = new CreateOrgParam(name)
                {
                    Description = description,
                    Code = code
                };
                var res = await client.Request<CreateOrgResponse>(param.CreateRequest(), cancellationToken);
                return res.Result;
            }

            public async Task<CommonMessage> DeleteById(string id, CancellationToken cancellationToken = default)
            {
                var param = new DeleteOrgParam(id);
                var res = await client.Request<DeleteOrgResponse>(param.CreateRequest(), cancellationToken);
                return res.Result;
            }

            public async Task<PaginatedOrgs> List(int page = 1, int limit = 10, CancellationToken cancellationToken = default)
            {
                var param = new OrgsParam()
                {
                    Limit = limit,
                    Page = page
                };
                var res = await client.Request<OrgsResponse>(param.CreateRequest(), cancellationToken);
                return res.Result;
            }

            public async Task<Types.Org> AddNote(string orgId, AddNodeParam addNodeParam, CancellationToken cancellationToken = default)
            {
                var param = new AddNodeParam(orgId, addNodeParam.Name)
                {
                    ParentNodeId = addNodeParam.ParentNodeId,
                    Code = addNodeParam.Code,
                    Order = addNodeParam.Order,
                    NameI18n = addNodeParam.NameI18n,
                    Description = addNodeParam.Description,
                    DescriptionI18n = addNodeParam.DescriptionI18n
                };
                var res = await client.Request<AddNodeResponse>(param.CreateRequest(), cancellationToken);
                return res.Result;
            }

            public async Task<Node> GetNodeById(string nodeId, CancellationToken cancellationToken = default)
            {
                var param = new NodeByIdParam(nodeId);
                var res = await client.Request<NodeByCodeResponse>(param.CreateRequest(), cancellationToken);
                return res.Result;
            }

            public async Task<Node> UpdateNode(string orgId, UpdateNodeParam updateNodeParam, CancellationToken cancellationToken = default)
            {
                updateNodeParam.Id = orgId;
                var res = await client.Request<UpdateNodeResponse>(updateNodeParam.CreateRequest(), cancellationToken);
                return res.Result;
            }

            public async Task<Types.Org> FindById(string id, CancellationToken cancellationToken = default)
            {
                var param = new OrgParam(id);
                var res = await client.Request<OrgResponse>(param.CreateRequest(), cancellationToken);
                // TODO: buildTree(res)
                return res.Result;
            }

            public async Task<CommonMessage> DeleteNode(string orgId,
            string nodeId, CancellationToken cancellationToken = default)
            {
                var param = new DeleteNodeParam(orgId, nodeId);
                var res = await client.Request<DeleteNodeResponse>(param.CreateRequest(), cancellationToken);
                return res.Result;
            }

            public async Task<CommonMessage> MoveNode(string orgId, string nodeId, string targetParentId, CancellationToken cancellationToken = default)
            {
                var param = new MoveNodeParam(orgId, nodeId, targetParentId);
                var res = await client.Request<MoveMembersResponse>(param.CreateRequest(), cancellationToken);
                // TODO: build tree
                return res.Result;
            }

            public async Task<bool?> IsRootNode(string orgId, string nodeId, CancellationToken cancellationToken = default)
            {
                var param = new IsRootNodeParam(nodeId, orgId);
                var res = await client.Request<IsRootNodeResponse>(param.CreateRequest(), cancellationToken);
                return res.Result;
            }

            public async Task<IEnumerable<Node>> ListChildren(string nodeId, CancellationToken cancellationToken = default)
            {
                var param = new ChildrenNodesParam(nodeId);
                var res = await client.Request<ChildrenNodesResponse>(param.CreateRequest(), cancellationToken);
                return res.Result;
            }

            public async Task<Node> RootNode(string orgId, CancellationToken cancellationToken = default)
            {
                var param = new RootNodeParam(orgId);
                var res = await client.Request<RootNodeResponse>(param.CreateRequest(), cancellationToken);
                return res.Result;
            }

            public async Task<object> ImportByJson(object _object)
            {
                // TODO: 上传文件
                // var param = 
            }

            public async Task<Node> AddMembers(string nodeId, IEnumerable<string> userIds, CancellationToken cancellationToken = default)
            {
                var param = new AddMemberParam(userIds)
                {
                    NodeId = nodeId
                };
                var res = await client.Request<AddMemberResponse>(param.CreateRequest(), cancellationToken);
                return res.Result;
            }

            

        }
    }
}
