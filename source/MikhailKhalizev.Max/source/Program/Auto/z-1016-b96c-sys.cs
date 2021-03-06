using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_b96c-ef03bf72")]
        public void /* sys */ Method_1016_b96c()
        {
            ii(0x1016_b96c, 1);  push(ebx);                            /* push ebx */
            ii(0x1016_b96d, 1);  push(ecx);                            /* push ecx */
            ii(0x1016_b96e, 1);  push(edx);                            /* push edx */
            ii(0x1016_b96f, 1);  push(esi);                            /* push esi */
            ii(0x1016_b970, 6);  mov(edx, memd[ds, 0x101b_de60]);      /* mov edx, [0x101bde60] */
            ii(0x1016_b976, 2);  test(edx, edx);                       /* test edx, edx */
            ii(0x1016_b978, 2);  if(jz(0x1016_b981, 7)) goto l_0x1016_b981;/* jz 0x1016b981 */
            ii(0x1016_b97a, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x1016_b97c, 5);  call(Definitions.sys_free_internal, 0x1_6ad3);/* call 0x10182454 */
        l_0x1016_b981:
            ii(0x1016_b981, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x1016_b983, 6);  mov(ecx, memd[ds, 0x101b_de68]);      /* mov ecx, [0x101bde68] */
            ii(0x1016_b989, 6);  mov(memd[ds, 0x101b_de60], ebx);      /* mov [0x101bde60], ebx */
            ii(0x1016_b98f, 2);  test(ecx, ecx);                       /* test ecx, ecx */
            ii(0x1016_b991, 2);  if(jz(0x1016_b99d, 0xa)) goto l_0x1016_b99d;/* jz 0x1016b99d */
            ii(0x1016_b993, 5);  mov(eax, /* sys */ 0x1016_bc4c);      /* mov eax, 0x1016bc4c */
            ii(0x1016_b998, 5);  call(/* sys */ 0x1016_b42c, -0x571);  /* call 0x1016b42c */
        l_0x1016_b99d:
            ii(0x1016_b99d, 2);  xor(esi, esi);                        /* xor esi, esi */
            ii(0x1016_b99f, 6);  mov(memd[ds, 0x101b_de68], esi);      /* mov [0x101bde68], esi */
            ii(0x1016_b9a5, 1);  pop(esi);                             /* pop esi */
            ii(0x1016_b9a6, 1);  pop(edx);                             /* pop edx */
            ii(0x1016_b9a7, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1016_b9a8, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1016_b9a9, 1);  ret();                                /* ret */
        }
    }
}
