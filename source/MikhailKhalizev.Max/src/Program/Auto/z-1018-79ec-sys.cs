using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_79ec-90b81beb")]
        public void /* sys */ Method_1018_79ec()
        {
            ii(0x1018_79ec, 3); lea(esi, esi + esi * 2);                /* lea esi, [esi+esi*2] */
            ii(0x1018_79ef, 7); lea(eax, esi + /* sys */ 0x1018_7a92);  /* lea eax, [cs:esi+0x10187a92] */
            ii(0x1018_79f6, 1); pushd(eax);                             /* push eax */
            ii(0x1018_79f7, 2); mov(es, memw_a32[ds, ebx]);             /* mov es, [ebx] */
            ii(0x1018_79f9, 4); mov(bp, memw_a32[ds, ebx + 0x6]);       /* mov bp, [ebx+0x6] */
            ii(0x1018_79fd, 2); mov(eax, memd_a32[ds, edi]);            /* mov eax, [edi] */
            ii(0x1018_79ff, 3); mov(ebx, memd_a32[ds, edi + 0x4]);      /* mov ebx, [edi+0x4] */
            ii(0x1018_7a02, 3); mov(ecx, memd_a32[ds, edi + 0x8]);      /* mov ecx, [edi+0x8] */
            ii(0x1018_7a05, 3); mov(edx, memd_a32[ds, edi + 0xc]);      /* mov edx, [edi+0xc] */
            ii(0x1018_7a08, 3); mov(esi, memd_a32[ds, edi + 0x10]);     /* mov esi, [edi+0x10] */
            ii(0x1018_7a0b, 3); mov(edi, memd_a32[ds, edi + 0x14]);     /* mov edi, [edi+0x14] */
            ii(0x1018_7a0e, 2); mov(ds, ebp);                           /* mov ds, ebp */
            ii(0x1018_7a10, 1); retd();                                 /* ret */
        }
    }
}
