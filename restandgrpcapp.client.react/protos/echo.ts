// @generated by protobuf-ts 2.9.4 with parameter long_type_string
// @generated from protobuf file "echo.proto" (syntax proto3)
// tslint:disable
import { ServiceType } from "@protobuf-ts/runtime-rpc";
import type { BinaryWriteOptions } from "@protobuf-ts/runtime";
import type { IBinaryWriter } from "@protobuf-ts/runtime";
import { WireType } from "@protobuf-ts/runtime";
import type { BinaryReadOptions } from "@protobuf-ts/runtime";
import type { IBinaryReader } from "@protobuf-ts/runtime";
import { UnknownFieldHandler } from "@protobuf-ts/runtime";
import type { PartialMessage } from "@protobuf-ts/runtime";
import { reflectionMergePartial } from "@protobuf-ts/runtime";
import { MessageType } from "@protobuf-ts/runtime";
/**
 * @generated from protobuf message EchoRequest
 */
export interface EchoRequest {
    /**
     * @generated from protobuf field: string message = 1;
     */
    message: string;
}
/**
 * @generated from protobuf message EchoResponse
 */
export interface EchoResponse {
    /**
     * @generated from protobuf field: string message = 1;
     */
    message: string;
}
// @generated message type with reflection information, may provide speed optimized methods
class EchoRequest$Type extends MessageType<EchoRequest> {
    constructor() {
        super("EchoRequest", [
            { no: 1, name: "message", kind: "scalar", T: 9 /*ScalarType.STRING*/ }
        ]);
    }
    create(value?: PartialMessage<EchoRequest>): EchoRequest {
        const message = globalThis.Object.create((this.messagePrototype!));
        message.message = "";
        if (value !== undefined)
            reflectionMergePartial<EchoRequest>(this, message, value);
        return message;
    }
    internalBinaryRead(reader: IBinaryReader, length: number, options: BinaryReadOptions, target?: EchoRequest): EchoRequest {
        let message = target ?? this.create(), end = reader.pos + length;
        while (reader.pos < end) {
            let [fieldNo, wireType] = reader.tag();
            switch (fieldNo) {
                case /* string message */ 1:
                    message.message = reader.string();
                    break;
                default:
                    let u = options.readUnknownField;
                    if (u === "throw")
                        throw new globalThis.Error(`Unknown field ${fieldNo} (wire type ${wireType}) for ${this.typeName}`);
                    let d = reader.skip(wireType);
                    if (u !== false)
                        (u === true ? UnknownFieldHandler.onRead : u)(this.typeName, message, fieldNo, wireType, d);
            }
        }
        return message;
    }
    internalBinaryWrite(message: EchoRequest, writer: IBinaryWriter, options: BinaryWriteOptions): IBinaryWriter {
        /* string message = 1; */
        if (message.message !== "")
            writer.tag(1, WireType.LengthDelimited).string(message.message);
        let u = options.writeUnknownFields;
        if (u !== false)
            (u == true ? UnknownFieldHandler.onWrite : u)(this.typeName, message, writer);
        return writer;
    }
}
/**
 * @generated MessageType for protobuf message EchoRequest
 */
export const EchoRequest = new EchoRequest$Type();
// @generated message type with reflection information, may provide speed optimized methods
class EchoResponse$Type extends MessageType<EchoResponse> {
    constructor() {
        super("EchoResponse", [
            { no: 1, name: "message", kind: "scalar", T: 9 /*ScalarType.STRING*/ }
        ]);
    }
    create(value?: PartialMessage<EchoResponse>): EchoResponse {
        const message = globalThis.Object.create((this.messagePrototype!));
        message.message = "";
        if (value !== undefined)
            reflectionMergePartial<EchoResponse>(this, message, value);
        return message;
    }
    internalBinaryRead(reader: IBinaryReader, length: number, options: BinaryReadOptions, target?: EchoResponse): EchoResponse {
        let message = target ?? this.create(), end = reader.pos + length;
        while (reader.pos < end) {
            let [fieldNo, wireType] = reader.tag();
            switch (fieldNo) {
                case /* string message */ 1:
                    message.message = reader.string();
                    break;
                default:
                    let u = options.readUnknownField;
                    if (u === "throw")
                        throw new globalThis.Error(`Unknown field ${fieldNo} (wire type ${wireType}) for ${this.typeName}`);
                    let d = reader.skip(wireType);
                    if (u !== false)
                        (u === true ? UnknownFieldHandler.onRead : u)(this.typeName, message, fieldNo, wireType, d);
            }
        }
        return message;
    }
    internalBinaryWrite(message: EchoResponse, writer: IBinaryWriter, options: BinaryWriteOptions): IBinaryWriter {
        /* string message = 1; */
        if (message.message !== "")
            writer.tag(1, WireType.LengthDelimited).string(message.message);
        let u = options.writeUnknownFields;
        if (u !== false)
            (u == true ? UnknownFieldHandler.onWrite : u)(this.typeName, message, writer);
        return writer;
    }
}
/**
 * @generated MessageType for protobuf message EchoResponse
 */
export const EchoResponse = new EchoResponse$Type();
/**
 * @generated ServiceType for protobuf service EchoService
 */
export const EchoService = new ServiceType("EchoService", [
    { name: "Echo", options: {}, I: EchoRequest, O: EchoResponse }
]);
