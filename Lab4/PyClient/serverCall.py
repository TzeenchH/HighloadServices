import grpc

import server_pb2
import server_pb2_grpc


def sendToServer(phone: str) -> int:
    credentials = grpc.ssl_channel_credentials()
    with grpc.secure_channel("localhost:5050", credentials) as channel:
        stub = server_pb2_grpc.PhoneVerificationStub(channel)
        resp = stub.VerifyPhone(server_pb2.PhoneRequest(phoneNumber=phone))
    return resp.message
