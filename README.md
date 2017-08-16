# maxconnections
Tests the MaxConnections .NET setting to see its effect on a client.

Use this sample app to test the effect maxconnection has on a client/server.

IMPORTANT: The client/server apps must be run on two different servers. The setting is ignored for localhost connections.

The maxconnection setting is in the Client app.config, adjust it to the value to test. Be sure to update the address of the server app to match the actual address. 

The server app will output how many active connections it has. The value should never surpass the number of maxconnections set in the client app.config.
