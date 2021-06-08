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
        /// 注册白名单管理模块
        /// </summary>
        public WhitelistManagementClient Whitelist { get; private set; }

        /// <summary>
        /// 注册白名单管理类
        /// </summary>
        public class WhitelistManagementClient
        {
            private readonly ManagementClient client;

            /// <summary>
            /// 
            /// </summary>
            /// <param name="client"></param>
            public WhitelistManagementClient(ManagementClient client)
            {
                this.client = client;
            }

            /// <summary>
            /// 获取白名单
            /// </summary>
            /// <param name="type">白名单类型，USERNAME 为用户名、Email 为邮箱、Phone 为手机号。</param>
            /// <param name="cancellationToken"></param>
            /// <returns></returns>
            public async Task<IEnumerable<WhiteList>> List(WhitelistType type, CancellationToken cancellationToken = default)
            {
                var param = new WhitelistParam(type);

                var res = await client.Request<WhitelistResponse>(param.CreateRequest(), cancellationToken);
                return res.Result;
            }

            /// <summary>
            /// 添加白名单
            /// </summary>
            /// <param name="type">白名单类型，USERNAME 为用户名、Email 为邮箱、Phone 为手机号。</param>
            /// <param name="list">白名单列表，请注意邮箱不区分大小写。</param>
            /// <param name="cancellationToken"></param>
            /// <returns></returns>
            public async Task<IEnumerable<WhiteList>> Add(
                WhitelistType type,
                IEnumerable<string> list,
                CancellationToken cancellationToken = default)
            {
                var param = new AddWhitelistParam(type, list);

                var res = await client.Request<AddWhitelistResponse>(param.CreateRequest(), cancellationToken);
                return res.Result;
            }

            /// <summary>
            /// 移除白名单
            /// </summary>
            /// <param name="type">白名单类型，USERNAME 为用户名、Email 为邮箱、Phone 为手机号。</param>
            /// <param name="list">白名单列表，请注意邮箱不区分大小写。</param>
            /// <param name="cancellationToken"></param>
            /// <returns></returns>
            public async Task<IEnumerable<WhiteList>> Remove(
                WhitelistType type,
                IEnumerable<string> list,
                CancellationToken cancellationToken = default)
            {
                var param = new RemoveWhitelistParam(type, list);

                var res = await client.Request<RemoveWhitelistResponse>(param.CreateRequest(), cancellationToken);
                return res.Result;
            }

            /// <summary>
            /// 开启白名单
            /// </summary>
            /// <param name="type">白名单类型，USERNAME 为用户名、Email 为邮箱、Phone 为手机号。</param>
            /// <param name="cancellationToken"></param>
            /// <returns></returns>
            public async Task Enable(WhitelistType type, CancellationToken cancellationToken = default)
            {
                var config = new RegisterWhiteListConfigInput
                {
                    EmailEnabled = type switch
                    {
                        WhitelistType.USERNAME =>
                            true,
                        WhitelistType.EMAIL =>
                            true,
                        WhitelistType.PHONE =>
                            true,
                        _ =>
                            throw new AuthingException("不支持的白名单类型"),
                    }
                };

                var param = new UpdateUserpoolParam(new UpdateUserpoolInput()
                {
                    Whitelist = config,
                });

                await client.Request<UpdateUserpoolResponse>(param.CreateRequest(), cancellationToken);
            }

            /// <summary>
            /// 关闭白名单
            /// </summary>
            /// <param name="type">白名单类型，USERNAME 为用户名、Email 为邮箱、Phone 为手机号。</param>
            /// <param name="cancellationToken"></param>
            /// <returns></returns>
            public async Task Disable(WhitelistType type, CancellationToken cancellationToken = default)
            {
                var config = new RegisterWhiteListConfigInput();
                switch (type)
                {
                    case WhitelistType.USERNAME:
                        config.UsernameEnabled = false;
                        break;
                    case WhitelistType.EMAIL:
                        config.EmailEnabled = false;
                        break;
                    case WhitelistType.PHONE:
                        config.PhoneEnabled = false;
                        break;
                    default:
                        throw new AuthingException("不支持的白名单类型");
                }

                var param = new UpdateUserpoolParam(new UpdateUserpoolInput()
                {
                    Whitelist = config,
                });

                await client.GetAccessToken();
                await client.Request<UpdateUserpoolResponse>(param.CreateRequest(), cancellationToken);
            }
        }
    }
}
