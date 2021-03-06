using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_bffb-cc4b2363")]
        public void Method_100a_bffb()
        {
            ii(0x100a_bffb, 5);  push(0x20);                           /* push 0x20 */
            ii(0x100a_c000, 5);  call(Definitions.sys_check_available_stack_size, 0xb_9d4d);/* call 0x10165d52 */
            ii(0x100a_c005, 1);  push(ebx);                            /* push ebx */
            ii(0x100a_c006, 1);  push(ecx);                            /* push ecx */
            ii(0x100a_c007, 1);  push(edx);                            /* push edx */
            ii(0x100a_c008, 1);  push(esi);                            /* push esi */
            ii(0x100a_c009, 1);  push(edi);                            /* push edi */
            ii(0x100a_c00a, 1);  push(ebp);                            /* push ebp */
            ii(0x100a_c00b, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100a_c00d, 6);  sub(esp, 4);                          /* sub esp, 0x4 */
            ii(0x100a_c013, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100a_c016, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_c019, 3);  add(eax, 0x1a);                       /* add eax, 0x1a */
            ii(0x100a_c01c, 5);  call(0x100b_7e44, 0xbe23);            /* call 0x100b7e44 */
            ii(0x100a_c021, 5);  call(0x100a_bb24, -0x502);            /* call 0x100abb24 */
            ii(0x100a_c026, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100a_c028, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_c02b, 3);  add(eax, 0x1a);                       /* add eax, 0x1a */
            ii(0x100a_c02e, 5);  call(0x100b_7ea0, 0xbe6d);            /* call 0x100b7ea0 */
            ii(0x100a_c033, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100a_c035, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_c038, 3);  add(eax, 6);                          /* add eax, 0x6 */
            ii(0x100a_c03b, 5);  call(0x1007_6630, -0x3_5a10);         /* call 0x10076630 */
            ii(0x100a_c040, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100a_c042, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100a_c043, 1);  pop(edi);                             /* pop edi */
            ii(0x100a_c044, 1);  pop(esi);                             /* pop esi */
            ii(0x100a_c045, 1);  pop(edx);                             /* pop edx */
            ii(0x100a_c046, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100a_c047, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100a_c048, 1);  ret();                                /* ret */
        }
    }
}
