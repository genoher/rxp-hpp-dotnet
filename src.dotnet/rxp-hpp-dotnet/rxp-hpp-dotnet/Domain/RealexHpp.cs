namespace Realexpayments.HPP.SDK
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using NLog;

    /// <summary>
    /// RealexHpp class for converting HPP requests and responses to and from JSON. 
    /// This class is also responsible for validating inputs, generating defaults and encoding parameter values.  
    /// 
    /// Creating Request JSON for Realex JS SDK
    /// <code>
    /// HppRequest hppRequest = new HppRequest().addMerchantId("merchantId").addAmount(100)...addAutoSettleFlag(true);
    /// RealexHpp realexHpp = new RealexHpp("mySecret");
    /// String json = realexHpp.requestToJson(hppRequest);
    /// </code>
    /// 
    /// Consuming Response JSON from Realex JS SDK
    /// <code>
    /// RealexHpp realexHpp = new RealexHpp("mySecret");
    /// HppResponse hppResponse = realexHpp.responseFromJson(responseJson); 
    /// </code>
    /// </summary>
    public class RealexHpp
    {
        /// <summary>
        /// The logger
        /// </summary>
        private static readonly ILogger _logger = LogManager.GetCurrentClassLogger();

        /// <summary>
        /// Character set to use for encoding/decoding.
        /// </summary>
        public static readonly Encoding ENCODING_CHARSET = Encoding.UTF8;

        /// <summary>
        /// Gets the secret.
        /// </summary>
        /// <value>
        /// The secret.
        /// </value>
        private string Secret { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealexHpp"/> class.
        /// </summary>
        /// <param name="secret">The secret.</param>
        public RealexHpp(string secret)
        {
            this.Secret = secret;
        }

        //public string RequestToJson(HppRequest hppRequest)
        //{

        //}
    }
}
