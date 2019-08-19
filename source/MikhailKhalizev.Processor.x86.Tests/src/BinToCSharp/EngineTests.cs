using System.Linq;
using FluentAssertions;
using MikhailKhalizev.Processor.x86.BinToCSharp;
using MikhailKhalizev.Processor.x86.BinToCSharp.MethodInfo;
using MikhailKhalizev.Processor.x86.Configuration;
using SharpDisasm;
using Xunit;

namespace MikhailKhalizev.Processor.x86.Tests.BinToCSharp
{
    public class EngineTests
    {
        [Fact]
        public void DecodeMethodWithCallInsideInstruction()
        {
            // Перекодирование метода с "метка '*' делит инструкцию пополам".

            var mi = new MethodInfoDto();
            mi.Id = "0x545d-1c5d531f";
            mi.CsBase = 0x35f0;
            mi.Address = 0x545d;
            mi.Mode = ArchitectureMode.x86_16;
            mi.Raw = "e81600f024e81100e221e80c00b33fe80700743fe80200be395b2e8b0f8b1efa0a4343891efa0a8f07688f3eff2ef20affe18bdc5756368b7f04833e120a00755ce87300d1e89183c70f83e7f08bc7c1e8048b1e100a8cca2bda2bd803c2fc8706100a33f68ed88ec2f3a5161f53e8500059c1e1030e07b8cccc8bdff3ab83c30fc1eb04031eb609a1ec0c2bd8891e5a008ec0b44acd215e5f585c5dc3";
            
            var engine = new Engine(
                new BinToCSharpDto(), 
                new DefinitionCollection(), 
                new InMemoryMethodInfoCollection());

            engine.Memory = new MemoryFromMethodInfo(mi);
            engine.CsBase = mi.CsBase;
            engine.Mode = mi.Mode;
                            
            engine.SuppressDecode.Add(0, mi.Address);
            engine.SuppressDecode.Add(mi.Address + mi.RawBytes.Length, 0);
                            
            engine.DecodeMethod(mi.Address);
            engine.DetectMethods();

            var method = engine.NewDetectedMethods.First(x => x.Begin == mi.Address);
            method.End.Should().Be(0x5474);
        }

        [Fact]
        public void DecodeMethodWithCodeAfterJmp()
        {
            var mi = new MethodInfoDto();
            mi.Id = "0x18_a4be-dbd0b47";
            mi.CsBase = 0x18_9b20;
            mi.Address = 0x18_a4be;
            mi.Mode = ArchitectureMode.x86_16;
            mi.Raw = "a1140025080074d88b46108bc80bc97c0441a3700e89670e8e16280c8b26500f803e2e0000743583ec2a89670a061e166a18ff770a5153eaf21018008b1e96098e57028b670e8e46068b7f088b770aff7404b91500fcf3a559e352c3fe068211ff7706ff7708510e68110aff36260c68b247cb";

            var engine = new Engine(
                new BinToCSharpDto(), 
                new DefinitionCollection(), 
                new InMemoryMethodInfoCollection());

            engine.Memory = new MemoryFromMethodInfo(mi);
            engine.CsBase = mi.CsBase;
            engine.Mode = mi.Mode;
                            
            engine.SuppressDecode.Add(0, mi.Address);
            engine.SuppressDecode.Add(mi.Address + mi.RawBytes.Length, 0);
                            
            engine.DecodeMethod(mi.Address);
            engine.DetectMethods();

            var method = engine.NewDetectedMethods.First(x => x.Begin == mi.Address);

            method.MethodInfo.Id.Should().Be(mi.Id);
            method.End.Should().Be(mi.Address + mi.Raw.Length / 2);
            method.Instructions.Should().Contain(x => x.Begin == 0x18_a4fa)
                .Which.CommentThis.Should().BeFalse();
        }
    }
}