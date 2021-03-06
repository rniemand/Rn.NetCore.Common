﻿using System.IO;

namespace Rn.NetCore.Common.Abstractions
{
  public interface IPathAbstraction
  {
    string GetExtension(string path);
    string GetDirectoryName(string path);
    string GetFileName(string path);
    string GetTempFileName();
    string GetTempPath();
  }

  public class PathAbstraction : IPathAbstraction
  {
    public string GetExtension(string path)
      => Path.GetExtension(path);

    public string GetDirectoryName(string path)
      => Path.GetDirectoryName(path);

    public string GetFileName(string path)
      => Path.GetFileName(path);

    public string GetTempFileName()
      => Path.GetTempFileName();

    public string GetTempPath()
      => Path.GetTempPath();
  }
}
