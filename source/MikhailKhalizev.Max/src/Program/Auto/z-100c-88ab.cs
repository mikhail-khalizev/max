using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_88ab-6b0609c4")]
        public void Method_100c_88ab()
        {
            ii(0x100c_88ab, 5);  push(0x28);                           /* push 0x28 */
            ii(0x100c_88b0, 5);  call(Definitions.sys_check_available_stack_size, 0x9_d49d);/* call 0x10165d52 */
            ii(0x100c_88b5, 1);  push(ebx);                            /* push ebx */
            ii(0x100c_88b6, 1);  push(ecx);                            /* push ecx */
            ii(0x100c_88b7, 1);  push(esi);                            /* push esi */
            ii(0x100c_88b8, 1);  push(edi);                            /* push edi */
            ii(0x100c_88b9, 1);  push(ebp);                            /* push ebp */
            ii(0x100c_88ba, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100c_88bc, 6);  sub(esp, 0x10);                       /* sub esp, 0x10 */
            ii(0x100c_88c2, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100c_88c5, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100c_88c8, 5);  mov(ecx, 0x1a00);                     /* mov ecx, 0x1a00 */
            ii(0x100c_88cd, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x100c_88cf, 4);  movsx(edx, memw[ss, ebp - 4]);        /* movsx edx, word [ebp-0x4] */
            ii(0x100c_88d3, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_88d6, 5);  call(0x100a_26d1, -0x2_620a);         /* call 0x100a26d1 */
            ii(0x100c_88db, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100c_88de, 3);  lea(eax, memd[ss, ebp - 8]);          /* lea eax, [ebp-0x8] */
            ii(0x100c_88e1, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x100c_88e4, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_88e7, 7);  mov(memd[ds, eax + 2], 0x101b_5808);  /* mov dword [eax+0x2], 0x101b5808 */
            ii(0x100c_88ee, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_88f1, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x100c_88f4, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100c_88f7, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100c_88f9, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100c_88fa, 1);  pop(edi);                             /* pop edi */
            ii(0x100c_88fb, 1);  pop(esi);                             /* pop esi */
            ii(0x100c_88fc, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100c_88fd, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100c_88fe, 1);  ret();                                /* ret */
        }
    }
}
