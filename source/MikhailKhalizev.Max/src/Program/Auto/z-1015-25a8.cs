using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_25a8-ca0dcdd7")]
        public void Method_1015_25a8()
        {
            ii(0x1015_25a8, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1015_25ad, 5);  call(Definitions.sys_check_available_stack_size, 0x1_37a0);/* call 0x10165d52 */
            ii(0x1015_25b2, 1);  push(ebx);                            /* push ebx */
            ii(0x1015_25b3, 1);  push(ecx);                            /* push ecx */
            ii(0x1015_25b4, 1);  push(edx);                            /* push edx */
            ii(0x1015_25b5, 1);  push(esi);                            /* push esi */
            ii(0x1015_25b6, 1);  push(edi);                            /* push edi */
            ii(0x1015_25b7, 1);  push(ebp);                            /* push ebp */
            ii(0x1015_25b8, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1015_25ba, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1015_25c0, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1015_25c3, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_25c6, 6);  mov(al, memb[ds, eax + 165]);         /* mov al, [eax+0xa5] */
            ii(0x1015_25cc, 3);  mov(memb[ss, ebp - 8], al);           /* mov [ebp-0x8], al */
            ii(0x1015_25cf, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_25d2, 7);  mov(memb[ds, eax + 165], 0);          /* mov byte [eax+0xa5], 0x0 */
        l_0x1015_25d9:
            ii(0x1015_25d9, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_25dc, 4);  cmp(memb[ds, eax + 61], 0);           /* cmp byte [eax+0x3d], 0x0 */
            ii(0x1015_25e0, 2);  if(jz(0x1015_25f0, 0xe)) goto l_0x1015_25f0;/* jz 0x101525f0 */
            ii(0x1015_25e2, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1015_25e4, 5);  call(0x1010_0efe, -0x5_16eb);         /* call 0x10100efe */
            ii(0x1015_25e9, 5);  call(0x100e_a7e7, -0x6_7e07);         /* call 0x100ea7e7 */
            ii(0x1015_25ee, 2);  jmp(0x1015_25d9, -0x17); goto l_0x1015_25d9;/* jmp 0x101525d9 */
        l_0x1015_25f0:
            ii(0x1015_25f0, 3);  mov(al, memb[ss, ebp - 8]);           /* mov al, [ebp-0x8] */
            ii(0x1015_25f3, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1015_25f6, 6);  mov(memb[ds, edx + 165], al);         /* mov [edx+0xa5], al */
            ii(0x1015_25fc, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1015_25fe, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1015_25ff, 1);  pop(edi);                             /* pop edi */
            ii(0x1015_2600, 1);  pop(esi);                             /* pop esi */
            ii(0x1015_2601, 1);  pop(edx);                             /* pop edx */
            ii(0x1015_2602, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1015_2603, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1015_2604, 1);  ret();                                /* ret */
        }
    }
}
