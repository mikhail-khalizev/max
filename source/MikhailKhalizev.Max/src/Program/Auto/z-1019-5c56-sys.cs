using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_5c56-e9c32715")]
        public void /* sys */ Method_1019_5c56()
        {
            ii(0x1019_5c56, 1);  push(ebx);                            /* push ebx */
            ii(0x1019_5c57, 2);  mov(memd[ds, eax], edx);              /* mov [eax], edx */
            ii(0x1019_5c59, 3);  mov(ebx, memd[ds, edx + 8]);          /* mov ebx, [edx+0x8] */
            ii(0x1019_5c5c, 7);  mov(memd[ds, eax + 9], 0);            /* mov dword [eax+0x9], 0x0 */
            ii(0x1019_5c63, 3);  mov(memd[ds, eax + 4], ebx);          /* mov [eax+0x4], ebx */
            ii(0x1019_5c66, 3);  mov(ebx, memd[ds, edx + 4]);          /* mov ebx, [edx+0x4] */
            ii(0x1019_5c69, 2);  mov(ebx, memd[ds, ebx]);              /* mov ebx, [ebx] */
            ii(0x1019_5c6b, 7);  mov(ebx, memd[ds, ebx * 4 + 0x1020_a21c]);/* mov ebx, [ebx*4+0x1020a21c] */
            ii(0x1019_5c72, 3);  call_abs(memd[ds, ebx + 8]);          /* call dword [ebx+0x8] */
            ii(0x1019_5c75, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1019_5c76, 1);  ret();                                /* ret */
        }
    }
}
