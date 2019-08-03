using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("026ffc3b-4090-472a-b76f-1f3fd36d183d")]
        public void /* sys */ Method_1019_5c56()
        {
            ii(0x1019_5c56, 1); pushd(ebx);                             /* push ebx */
            ii(0x1019_5c57, 2); mov(memd_a32[ds, eax], edx);            /* mov [eax], edx */
            ii(0x1019_5c59, 3); mov(ebx, memd_a32[ds, edx + 0x8]);      /* mov ebx, [edx+0x8] */
            ii(0x1019_5c5c, 7); mov(memd_a32[ds, eax + 0x9], 0);        /* mov dword [eax+0x9], 0x0 */
            ii(0x1019_5c63, 3); mov(memd_a32[ds, eax + 0x4], ebx);      /* mov [eax+0x4], ebx */
            ii(0x1019_5c66, 3); mov(ebx, memd_a32[ds, edx + 0x4]);      /* mov ebx, [edx+0x4] */
            ii(0x1019_5c69, 2); mov(ebx, memd_a32[ds, ebx]);            /* mov ebx, [ebx] */
            ii(0x1019_5c6b, 7); mov(ebx, memd_a32[ds, ebx * 4 + 0x1020_a21c]); /* mov ebx, [ebx*4+0x1020a21c] */
            ii(0x1019_5c72, 3); calld_abs(memd_a32[ds, ebx + 0x8]);     /* call dword [ebx+0x8] */
            ii(0x1019_5c75, 1); popd(ebx);                              /* pop ebx */
            ii(0x1019_5c76, 1); retd(); return;                         /* ret */
        }
    }
}
