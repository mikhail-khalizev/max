using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_89b0-92c3fe30")]
        public void Method_1010_89b0()
        {
            ii(0x1010_89b0, 5);  push(0x2c);                           /* push 0x2c */
            ii(0x1010_89b5, 5);  call(Definitions.sys_check_available_stack_size, 0x5_d398);/* call 0x10165d52 */
            ii(0x1010_89ba, 1);  push(ecx);                            /* push ecx */
            ii(0x1010_89bb, 1);  push(esi);                            /* push esi */
            ii(0x1010_89bc, 1);  push(edi);                            /* push edi */
            ii(0x1010_89bd, 1);  push(ebp);                            /* push ebp */
            ii(0x1010_89be, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1010_89c0, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1010_89c6, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1010_89c9, 3);  mov(memd[ss, ebp - 8], edx);          /* mov [ebp-0x8], edx */
            ii(0x1010_89cc, 3);  mov(memd[ss, ebp - 4], ebx);          /* mov [ebp-0x4], ebx */
            ii(0x1010_89cf, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_89d2, 1);  push(eax);                            /* push eax */
            ii(0x1010_89d3, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_89d6, 3);  push(memd[ds, eax + 12]);             /* push dword [eax+0xc] */
            ii(0x1010_89d9, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_89dc, 3);  push(memd[ds, eax + 8]);              /* push dword [eax+0x8] */
            ii(0x1010_89df, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_89e2, 3);  mov(ecx, memd[ds, eax + 4]);          /* mov ecx, [eax+0x4] */
            ii(0x1010_89e5, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_89e8, 2);  mov(ebx, memd[ds, eax]);              /* mov ebx, [eax] */
            ii(0x1010_89ea, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1010_89ed, 3);  mov(edx, memd[ds, eax + 14]);         /* mov edx, [eax+0xe] */
            ii(0x1010_89f0, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1010_89f3, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1010_89f6, 3);  mov(eax, memd[ds, eax + 22]);         /* mov eax, [eax+0x16] */
            ii(0x1010_89f9, 5);  call(/* sys */ 0x1016_a68c, 0x6_1c8e);/* call 0x1016a68c */
            ii(0x1010_89fe, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1010_8a00, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1010_8a01, 1);  pop(edi);                             /* pop edi */
            ii(0x1010_8a02, 1);  pop(esi);                             /* pop esi */
            ii(0x1010_8a03, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1010_8a04, 1);  ret();                                /* ret */
        }
    }
}
