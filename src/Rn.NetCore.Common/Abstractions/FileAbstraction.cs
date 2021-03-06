﻿using System.IO;
using System.Text;
using System.Threading.Tasks;
using Rn.NetCore.Common.Wrappers;

namespace Rn.NetCore.Common.Abstractions
{
  public interface IFileAbstraction
  {
    bool Exists(string path);
    void Delete(string path);
    string ReadAllText(string path);
    void WriteAllText(string path, string contents);
    void WriteAllText(string path, string contents, Encoding encoding);
    void Copy(string sourceFileName, string destFileName);
    void Move(string sourceFileName, string destFileName);
    void WriteAllBytes(string path, byte[] bytes);
    Task WriteAllBytesAsync(string path, byte[] bytes);
    IFileInfo GetFileInfo(string fileName);
  }

  public class FileAbstraction : IFileAbstraction
  {
    public bool Exists(string path)
      => File.Exists(path);

    public void Delete(string path)
      => File.Delete(path);

    public string ReadAllText(string path)
      => File.ReadAllText(path);

    public void WriteAllText(string path, string contents)
      => File.WriteAllText(path, contents);

    public void WriteAllText(string path, string contents, Encoding encoding)
      => File.WriteAllText(path, contents, encoding);

    public void Copy(string sourceFileName, string destFileName)
      => File.Copy(sourceFileName, destFileName);

    public void Move(string sourceFileName, string destFileName)
      => File.Move(sourceFileName, destFileName);

    public void WriteAllBytes(string path, byte[] bytes)
      => File.WriteAllBytes(path, bytes);

    public async Task WriteAllBytesAsync(string path, byte[] bytes)
      => await File.WriteAllBytesAsync(path, bytes);

    public IFileInfo GetFileInfo(string fileName)
      => new FileInfoWrapper(new FileInfo(fileName));
  }
}
