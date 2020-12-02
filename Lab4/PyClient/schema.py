from enum import auto

import graphene

import server_pb2
from serverCall import sendToServer


class ValidationResult(graphene.Enum):
    SUCCESS = auto()
    NUMBER_NOT_FOUND = auto()
    INCORRECT_CODE = auto()


class Phone(graphene.ObjectType):
    number = graphene.String(required=True, description='Set phone number')
    code = graphene.Int(required=True, description='Set validation code')
    validation_result = graphene.Field(ValidationResult, description='Validation Result')


class ValidatePhone(graphene.ObjectType):
    phone = graphene.Field(Phone, number=graphene.String(), code=graphene.Int())

    def resolve_phone(self, info, number: str, code: int):
        resp = sendToServer(number)

        if resp == server_pb2.NOT_FOUND:
            return Phone(number=number, code=code, validation_result=ValidationResult.NUMBER_NOT_FOUND)
        if code % 2 == 0:
            return Phone(number=number, code=code, validation_result=ValidationResult.INCORRECT_CODE)
        return Phone(number=number, code=code, validation_result=ValidationResult.SUCCESS)


schema = graphene.Schema(query=ValidatePhone)
