using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_44ba-a6064421")]
        public void Method_100e_44ba()
        {
            ii(0x100e_44ba, 5); pushd(0x48);                            /* push 0x48 */
            ii(0x100e_44bf, 5); calld(Definitions.sys_check_available_stack_size, 0x8_188e); /* call 0x10165d52 */
            ii(0x100e_44c4, 1); pushd(ebx);                             /* push ebx */
            ii(0x100e_44c5, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_44c6, 1); pushd(esi);                             /* push esi */
            ii(0x100e_44c7, 1); pushd(edi);                             /* push edi */
            ii(0x100e_44c8, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_44c9, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_44cb, 6); sub(esp, 0x30);                         /* sub esp, 0x30 */
            ii(0x100e_44d1, 3); mov(memb_a32[ss, ebp - 0x4], al);       /* mov [ebp-0x4], al */
            ii(0x100e_44d4, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x100e_44d7, 5); mov(ebx, 0x1c);                         /* mov ebx, 0x1c */
            ii(0x100e_44dc, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_44de, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x100e_44e1, 5); calld(Definitions.sys_memset, 0x8_18fa); /* call 0x10165de0 */
            ii(0x100e_44e6, 5); mov(ebx, 0xc);                          /* mov ebx, 0xc */
            ii(0x100e_44eb, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_44ed, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100e_44f0, 5); calld(Definitions.sys_memset, 0x8_18eb); /* call 0x10165de0 */
            ii(0x100e_44f5, 6); mov(memw_a32[ss, ebp - 0x30], 0x300);   /* mov word [ebp-0x30], 0x300 */
            ii(0x100e_44fb, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x100e_44fe, 3); mov(memb_a32[ss, ebp - 0x2c], al);      /* mov [ebp-0x2c], al */
            ii(0x100e_4501, 4); mov(memb_a32[ss, ebp - 0x2b], 0);       /* mov byte [ebp-0x2b], 0x0 */
            ii(0x100e_4505, 6); mov(memw_a32[ss, ebp - 0x28], 0);       /* mov word [ebp-0x28], 0x0 */
            ii(0x100e_450b, 2); mov(eax, ds);                           /* mov eax, ds */
            ii(0x100e_450d, 3); mov(ebx, memd_a32[ss, ebp - 0x8]);      /* mov ebx, [ebp-0x8] */
            ii(0x100e_4510, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100e_4512, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100e_4514, 4); mov(memw_a32[ss, ebp - 0x14], dx);      /* mov [ebp-0x14], dx */
            ii(0x100e_4518, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_451b, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x100e_451e, 3); lea(ecx, ebp - 0x14);                   /* lea ecx, [ebp-0x14] */
            ii(0x100e_4521, 3); lea(ebx, ebp - 0x30);                   /* lea ebx, [ebp-0x30] */
            ii(0x100e_4524, 3); lea(edx, ebp - 0x30);                   /* lea edx, [ebp-0x30] */
            ii(0x100e_4527, 5); mov(eax, 0x31);                         /* mov eax, 0x31 */
            ii(0x100e_452c, 5); calld(/* sys */ 0x1016_c623, 0x8_80f2); /* call 0x1016c623 */
            ii(0x100e_4531, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_4533, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_4534, 1); popd(edi);                              /* pop edi */
            ii(0x100e_4535, 1); popd(esi);                              /* pop esi */
            ii(0x100e_4536, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_4537, 1); popd(ebx);                              /* pop ebx */
            ii(0x100e_4538, 1); retd();                                 /* ret */
        }
    }
}
