import grpc

import server_pb2
import server_pb2_grpc


def sendToServer(phone: str) -> int:
    with grpc.insecure_channel("localhost:5050") as channel:
        stub = server_pb2_grpc.PhoneVerificationStub(channel)
        resp = stub.VerifyPhone(server_pb2.PhoneRequest(phoneNumber=phone))
    return resp.message
