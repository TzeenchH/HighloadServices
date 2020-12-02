# -*- coding: utf-8 -*-
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: server.proto
"""Generated protocol buffer code."""
from google.protobuf.internal import enum_type_wrapper
from google.protobuf import descriptor as _descriptor
from google.protobuf import message as _message
from google.protobuf import reflection as _reflection
from google.protobuf import symbol_database as _symbol_database

# @@protoc_insertion_point(imports)

_sym_db = _symbol_database.Default()


DESCRIPTOR = _descriptor.FileDescriptor(
    name="server.proto",
    package="",
    syntax="proto3",
    serialized_options=None,
    create_key=_descriptor._internal_create_key,
    serialized_pb=b'\n\x0cserver.proto"#\n\x0cPhoneRequest\x12\x13\n\x0bphoneNumber\x18\x01 \x01(\t"+\n\rPhoneResponse\x12\x1a\n\x07message\x18\x01 \x01(\x0e\x32\t.Response*$\n\x08Response\x12\t\n\x05\x46OUND\x10\x00\x12\r\n\tNOT_FOUND\x10\x01\x32\x43\n\x11PhoneVerification\x12.\n\x0bVerifyPhone\x12\r.PhoneRequest\x1a\x0e.PhoneResponse"\x00\x62\x06proto3',
)

_RESPONSE = _descriptor.EnumDescriptor(
    name="Response",
    full_name="Response",
    filename=None,
    file=DESCRIPTOR,
    create_key=_descriptor._internal_create_key,
    values=[
        _descriptor.EnumValueDescriptor(
            name="FOUND",
            index=0,
            number=0,
            serialized_options=None,
            type=None,
            create_key=_descriptor._internal_create_key,
        ),
        _descriptor.EnumValueDescriptor(
            name="NOT_FOUND",
            index=1,
            number=1,
            serialized_options=None,
            type=None,
            create_key=_descriptor._internal_create_key,
        ),
    ],
    containing_type=None,
    serialized_options=None,
    serialized_start=98,
    serialized_end=134,
)
_sym_db.RegisterEnumDescriptor(_RESPONSE)

Response = enum_type_wrapper.EnumTypeWrapper(_RESPONSE)
FOUND = 0
NOT_FOUND = 1


_PHONEREQUEST = _descriptor.Descriptor(
    name="PhoneRequest",
    full_name="PhoneRequest",
    filename=None,
    file=DESCRIPTOR,
    containing_type=None,
    create_key=_descriptor._internal_create_key,
    fields=[
        _descriptor.FieldDescriptor(
            name="phoneNumber",
            full_name="PhoneRequest.phoneNumber",
            index=0,
            number=1,
            type=9,
            cpp_type=9,
            label=1,
            has_default_value=False,
            default_value=b"".decode("utf-8"),
            message_type=None,
            enum_type=None,
            containing_type=None,
            is_extension=False,
            extension_scope=None,
            serialized_options=None,
            file=DESCRIPTOR,
            create_key=_descriptor._internal_create_key,
        ),
    ],
    extensions=[],
    nested_types=[],
    enum_types=[],
    serialized_options=None,
    is_extendable=False,
    syntax="proto3",
    extension_ranges=[],
    oneofs=[],
    serialized_start=16,
    serialized_end=51,
)


_PHONERESPONSE = _descriptor.Descriptor(
    name="PhoneResponse",
    full_name="PhoneResponse",
    filename=None,
    file=DESCRIPTOR,
    containing_type=None,
    create_key=_descriptor._internal_create_key,
    fields=[
        _descriptor.FieldDescriptor(
            name="message",
            full_name="PhoneResponse.message",
            index=0,
            number=1,
            type=14,
            cpp_type=8,
            label=1,
            has_default_value=False,
            default_value=0,
            message_type=None,
            enum_type=None,
            containing_type=None,
            is_extension=False,
            extension_scope=None,
            serialized_options=None,
            file=DESCRIPTOR,
            create_key=_descriptor._internal_create_key,
        ),
    ],
    extensions=[],
    nested_types=[],
    enum_types=[],
    serialized_options=None,
    is_extendable=False,
    syntax="proto3",
    extension_ranges=[],
    oneofs=[],
    serialized_start=53,
    serialized_end=96,
)

_PHONERESPONSE.fields_by_name["message"].enum_type = _RESPONSE
DESCRIPTOR.message_types_by_name["PhoneRequest"] = _PHONEREQUEST
DESCRIPTOR.message_types_by_name["PhoneResponse"] = _PHONERESPONSE
DESCRIPTOR.enum_types_by_name["Response"] = _RESPONSE
_sym_db.RegisterFileDescriptor(DESCRIPTOR)

PhoneRequest = _reflection.GeneratedProtocolMessageType(
    "PhoneRequest",
    (_message.Message,),
    {
        "DESCRIPTOR": _PHONEREQUEST,
        "__module__": "server_pb2"
        # @@protoc_insertion_point(class_scope:PhoneRequest)
    },
)
_sym_db.RegisterMessage(PhoneRequest)

PhoneResponse = _reflection.GeneratedProtocolMessageType(
    "PhoneResponse",
    (_message.Message,),
    {
        "DESCRIPTOR": _PHONERESPONSE,
        "__module__": "server_pb2"
        # @@protoc_insertion_point(class_scope:PhoneResponse)
    },
)
_sym_db.RegisterMessage(PhoneResponse)


_PHONEVERIFICATION = _descriptor.ServiceDescriptor(
    name="PhoneVerification",
    full_name="PhoneVerification",
    file=DESCRIPTOR,
    index=0,
    serialized_options=None,
    create_key=_descriptor._internal_create_key,
    serialized_start=136,
    serialized_end=203,
    methods=[
        _descriptor.MethodDescriptor(
            name="VerifyPhone",
            full_name="PhoneVerification.VerifyPhone",
            index=0,
            containing_service=None,
            input_type=_PHONEREQUEST,
            output_type=_PHONERESPONSE,
            serialized_options=None,
            create_key=_descriptor._internal_create_key,
        ),
    ],
)
_sym_db.RegisterServiceDescriptor(_PHONEVERIFICATION)

DESCRIPTOR.services_by_name["PhoneVerification"] = _PHONEVERIFICATION

# @@protoc_insertion_point(module_scope)
