// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: mysqlx_cursor.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Mysqlx.Cursor {

  /// <summary>Holder for reflection information generated from mysqlx_cursor.proto</summary>
  internal static partial class MysqlxCursorReflection {

    #region Descriptor
    /// <summary>File descriptor for mysqlx_cursor.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MysqlxCursorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChNteXNxbHhfY3Vyc29yLnByb3RvEg1NeXNxbHguQ3Vyc29yGgxteXNxbHgu",
            "cHJvdG8aFG15c3FseF9wcmVwYXJlLnByb3RvIvIBCgRPcGVuEhEKCWN1cnNv",
            "cl9pZBgBIAEoDRIuCgRzdG10GAQgASgLMiAuTXlzcWx4LkN1cnNvci5PcGVu",
            "Lk9uZU9mTWVzc2FnZRISCgpmZXRjaF9yb3dzGAUgASgEGpIBCgxPbmVPZk1l",
            "c3NhZ2USMwoEdHlwZRgBIAEoDjIlLk15c3FseC5DdXJzb3IuT3Blbi5PbmVP",
            "Zk1lc3NhZ2UuVHlwZRIwCg9wcmVwYXJlX2V4ZWN1dGUYAiABKAsyFy5NeXNx",
            "bHguUHJlcGFyZS5FeGVjdXRlIhsKBFR5cGUSEwoPUFJFUEFSRV9FWEVDVVRF",
            "EAAiLgoFRmV0Y2gSEQoJY3Vyc29yX2lkGAEgASgNEhIKCmZldGNoX3Jvd3MY",
            "BSABKAQiGgoFQ2xvc2USEQoJY3Vyc29yX2lkGAEgASgNQhkKF2NvbS5teXNx",
            "bC5jai54LnByb3RvYnVmYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Mysqlx.MysqlxReflection.Descriptor, global::Mysqlx.Prepare.MysqlxPrepareReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Mysqlx.Cursor.Open), global::Mysqlx.Cursor.Open.Parser, new[]{ "CursorId", "Stmt", "FetchRows" }, null, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::Mysqlx.Cursor.Open.Types.OneOfMessage), global::Mysqlx.Cursor.Open.Types.OneOfMessage.Parser, new[]{ "Type", "PrepareExecute" }, null, new[]{ typeof(global::Mysqlx.Cursor.Open.Types.OneOfMessage.Types.Type) }, null)}),
            new pbr::GeneratedClrTypeInfo(typeof(global::Mysqlx.Cursor.Fetch), global::Mysqlx.Cursor.Fetch.Parser, new[]{ "CursorId", "FetchRows" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Mysqlx.Cursor.Close), global::Mysqlx.Cursor.Close.Parser, new[]{ "CursorId" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Open a cursor
  ///
  /// .. uml::
  ///
  ///   client -> server: Open
  ///   alt Success
  ///     ... none or partial Resultsets or full Resultsets ...
  ///     client &lt;- server: StmtExecuteOk
  ///  else Failure
  ///     client &lt;- server: Error
  ///  end
  ///
  /// :param cursor_id: client side assigned cursor id, the ID is going to represent new cursor and assigned to it statement
  /// :param stmt: statement which resultset is going to be iterated through the cursor
  /// :param fetch_rows: number of rows which should be retrieved from sequential cursor
  /// :Returns: :protobuf:msg:`Mysqlx.Ok::`
  /// </summary>
  internal sealed partial class Open : pb::IMessage<Open> {
    private static readonly pb::MessageParser<Open> _parser = new pb::MessageParser<Open>(() => new Open());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Open> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Mysqlx.Cursor.MysqlxCursorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Open() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Open(Open other) : this() {
      cursorId_ = other.cursorId_;
      stmt_ = other.stmt_ != null ? other.stmt_.Clone() : null;
      fetchRows_ = other.fetchRows_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Open Clone() {
      return new Open(this);
    }

    /// <summary>Field number for the "cursor_id" field.</summary>
    public const int CursorIdFieldNumber = 1;
    private uint cursorId_;
    /// <summary>
    ///required
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint CursorId {
      get { return cursorId_; }
      set {
        cursorId_ = value;
      }
    }

    /// <summary>Field number for the "stmt" field.</summary>
    public const int StmtFieldNumber = 4;
    private global::Mysqlx.Cursor.Open.Types.OneOfMessage stmt_;
    /// <summary>
    ///required
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Mysqlx.Cursor.Open.Types.OneOfMessage Stmt {
      get { return stmt_; }
      set {
        stmt_ = value;
      }
    }

    /// <summary>Field number for the "fetch_rows" field.</summary>
    public const int FetchRowsFieldNumber = 5;
    private ulong fetchRows_;
    /// <summary>
    ///optional
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong FetchRows {
      get { return fetchRows_; }
      set {
        fetchRows_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Open);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Open other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (CursorId != other.CursorId) return false;
      if (!object.Equals(Stmt, other.Stmt)) return false;
      if (FetchRows != other.FetchRows) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (CursorId != 0) hash ^= CursorId.GetHashCode();
      if (stmt_ != null) hash ^= Stmt.GetHashCode();
      if (FetchRows != 0UL) hash ^= FetchRows.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (CursorId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(CursorId);
      }
      if (stmt_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(Stmt);
      }
      if (FetchRows != 0UL) {
        output.WriteRawTag(40);
        output.WriteUInt64(FetchRows);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (CursorId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CursorId);
      }
      if (stmt_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Stmt);
      }
      if (FetchRows != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(FetchRows);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Open other) {
      if (other == null) {
        return;
      }
      if (other.CursorId != 0) {
        CursorId = other.CursorId;
      }
      if (other.stmt_ != null) {
        if (stmt_ == null) {
          stmt_ = new global::Mysqlx.Cursor.Open.Types.OneOfMessage();
        }
        Stmt.MergeFrom(other.Stmt);
      }
      if (other.FetchRows != 0UL) {
        FetchRows = other.FetchRows;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            CursorId = input.ReadUInt32();
            break;
          }
          case 34: {
            if (stmt_ == null) {
              stmt_ = new global::Mysqlx.Cursor.Open.Types.OneOfMessage();
            }
            input.ReadMessage(stmt_);
            break;
          }
          case 40: {
            FetchRows = input.ReadUInt64();
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the Open message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    internal static partial class Types {
      internal sealed partial class OneOfMessage : pb::IMessage<OneOfMessage> {
        private static readonly pb::MessageParser<OneOfMessage> _parser = new pb::MessageParser<OneOfMessage>(() => new OneOfMessage());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<OneOfMessage> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::Mysqlx.Cursor.Open.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public OneOfMessage() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public OneOfMessage(OneOfMessage other) : this() {
          type_ = other.type_;
          prepareExecute_ = other.prepareExecute_ != null ? other.prepareExecute_.Clone() : null;
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public OneOfMessage Clone() {
          return new OneOfMessage(this);
        }

        /// <summary>Field number for the "type" field.</summary>
        public const int TypeFieldNumber = 1;
        private global::Mysqlx.Cursor.Open.Types.OneOfMessage.Types.Type type_ = 0;
        /// <summary>
        ///required
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public global::Mysqlx.Cursor.Open.Types.OneOfMessage.Types.Type Type {
          get { return type_; }
          set {
            type_ = value;
          }
        }

        /// <summary>Field number for the "prepare_execute" field.</summary>
        public const int PrepareExecuteFieldNumber = 2;
        private global::Mysqlx.Prepare.Execute prepareExecute_;
        /// <summary>
        ///optional
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public global::Mysqlx.Prepare.Execute PrepareExecute {
          get { return prepareExecute_; }
          set {
            prepareExecute_ = value;
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other) {
          return Equals(other as OneOfMessage);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(OneOfMessage other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (Type != other.Type) return false;
          if (!object.Equals(PrepareExecute, other.PrepareExecute)) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode() {
          int hash = 1;
          if (Type != 0) hash ^= Type.GetHashCode();
          if (prepareExecute_ != null) hash ^= PrepareExecute.GetHashCode();
          if (_unknownFields != null) {
            hash ^= _unknownFields.GetHashCode();
          }
          return hash;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override string ToString() {
          return pb::JsonFormatter.ToDiagnosticString(this);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void WriteTo(pb::CodedOutputStream output) {
          if (Type != 0) {
            output.WriteRawTag(8);
            output.WriteEnum((int) Type);
          }
          if (prepareExecute_ != null) {
            output.WriteRawTag(18);
            output.WriteMessage(PrepareExecute);
          }
          if (_unknownFields != null) {
            _unknownFields.WriteTo(output);
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize() {
          int size = 0;
          if (Type != 0) {
            size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Type);
          }
          if (prepareExecute_ != null) {
            size += 1 + pb::CodedOutputStream.ComputeMessageSize(PrepareExecute);
          }
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(OneOfMessage other) {
          if (other == null) {
            return;
          }
          if (other.Type != 0) {
            Type = other.Type;
          }
          if (other.prepareExecute_ != null) {
            if (prepareExecute_ == null) {
              prepareExecute_ = new global::Mysqlx.Prepare.Execute();
            }
            PrepareExecute.MergeFrom(other.PrepareExecute);
          }
          _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(pb::CodedInputStream input) {
          uint tag;
          while ((tag = input.ReadTag()) != 0) {
            switch(tag) {
              default:
                _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
                break;
              case 8: {
                type_ = (global::Mysqlx.Cursor.Open.Types.OneOfMessage.Types.Type) input.ReadEnum();
                break;
              }
              case 18: {
                if (prepareExecute_ == null) {
                  prepareExecute_ = new global::Mysqlx.Prepare.Execute();
                }
                input.ReadMessage(prepareExecute_);
                break;
              }
            }
          }
        }

        #region Nested types
        /// <summary>Container for nested types declared in the OneOfMessage message type.</summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        internal static partial class Types {
          internal enum Type {
            [pbr::OriginalName("PREPARE_EXECUTE")] PrepareExecute = 0,
          }

        }
        #endregion

      }

    }
    #endregion

  }

  /// <summary>
  /// Fetch next portion of data from a cursor
  ///
  /// .. uml::
  ///
  ///   client -> server: Fetch
  ///   alt Success
  ///     ... none or partial Resultsets or full Resultsets ...
  ///     client &lt;- server: StmtExecuteOk
  ///   else
  ///    client &lt;- server: Error
  ///   end
  ///
  /// :param cursor_id: client side assigned cursor id, must be already open
  /// :param fetch_rows: number of rows which should be retrieved from sequential cursor
  /// </summary>
  internal sealed partial class Fetch : pb::IMessage<Fetch> {
    private static readonly pb::MessageParser<Fetch> _parser = new pb::MessageParser<Fetch>(() => new Fetch());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Fetch> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Mysqlx.Cursor.MysqlxCursorReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Fetch() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Fetch(Fetch other) : this() {
      cursorId_ = other.cursorId_;
      fetchRows_ = other.fetchRows_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Fetch Clone() {
      return new Fetch(this);
    }

    /// <summary>Field number for the "cursor_id" field.</summary>
    public const int CursorIdFieldNumber = 1;
    private uint cursorId_;
    /// <summary>
    ///required
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint CursorId {
      get { return cursorId_; }
      set {
        cursorId_ = value;
      }
    }

    /// <summary>Field number for the "fetch_rows" field.</summary>
    public const int FetchRowsFieldNumber = 5;
    private ulong fetchRows_;
    /// <summary>
    ///optional
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong FetchRows {
      get { return fetchRows_; }
      set {
        fetchRows_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Fetch);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Fetch other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (CursorId != other.CursorId) return false;
      if (FetchRows != other.FetchRows) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (CursorId != 0) hash ^= CursorId.GetHashCode();
      if (FetchRows != 0UL) hash ^= FetchRows.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (CursorId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(CursorId);
      }
      if (FetchRows != 0UL) {
        output.WriteRawTag(40);
        output.WriteUInt64(FetchRows);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (CursorId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CursorId);
      }
      if (FetchRows != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(FetchRows);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Fetch other) {
      if (other == null) {
        return;
      }
      if (other.CursorId != 0) {
        CursorId = other.CursorId;
      }
      if (other.FetchRows != 0UL) {
        FetchRows = other.FetchRows;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            CursorId = input.ReadUInt32();
            break;
          }
          case 40: {
            FetchRows = input.ReadUInt64();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// Close cursor
  ///
  /// .. uml::
  ///
  ///   client -> server: Close
  ///   alt Success
  ///     client &lt;- server: Ok
  ///   else Failure
  ///     client &lt;- server: Error
  ///   end
  ///
  /// :param cursor_id: client side assigned cursor id, must be allocated/open
  /// :Returns: :protobuf:msg:`Mysqlx.Ok|Mysqlx.Error`
  /// </summary>
  internal sealed partial class Close : pb::IMessage<Close> {
    private static readonly pb::MessageParser<Close> _parser = new pb::MessageParser<Close>(() => new Close());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Close> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Mysqlx.Cursor.MysqlxCursorReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Close() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Close(Close other) : this() {
      cursorId_ = other.cursorId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Close Clone() {
      return new Close(this);
    }

    /// <summary>Field number for the "cursor_id" field.</summary>
    public const int CursorIdFieldNumber = 1;
    private uint cursorId_;
    /// <summary>
    ///required
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint CursorId {
      get { return cursorId_; }
      set {
        cursorId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Close);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Close other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (CursorId != other.CursorId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (CursorId != 0) hash ^= CursorId.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (CursorId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(CursorId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (CursorId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CursorId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Close other) {
      if (other == null) {
        return;
      }
      if (other.CursorId != 0) {
        CursorId = other.CursorId;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            CursorId = input.ReadUInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code