using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_79b4-608d8dca")]
        public void /* sys */ Method_1018_79b4()
        {
            ii(0x1018_79b4, 1); pushd(ebp);                             /* push ebp */
            ii(0x1018_79b5, 1); pushd(es);                              /* push es */
            ii(0x1018_79b6, 1); pushd(ebx);                             /* push ebx */
            ii(0x1018_79b7, 1); pushd(ds);                              /* push ds */
            ii(0x1018_79b8, 1); pushd(edx);                             /* push edx */
            ii(0x1018_79b9, 5); calld(/* sys */ 0x1018_79ec, 0x2e);     /* call 0x101879ec */
            ii(0x1018_79be, 1); pushd(ds);                              /* push ds */
            ii(0x1018_79bf, 1); pushd(edi);                             /* push edi */
            ii(0x1018_79c0, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1018_79c2, 3); mov(edi, memd_a32[ss, ebp + 0x8]);      /* mov edi, [ebp+0x8] */
            ii(0x1018_79c5, 3); mov(ds, memw_a32[ss, ebp + 0xc]);       /* mov ds, [ebp+0xc] */
            ii(0x1018_79c8, 2); mov(memd_a32[ds, edi], eax);            /* mov [edi], eax */
            ii(0x1018_79ca, 3); mov(memd_a32[ds, edi + 0x4], ebx);      /* mov [edi+0x4], ebx */
            ii(0x1018_79cd, 3); mov(memd_a32[ds, edi + 0x8], ecx);      /* mov [edi+0x8], ecx */
            ii(0x1018_79d0, 3); mov(memd_a32[ds, edi + 0xc], edx);      /* mov [edi+0xc], edx */
            ii(0x1018_79d3, 3); mov(memd_a32[ds, edi + 0x10], esi);     /* mov [edi+0x10], esi */
            ii(0x1018_79d6, 3); popd(memd_a32[ds, edi + 0x14]);         /* pop dword [edi+0x14] */
            ii(0x1018_79d9, 2); sbb(eax, eax);                          /* sbb eax, eax */
            ii(0x1018_79db, 3); mov(memd_a32[ds, edi + 0x18], eax);     /* mov [edi+0x18], eax */
            ii(0x1018_79de, 1); popd(eax);                              /* pop eax */
            ii(0x1018_79df, 1); popd(ebx);                              /* pop ebx */
            ii(0x1018_79e0, 1); popd(ebx);                              /* pop ebx */
            ii(0x1018_79e1, 1); popd(ebx);                              /* pop ebx */
            ii(0x1018_79e2, 4); mov(memw_a32[ds, ebx + 0x6], ax);       /* mov [ebx+0x6], ax */
            ii(0x1018_79e6, 3); mov(memw_a32[ds, ebx], es);             /* mov [ebx], es */
            ii(0x1018_79e9, 1); popd(es);                               /* pop es */
            ii(0x1018_79ea, 1); popd(ebp);                              /* pop ebp */
            ii(0x1018_79eb, 1); retd(); return;                         /* ret */
        }
    }
}
