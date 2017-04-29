// automatically generated by the FlatBuffers compiler, do not modify

namespace MyGame.Example
{

using global::System;
using global::FlatBuffers;

public struct Vec3 : IFlatbufferObject
{
  private Struct __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
  public Vec3 __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public float X { get { return __p.bb.GetFloat(__p.bb_pos + 0); } }
  public void MutateX(float x) { __p.bb.PutFloat(__p.bb_pos + 0, x); }
  public float Y { get { return __p.bb.GetFloat(__p.bb_pos + 4); } }
  public void MutateY(float y) { __p.bb.PutFloat(__p.bb_pos + 4, y); }
  public float Z { get { return __p.bb.GetFloat(__p.bb_pos + 8); } }
  public void MutateZ(float z) { __p.bb.PutFloat(__p.bb_pos + 8, z); }
  public double Test1 { get { return __p.bb.GetDouble(__p.bb_pos + 16); } }
  public void MutateTest1(double test1) { __p.bb.PutDouble(__p.bb_pos + 16, test1); }
  public Color Test2 { get { return (Color)__p.bb.GetSbyte(__p.bb_pos + 24); } }
  public void MutateTest2(Color test2) { __p.bb.PutSbyte(__p.bb_pos + 24, (sbyte)test2); }
  public Test Test3 { get { return (new Test()).__assign(__p.bb_pos + 26, __p.bb); } }

  public static Offset<Vec3> CreateVec3(FlatBufferBuilder builder, float X, float Y, float Z, double Test1, Color Test2, short test3_A, sbyte test3_B) {
    builder.Prep(16, 32);
    builder.Pad(2);
    builder.Prep(2, 4);
    builder.Pad(1);
    builder.PutSbyte(test3_B);
    builder.PutShort(test3_A);
    builder.Pad(1);
    builder.PutSbyte((sbyte)Test2);
    builder.PutDouble(Test1);
    builder.Pad(4);
    builder.PutFloat(Z);
    builder.PutFloat(Y);
    builder.PutFloat(X);
    return new Offset<Vec3>(builder.Offset);
  }
};


}
