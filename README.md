# protogeneration-issue

When importing proto file you need to take care of file casing, e.g. if your proto file is named: "MyProto.proto" you cannot import it with
import "myproto.proto" because you will end up with namespaces that are wrongly cased.

I thought this is a bug, but it's rathar an edge case that just needs to follow a [convention](https://github.com/grpc/grpc/issues/16514)
