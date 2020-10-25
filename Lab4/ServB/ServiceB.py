import concurrent.furures
import grpc
import PhoneValidator
import PhoneValidator_pb2
import PhoneValidator_pb2_grpc

numbers = ("8-800-555-35-35", "1-222-333-44-55", "1-234-567-78-90")
class PhoneValidatorServicer(PhoneValidator_pb2_grpc.NumbererServicer):
    def ValidateNumber(self, reqest, context):
        responce = PhoneValidator_pb2.NumberRequest()
        if numbers.count(responce.data) == 1:
            return true

def serve():
    serv = grpc.server(concurrent.futures.ThreadPoolExecutor(max_workers=4))
    PhoneValidator_pb2_grpc.add_NumbererServicer_to_server(PhoneValidatorServicer(), serv)

    server.add_insecure_port('[::]:5050')
    server.start()
    try:
        while True:
            time.sleep(3600)
    except KeyboardInterrupt:
        server.stop(0)
        
if __name__ == '__main__':
    serve()