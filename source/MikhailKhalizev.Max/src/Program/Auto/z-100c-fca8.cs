using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_fca8-7368cc19")]
        public void Method_100c_fca8()
        {
            ii(0x100c_fca8, 5);  push(0x28);                           /* push 0x28 */
            ii(0x100c_fcad, 5);  call(Definitions.sys_check_available_stack_size, 0x9_60a0);/* call 0x10165d52 */
            ii(0x100c_fcb2, 1);  push(ebx);                            /* push ebx */
            ii(0x100c_fcb3, 1);  push(ecx);                            /* push ecx */
            ii(0x100c_fcb4, 1);  push(esi);                            /* push esi */
            ii(0x100c_fcb5, 1);  push(edi);                            /* push edi */
            ii(0x100c_fcb6, 1);  push(ebp);                            /* push ebp */
            ii(0x100c_fcb7, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100c_fcb9, 6);  sub(esp, 0x10);                       /* sub esp, 0x10 */
            ii(0x100c_fcbf, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100c_fcc2, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100c_fcc5, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_fcc8, 5);  call(0x1009_caf8, -0x3_31d5);         /* call 0x1009caf8 */
            ii(0x100c_fccd, 3);  lea(edx, memd[ss, ebp - 12]);         /* lea edx, [ebp-0xc] */
            ii(0x100c_fcd0, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_fcd3, 5);  call(0x1013_bb7b, 0x6_bea3);          /* call 0x1013bb7b */
        l_0x100c_fcd8:
            ii(0x100c_fcd8, 3);  dec(memd[ss, ebp - 12]);              /* dec dword [ebp-0xc] */
            ii(0x100c_fcdb, 5);  cmp(memw[ss, ebp - 12], -1 /* 0xff */);/* cmp word [ebp-0xc], 0xffff */
            ii(0x100c_fce0, 2);  if(jz(0x100c_fcff, 0x1d)) goto l_0x100c_fcff;/* jz 0x100cfcff */
            ii(0x100c_fce2, 5);  mov(ebx, 2);                          /* mov ebx, 0x2 */
            ii(0x100c_fce7, 3);  lea(edx, memd[ss, ebp - 16]);         /* lea edx, [ebp-0x10] */
            ii(0x100c_fcea, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_fced, 5);  call(0x1013_ba86, 0x6_bd94);          /* call 0x1013ba86 */
            ii(0x100c_fcf2, 3);  lea(edx, memd[ss, ebp - 16]);         /* lea edx, [ebp-0x10] */
            ii(0x100c_fcf5, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_fcf8, 5);  call(0x1008_b2a8, -0x4_4a55);         /* call 0x1008b2a8 */
            ii(0x100c_fcfd, 2);  jmp(0x100c_fcd8, -0x27); goto l_0x100c_fcd8;/* jmp 0x100cfcd8 */
        l_0x100c_fcff:
            ii(0x100c_fcff, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100c_fd01, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100c_fd02, 1);  pop(edi);                             /* pop edi */
            ii(0x100c_fd03, 1);  pop(esi);                             /* pop esi */
            ii(0x100c_fd04, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100c_fd05, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100c_fd06, 1);  ret();                                /* ret */
        }
    }
}
