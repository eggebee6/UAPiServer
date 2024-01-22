# UAPiServer
### An OPC UA server for the Raspberry Pi Sense HAT
Use OPC UA to read sensor data from a Sense HAT and to illuminate the RGB LED matrix!  The Raspberry Pi hosts an OPC UA server, and an OPC UA client can connect to the server to read Sense HAT data and change the color and brightness of the LEDs.

### What is OPC UA?
Wikipedia:  [https://wikipedia.org/wiki/OPC_Unified_Architecture](https://wikipedia.org/wiki/OPC_Unified_Architecture)

OPC Unified Architecture (OPC UA) is an open-source, cross-platform, certifiable standard for data exchange.  Some of the primary benefits of OPC UA are security (encryption, authentication, authorization, and integrity), a flexible object-oriented address space, internet capability, scalability, and its service oriented architecture (SOA).

OPC UA was developed by the [OPC Foundation](https://opcfoundation.org/)

### The setup
All the interesting parts:
- Raspberry Pi 3 B+
- Sense HAT
- Ubuntu for Raspberry Pi (or similar OS)
- C# and .NET
- Docker (optional)

Don't forget to install the Sense HAT libraries: *apt get install sense-hat*

### The project
Using an OPC UA client such as [UaExpert](https://www.unified-automation.com/products/development-tools/uaexpert.html) may be helpful when getting started.

If a Sense HAT object cannot be instantiated (e.g. the server is being run on a development machine), a simulation of a Sense HAT generating random sensor data will be used instead.

## Development
Active work should merged into the `dev` branch, preferably through a pull request with appropriate review.  Adding unit testing, CI/CD, examples, and **improving documentation** would be fantastic.  The `main` branch should be reserved for clean, tested code.

## Miscellaneous
Not a serious project yet, but feel free to help make it one.
