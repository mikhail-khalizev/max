using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_0c7e-c2b5f4ad")]
        public void Method_100d_0c7e()
        {
            ii(0x100d_0c7e, 5);  push(0x20);                           /* push 0x20 */
            ii(0x100d_0c83, 5);  call(Definitions.sys_check_available_stack_size, 0x9_50ca);/* call 0x10165d52 */
            ii(0x100d_0c88, 1);  push(ebx);                            /* push ebx */
            ii(0x100d_0c89, 1);  push(ecx);                            /* push ecx */
            ii(0x100d_0c8a, 1);  push(esi);                            /* push esi */
            ii(0x100d_0c8b, 1);  push(edi);                            /* push edi */
            ii(0x100d_0c8c, 1);  push(ebp);                            /* push ebp */
            ii(0x100d_0c8d, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100d_0c8f, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x100d_0c95, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100d_0c98, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100d_0c9b, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_0c9e, 6);  mov(memw[ds, eax + 38], 0);           /* mov word [eax+0x26], 0x0 */
        l_0x100d_0ca4:
            ii(0x100d_0ca4, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_0ca7, 3);  mov(edx, memd[ds, eax + 36]);         /* mov edx, [eax+0x24] */
            ii(0x100d_0caa, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x100d_0cad, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_0cb0, 3);  add(eax, 0x1e);                       /* add eax, 0x1e */
            ii(0x100d_0cb3, 5);  call(0x1008_b228, -0x4_5a90);         /* call 0x1008b228 */
            ii(0x100d_0cb8, 3);  mov(ax, memw[ds, eax]);               /* mov ax, [eax] */
            ii(0x100d_0cbb, 4);  cmp(ax, memw[ss, ebp - 4]);           /* cmp ax, [ebp-0x4] */
            ii(0x100d_0cbf, 2);  if(jz(0x100d_0cca, 9)) goto l_0x100d_0cca;/* jz 0x100d0cca */
            ii(0x100d_0cc1, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_0cc4, 4);  inc(memw[ds, eax + 38]);              /* inc word [eax+0x26] */
            ii(0x100d_0cc8, 2);  jmp(0x100d_0ca4, -0x26); goto l_0x100d_0ca4;/* jmp 0x100d0ca4 */
        l_0x100d_0cca:
            ii(0x100d_0cca, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_0ccd, 3);  mov(edx, memd[ds, eax + 36]);         /* mov edx, [eax+0x24] */
            ii(0x100d_0cd0, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x100d_0cd3, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_0cd6, 5);  call(0x100d_01a3, -0xb38);            /* call 0x100d01a3 */
            ii(0x100d_0cdb, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100d_0cdd, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100d_0cde, 1);  pop(edi);                             /* pop edi */
            ii(0x100d_0cdf, 1);  pop(esi);                             /* pop esi */
            ii(0x100d_0ce0, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100d_0ce1, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100d_0ce2, 1);  ret();                                /* ret */
        }
    }
}
