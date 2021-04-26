using Authing.ApiClient.Types;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Authing.ApiClient.Mgmt
{
    public partial class ManagementClient
    {
        /// <summary>
        /// 策略管理模块
        /// </summary>
        public PoliciesManagementClient Policies { get; private set; }

        /// <summary>
        /// 策略管理类
        /// </summary>
        public class PoliciesManagementClient
        {
            private readonly ManagementClient client;

            /// <summary>
            /// 
            /// </summary>
            /// <param name="client"></param>
            public PoliciesManagementClient(ManagementClient client)
            {
                this.client = client;
            }

            /// <summary>
            /// 获取策略列表
            /// </summary>
            /// <param name="page">分页页数，默认为 1</param>
            /// <param name="limit">分页大小，默认为 10</param>
            /// <param name="excludeDefault">包含系统默认的策略，默认为 true</param>
            /// <param name="cancellationToken"></param>
            /// <returns></returns>
            public async Task<PaginatedPolicies> List(
                int page = 1,
                int limit = 10,
                bool excludeDefault = true,
                CancellationToken cancellationToken = default)
            {
                var param = new PoliciesParam()
                {
                    Page = page,
                    Limit = limit,
                    // ExcludeDefault = excludeDefault,
                };

                await client.GetAccessToken();
                var res = await client.Request<PoliciesResponse>(param.CreateRequest(), cancellationToken);
                return res.Result;
            }

            /// <summary>
            /// 创建策略
            /// </summary>
            /// <param name="code">策略唯一标志</param>
            /// <param name="statements">策略语句，详细格式与说明请见 https://docs.authing.co/docs/access-control/index.html</param>
            /// <param name="description">描述</param>
            /// <param name="cancellationToken"></param>
            /// <returns></returns>
            public async Task<Policy> Create(
                string code,
                IEnumerable<PolicyStatementInput> statements,
                string description = null,
                CancellationToken cancellationToken = default)
            {
                var param = new CreatePolicyParam(code, statements)
                {
                    Description = description,
                };

                await client.GetAccessToken();
                var res = await client.Request<CreatePolicyResponse>(param.CreateRequest(), cancellationToken);
                return res.Result;
            }

            /// <summary>
            /// 更新策略
            /// </summary>
            /// <param name="code">策略唯一标志</param>
            /// <param name="statements">策略语句，详细格式与说明请见 https://docs.authing.co/docs/access-control/index.html</param>
            /// <param name="description">描述</param>
            /// <param name="newCode">新的唯一标志</param>
            /// <param name="cancellationToken"></param>
            /// <returns></returns>
            public async Task<Policy> Update(
                string code,
                IEnumerable<PolicyStatementInput> statements = null,
                string description = null,
                string newCode = null,
                CancellationToken cancellationToken = default)
            {
                var param = new UpdatePolicyParam(code)
                {
                    Statements = statements,
                    Description = description,
                    NewCode = newCode,
                };

                await client.GetAccessToken();
                var res = await client.Request<UpdatePolicyResponse>(param.CreateRequest(), cancellationToken);
                return res.Result;
            }

            /// <summary>
            /// 获取策略详情
            /// </summary>
            /// <param name="code">策略唯一标志</param>
            /// <param name="cancellationToken"></param>
            /// <returns></returns>
            public async Task<Policy> Detail(
                string code,
                CancellationToken cancellationToken = default)
            {
                var param = new PolicyParam(code);

                await client.GetAccessToken();
                var res = await client.Request<PolicyResponse>(param.CreateRequest(), cancellationToken);
                return res.Result;
            }

            /// <summary>
            /// 删除策略
            /// </summary>
            /// <param name="code">策略唯一标志</param>
            /// <param name="cancellationToken"></param>
            /// <returns></returns>
            public async Task<CommonMessage> Delete(
                string code,
                CancellationToken cancellationToken = default)
            {
                var param = new DeletePolicyParam(code);

                await client.GetAccessToken();
                var res = await client.Request<DeletePolicyResponse>(param.CreateRequest(), cancellationToken);
                return res.Result;
            }

            /// <summary>
            /// 批量删除策略
            /// </summary>
            /// <param name="codeList">策略唯一标志</param>
            /// <param name="cancellationToken"></param>
            /// <returns></returns>
            public async Task<CommonMessage> DeleteMany(
                IEnumerable<string> codeList,
                CancellationToken cancellationToken = default)
            {
                var param = new DeletePoliciesParam(codeList);

                await client.GetAccessToken();
                var res = await client.Request<DeletePoliciesResponse>(param.CreateRequest(), cancellationToken);
                return res.Result;
            }

            /// <summary>
            /// 获取策略授权记录
            /// </summary>
            /// <param name="code">策略唯一标志</param>
            /// <param name="page">分页页数，默认为 1</param>
            /// <param name="limit">分页大小，默认为 10</param>
            /// <param name="cancellationToken"></param>
            /// <returns></returns>
            public async Task<PaginatedPolicyAssignments> ListAssignments(
                string code,
                int page = 1,
                int limit = 10,
                CancellationToken cancellationToken = default)
            {
                var param = new PolicyAssignmentsParam()
                {
                    Code = code,
                    Page = page,
                    Limit = limit,
                };

                await client.GetAccessToken();
                var res = await client.Request<PolicyAssignmentsResponse>(param.CreateRequest(), cancellationToken);
                return res.Result;
            }

            /// <summary>
            /// 添加策略授权
            /// </summary>
            /// <param name="policies">策略 code 列表</param>
            /// <param name="targetType"></param>
            /// <param name="targetIdentifiers">可选值为 USER (用户) 和 ROLE (角色)</param>
            /// <param name="cancellationToken">用户 id 列表和角色 code 列表</param>
            /// <returns></returns>
            public async Task<CommonMessage> AddAssignments(
                IEnumerable<string> policies,
                PolicyAssignmentTargetType targetType,
                IEnumerable<string> targetIdentifiers,
                CancellationToken cancellationToken = default)
            {
                var param = new AddPolicyAssignmentsParam(policies, targetType)
                {
                    TargetIdentifiers = targetIdentifiers,
                };

                await client.GetAccessToken();
                var res = await client.Request<AddPolicyAssignmentsResponse>(param.CreateRequest(), cancellationToken);
                return res.Result;
            }

            /// <summary>
            /// 撤销策略授权
            /// </summary>
            /// <param name="policies">策略 code 列表</param>
            /// <param name="targetType"></param>
            /// <param name="targetIdentifiers">可选值为 USER (用户) 和 ROLE (角色)</param>
            /// <param name="cancellationToken">用户 id 列表和角色 code 列表</param>
            /// <returns></returns>
            public async Task<CommonMessage> RemoveAssignments(
                IEnumerable<string> policies,
                PolicyAssignmentTargetType targetType,
                IEnumerable<string> targetIdentifiers,
                CancellationToken cancellationToken = default)
            {
                var param = new RemovePolicyAssignmentsParam(policies, targetType)
                {
                    TargetIdentifiers = targetIdentifiers,
                };

                await client.GetAccessToken();
                var res = await client.Request<RemovePolicyAssignmentsResponse>(param.CreateRequest(), cancellationToken);
                return res.Result;
            }
        }
    }
}
