# Custom Security on WebAPI

## Overview
This small WebAPI solution demonstrates how to set up
a rudimentary authorization token for secured access.

When making a RESTful request to the secure controller, pass along 
an Authorization header value in the request.

## Services

### Normal (Unsecured) Data
This is your run-of-the-mill GET request. Asks for nothing special.

```
GET /api/NormalData
```

Response:
```
"NormalData"
```

### Secured Data
In order to get a happy (200 OK) response from this service,
an Authorization header entry must be supplied with the request.

```
GET /api/SecureData
Authorization: Token securekey
```

Response:
```
""SecureData for Bob""
```

The custom _MyAuthMessageHandler_ looks for the Authorization request header
and checks it for the _'Token securekey'_ schema/parameter pair.
If that is satisfied, it authorizes you as _'Bob'_.

## Further Reading

1. [AuthN & AuthZ](http://www.asp.net/web-api/overview/security/authentication-and-authorization-in-aspnet-web-api)
1. [HTTP Message Handlers](http://www.asp.net/web-api/overview/advanced/http-message-handlers)
