using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_44ba-a6064421")]
        public void Method_100e_44ba()
        {
            ii(0x100e_44ba, 5); push(0x48);                             /* push 0x48 */
            ii(0x100e_44bf, 5); call(Definitions.sys_check_available_stack_size, 0x8_188e); /* call 0x10165d52 */
            ii(0x100e_44c4, 1); push(ebx);                              /* push ebx */
            ii(0x100e_44c5, 1); push(ecx);                              /* push ecx */
            ii(0x100e_44c6, 1); push(esi);                              /* push esi */
            ii(0x100e_44c7, 1); push(edi);                              /* push edi */
            ii(0x100e_44c8, 1); push(ebp);                              /* push ebp */
            ii(0x100e_44c9, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_44cb, 6); sub(esp, 0x30);                         /* sub esp, 0x30 */
            ii(0x100e_44d1, 3); mov(memb[ss, ebp - 4], al);             /* mov [ebp-0x4], al */
            ii(0x100e_44d4, 3); mov(memd[ss, ebp - 8], edx);            /* mov [ebp-0x8], edx */
            ii(0x100e_44d7, 5); mov(ebx, 0x1c);                         /* mov ebx, 0x1c */
            ii(0x100e_44dc, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_44de, 3); lea(eax, memd[ss, ebp - 48]);           /* lea eax, [ebp-0x30] */
            ii(0x100e_44e1, 5); call(Definitions.sys_memset, 0x8_18fa); /* call 0x10165de0 */
            ii(0x100e_44e6, 5); mov(ebx, 0xc);                          /* mov ebx, 0xc */
            ii(0x100e_44eb, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_44ed, 3); lea(eax, memd[ss, ebp - 20]);           /* lea eax, [ebp-0x14] */
            ii(0x100e_44f0, 5); call(Definitions.sys_memset, 0x8_18eb); /* call 0x10165de0 */
            ii(0x100e_44f5, 6); mov(memw[ss, ebp - 48], 0x300);         /* mov word [ebp-0x30], 0x300 */
            ii(0x100e_44fb, 3); mov(al, memb[ss, ebp - 4]);             /* mov al, [ebp-0x4] */
            ii(0x100e_44fe, 3); mov(memb[ss, ebp - 44], al);            /* mov [ebp-0x2c], al */
            ii(0x100e_4501, 4); mov(memb[ss, ebp - 43], 0);             /* mov byte [ebp-0x2b], 0x0 */
            ii(0x100e_4505, 6); mov(memw[ss, ebp - 40], 0);             /* mov word [ebp-0x28], 0x0 */
            ii(0x100e_450b, 2); mov(eax, ds);                           /* mov eax, ds */
            ii(0x100e_450d, 3); mov(ebx, memd[ss, ebp - 8]);            /* mov ebx, [ebp-0x8] */
            ii(0x100e_4510, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100e_4512, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100e_4514, 4); mov(memw[ss, ebp - 20], dx);            /* mov [ebp-0x14], dx */
            ii(0x100e_4518, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100e_451b, 3); mov(memd[ss, ebp - 28], eax);           /* mov [ebp-0x1c], eax */
            ii(0x100e_451e, 3); lea(ecx, memd[ss, ebp - 20]);           /* lea ecx, [ebp-0x14] */
            ii(0x100e_4521, 3); lea(ebx, memd[ss, ebp - 48]);           /* lea ebx, [ebp-0x30] */
            ii(0x100e_4524, 3); lea(edx, memd[ss, ebp - 48]);           /* lea edx, [ebp-0x30] */
            ii(0x100e_4527, 5); mov(eax, 0x31);                         /* mov eax, 0x31 */
            ii(0x100e_452c, 5); call(/* sys */ 0x1016_c623, 0x8_80f2);  /* call 0x1016c623 */
            ii(0x100e_4531, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_4533, 1); pop(ebp);                               /* pop ebp */
            ii(0x100e_4534, 1); pop(edi);                               /* pop edi */
            ii(0x100e_4535, 1); pop(esi);                               /* pop esi */
            ii(0x100e_4536, 1); pop(ecx);                               /* pop ecx */
            ii(0x100e_4537, 1); pop(ebx);                               /* pop ebx */
            ii(0x100e_4538, 1); ret();                                  /* ret */
        }
    }
}
