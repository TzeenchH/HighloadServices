/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

import java.util.Arrays;
import org.baeldung.grpc.NumbererGrpc;
import org.baeldung.grpc.ResultReply;

public class NumbererService extends NumbererGrpc.NumbererImplBase {

    public void ValidateNumber (org.baeldung.grpc.NumberRequest request,
        io.grpc.stub.StreamObserver<org.baeldung.grpc.ResultReply> responseObserver)
    {
        String[] numbers = new String[4];
        numbers[0] = "8-800-555-35-35";
        numbers[1] = "0-123-456-78-90";
        numbers[2] = "1-111-111-11-11";
        numbers[3] = "5-555-555-55-55";
        String number = request.getNumber();
        boolean result = Arrays.asList(numbers).contains(number);
        ResultReply reply = ResultReply.newBuilder()
                .setResult(result)
                .build();
        responseObserver.onNext(reply);
        responseObserver.onCompleted();
    }
}
