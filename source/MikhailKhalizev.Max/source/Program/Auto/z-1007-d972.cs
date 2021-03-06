using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_d972-2ea6348a")]
        public void Method_1007_d972()
        {
            ii(0x1007_d972, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1007_d977, 5);  call(Definitions.sys_check_available_stack_size, 0xe_83d6);/* call 0x10165d52 */
            ii(0x1007_d97c, 1);  push(ebx);                            /* push ebx */
            ii(0x1007_d97d, 1);  push(ecx);                            /* push ecx */
            ii(0x1007_d97e, 1);  push(edx);                            /* push edx */
            ii(0x1007_d97f, 1);  push(esi);                            /* push esi */
            ii(0x1007_d980, 1);  push(edi);                            /* push edi */
            ii(0x1007_d981, 1);  push(ebp);                            /* push ebp */
            ii(0x1007_d982, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1007_d984, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1007_d98a, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1007_d98d, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_d990, 5);  call(0x1013_a794, 0xb_cdff);          /* call 0x1013a794 */
            ii(0x1007_d995, 3);  lea(edx, memd[ds, eax - 6]);          /* lea edx, [eax-0x6] */
            ii(0x1007_d998, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_d99b, 3);  add(eax, 0xa);                        /* add eax, 0xa */
            ii(0x1007_d99e, 5);  call(0x1008_a4a0, 0xcafd);            /* call 0x1008a4a0 */
            ii(0x1007_d9a3, 1);  cwde();                               /* cwde */
            ii(0x1007_d9a4, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1007_d9a7, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x1007_d9a9, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_d9ac, 3);  add(eax, 0xe);                        /* add eax, 0xe */
            ii(0x1007_d9af, 5);  call(Definitions.my_2_get_count, 0xd9b4);/* call 0x1008b368 */
            ii(0x1007_d9b4, 1);  cwde();                               /* cwde */
            ii(0x1007_d9b5, 2);  add(eax, eax);                        /* add eax, eax */
            ii(0x1007_d9b7, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x1007_d9b9, 3);  mov(memd[ss, ebp - 8], edx);          /* mov [ebp-0x8], edx */
            ii(0x1007_d9bc, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_d9bf, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1007_d9c1, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1007_d9c2, 1);  pop(edi);                             /* pop edi */
            ii(0x1007_d9c3, 1);  pop(esi);                             /* pop esi */
            ii(0x1007_d9c4, 1);  pop(edx);                             /* pop edx */
            ii(0x1007_d9c5, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1007_d9c6, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1007_d9c7, 1);  ret();                                /* ret */
        }
    }
}
