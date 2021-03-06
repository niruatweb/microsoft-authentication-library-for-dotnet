﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace Microsoft.Identity.Client.Internal.Broker
{
    internal class BrokerResponseConst
    {
        public const string ErrorMetadata = "error_metadata";
        public const string BrokerErrorDomain = "broker_error_domain";
        public const string BrokerErrorCode = "broker_error_code";
        public const string BrokerErrorDescription = "error_description";

        public const string BrokerErrorMessage = "broker_error_message";

        public const string Authority = "authority";
        public const string AccessToken = "access_token";
        public const string ClientId = "client_id";
        public const string RefreshToken = "refresh_token";
        public const string IdToken = "id_token";
        public const string Bearer = "Bearer";
        public const string CorrelationId = "correlation_id";
        public const string Scope = "scope";
        public const string AndroidScopes = "scopes";
        public const string ExpiresOn = "expires_on";
        public const string ClientInfo = "client_info";
        public const string Account = "mAccount";
        public const string HomeAccountId = "home_account_id";
        public const string LocalAccountId = "local_account_id";
        public const string UserName = "username";
        public const string iOSBrokerNonce = "broker_nonce"; // included in request and response with iOS Broker v3
        public const string Environment = "environment";

        public const string iOSBrokerUserCancellationErrorCode = "-50005";
    }
}
