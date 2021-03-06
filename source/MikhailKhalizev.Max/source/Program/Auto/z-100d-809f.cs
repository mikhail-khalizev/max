using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_809f-f0a4b8f3")]
        public void Method_100d_809f()
        {
            ii(0x100d_809f, 5);  push(0x38);                           /* push 0x38 */
            ii(0x100d_80a4, 5);  call(Definitions.sys_check_available_stack_size, 0x8_dca9);/* call 0x10165d52 */
            ii(0x100d_80a9, 1);  push(esi);                            /* push esi */
            ii(0x100d_80aa, 1);  push(edi);                            /* push edi */
            ii(0x100d_80ab, 1);  push(ebp);                            /* push ebp */
            ii(0x100d_80ac, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100d_80ae, 6);  sub(esp, 0x10);                       /* sub esp, 0x10 */
            ii(0x100d_80b4, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x100d_80b7, 3);  mov(memd[ss, ebp - 12], edx);         /* mov [ebp-0xc], edx */
            ii(0x100d_80ba, 3);  mov(memd[ss, ebp - 8], ebx);          /* mov [ebp-0x8], ebx */
            ii(0x100d_80bd, 3);  mov(memd[ss, ebp - 4], ecx);          /* mov [ebp-0x4], ecx */
            ii(0x100d_80c0, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100d_80c3, 3);  mov(eax, memd[ds, eax + 14]);         /* mov eax, [eax+0xe] */
            ii(0x100d_80c6, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100d_80c9, 1);  push(eax);                            /* push eax */
            ii(0x100d_80ca, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100d_80cd, 3);  mov(eax, memd[ds, eax + 14]);         /* mov eax, [eax+0xe] */
            ii(0x100d_80d0, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100d_80d3, 4);  movsx(edx, memw[ss, ebp - 4]);        /* movsx edx, word [ebp-0x4] */
            ii(0x100d_80d7, 3);  imul(edx, eax);                       /* imul edx, eax */
            ii(0x100d_80da, 2);  mov(ebx, edx);                        /* mov ebx, edx */
            ii(0x100d_80dc, 4);  movsx(edx, memw[ss, ebp - 8]);        /* movsx edx, word [ebp-0x8] */
            ii(0x100d_80e0, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100d_80e3, 3);  mov(eax, memd[ds, eax + 22]);         /* mov eax, [eax+0x16] */
            ii(0x100d_80e6, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x100d_80e8, 2);  add(eax, ebx);                        /* add eax, ebx */
            ii(0x100d_80ea, 1);  push(eax);                            /* push eax */
            ii(0x100d_80eb, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100d_80ee, 3);  mov(eax, memd[ds, eax + 6]);          /* mov eax, [eax+0x6] */
            ii(0x100d_80f1, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100d_80f4, 1);  push(eax);                            /* push eax */
            ii(0x100d_80f5, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100d_80f8, 3);  mov(eax, memd[ds, eax + 8]);          /* mov eax, [eax+0x8] */
            ii(0x100d_80fb, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100d_80fe, 1);  push(eax);                            /* push eax */
            ii(0x100d_80ff, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100d_8102, 3);  mov(eax, memd[ds, eax + 6]);          /* mov eax, [eax+0x6] */
            ii(0x100d_8105, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100d_8108, 1);  push(eax);                            /* push eax */
            ii(0x100d_8109, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100d_810c, 2);  push(memd[ds, eax]);                  /* push dword [eax] */
            ii(0x100d_810e, 5);  call(/* sys */ 0x1016_abbc, 0x9_2aa9);/* call 0x1016abbc */
            ii(0x100d_8113, 3);  add(esp, 0x18);                       /* add esp, 0x18 */
            ii(0x100d_8116, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100d_8118, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100d_8119, 1);  pop(edi);                             /* pop edi */
            ii(0x100d_811a, 1);  pop(esi);                             /* pop esi */
            ii(0x100d_811b, 1);  ret();                                /* ret */
        }
    }
}
