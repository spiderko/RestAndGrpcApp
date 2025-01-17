import * as jspb from 'google-protobuf'

import * as google_protobuf_empty_pb from 'google-protobuf/google/protobuf/empty_pb'; // proto import: "google/protobuf/empty.proto"
import * as google_protobuf_timestamp_pb from 'google-protobuf/google/protobuf/timestamp_pb'; // proto import: "google/protobuf/timestamp.proto"
import * as google_protobuf_wrappers_pb from 'google-protobuf/google/protobuf/wrappers_pb'; // proto import: "google/protobuf/wrappers.proto"


export class GrpcWeatherForecasts extends jspb.Message {
  getForecastsList(): Array<GrpcWeatherForecast>;
  setForecastsList(value: Array<GrpcWeatherForecast>): GrpcWeatherForecasts;
  clearForecastsList(): GrpcWeatherForecasts;
  addForecasts(value?: GrpcWeatherForecast, index?: number): GrpcWeatherForecast;

  serializeBinary(): Uint8Array;
  toObject(includeInstance?: boolean): GrpcWeatherForecasts.AsObject;
  static toObject(includeInstance: boolean, msg: GrpcWeatherForecasts): GrpcWeatherForecasts.AsObject;
  static serializeBinaryToWriter(message: GrpcWeatherForecasts, writer: jspb.BinaryWriter): void;
  static deserializeBinary(bytes: Uint8Array): GrpcWeatherForecasts;
  static deserializeBinaryFromReader(message: GrpcWeatherForecasts, reader: jspb.BinaryReader): GrpcWeatherForecasts;
}

export namespace GrpcWeatherForecasts {
  export type AsObject = {
    forecastsList: Array<GrpcWeatherForecast.AsObject>,
  }
}

export class GrpcWeatherForecast extends jspb.Message {
  getDate(): google_protobuf_timestamp_pb.Timestamp | undefined;
  setDate(value?: google_protobuf_timestamp_pb.Timestamp): GrpcWeatherForecast;
  hasDate(): boolean;
  clearDate(): GrpcWeatherForecast;

  getTemperaturec(): number;
  setTemperaturec(value: number): GrpcWeatherForecast;

  getTemperaturef(): number;
  setTemperaturef(value: number): GrpcWeatherForecast;

  getSummary(): google_protobuf_wrappers_pb.StringValue | undefined;
  setSummary(value?: google_protobuf_wrappers_pb.StringValue): GrpcWeatherForecast;
  hasSummary(): boolean;
  clearSummary(): GrpcWeatherForecast;

  serializeBinary(): Uint8Array;
  toObject(includeInstance?: boolean): GrpcWeatherForecast.AsObject;
  static toObject(includeInstance: boolean, msg: GrpcWeatherForecast): GrpcWeatherForecast.AsObject;
  static serializeBinaryToWriter(message: GrpcWeatherForecast, writer: jspb.BinaryWriter): void;
  static deserializeBinary(bytes: Uint8Array): GrpcWeatherForecast;
  static deserializeBinaryFromReader(message: GrpcWeatherForecast, reader: jspb.BinaryReader): GrpcWeatherForecast;
}

export namespace GrpcWeatherForecast {
  export type AsObject = {
    date?: google_protobuf_timestamp_pb.Timestamp.AsObject,
    temperaturec: number,
    temperaturef: number,
    summary?: google_protobuf_wrappers_pb.StringValue.AsObject,
  }
}

export class WeatherForecastRequest extends jspb.Message {
  getQty(): number;
  setQty(value: number): WeatherForecastRequest;

  serializeBinary(): Uint8Array;
  toObject(includeInstance?: boolean): WeatherForecastRequest.AsObject;
  static toObject(includeInstance: boolean, msg: WeatherForecastRequest): WeatherForecastRequest.AsObject;
  static serializeBinaryToWriter(message: WeatherForecastRequest, writer: jspb.BinaryWriter): void;
  static deserializeBinary(bytes: Uint8Array): WeatherForecastRequest;
  static deserializeBinaryFromReader(message: WeatherForecastRequest, reader: jspb.BinaryReader): WeatherForecastRequest;
}

export namespace WeatherForecastRequest {
  export type AsObject = {
    qty: number,
  }
}

