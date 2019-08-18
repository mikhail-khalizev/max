using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("a60d9c0c-e0ac-482c-b5c0-a9f2bc6d34fe")]
        public void Method_100e_4801()
        {
            ii(0x100e_4801, 5); pushd(0x44);                            /* push 0x44 */
            ii(0x100e_4806, 5); calld(Definitions.sys_check_available_stack_size, 0x8_1547); /* call 0x10165d52 */
            ii(0x100e_480b, 1); pushd(ebx);                             /* push ebx */
            ii(0x100e_480c, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_480d, 1); pushd(esi);                             /* push esi */
            ii(0x100e_480e, 1); pushd(edi);                             /* push edi */
            ii(0x100e_480f, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_4810, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_4812, 6); sub(esp, 0x2c);                         /* sub esp, 0x2c */
            ii(0x100e_4818, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100e_481b, 3); mov(memd_a32[ss, ebp - 0x10], edx);     /* mov [ebp-0x10], edx */
            ii(0x100e_481e, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100e_4821, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100e_4824, 5); mov(ebx, 0x1c);                         /* mov ebx, 0x1c */
            ii(0x100e_4829, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_482b, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x100e_482e, 5); calld(Definitions.sys_memset, 0x8_15ad); /* call 0x10165de0 */
            ii(0x100e_4833, 6); mov(memw_a32[ss, ebp - 0x2c], 0x8);     /* mov word [ebp-0x2c], 0x8 */
            ii(0x100e_4839, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_483c, 4); mov(memw_a32[ss, ebp - 0x28], ax);      /* mov [ebp-0x28], ax */
            ii(0x100e_4840, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_4843, 3); shr(eax, 0x10);                         /* shr eax, 0x10 */
            ii(0x100e_4846, 4); mov(memw_a32[ss, ebp - 0x24], ax);      /* mov [ebp-0x24], ax */
            ii(0x100e_484a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_484d, 4); mov(memw_a32[ss, ebp - 0x20], ax);      /* mov [ebp-0x20], ax */
            ii(0x100e_4851, 3); lea(ebx, ebp - 0x2c);                   /* lea ebx, [ebp-0x2c] */
            ii(0x100e_4854, 3); lea(edx, ebp - 0x2c);                   /* lea edx, [ebp-0x2c] */
            ii(0x100e_4857, 5); mov(eax, 0x31);                         /* mov eax, 0x31 */
            ii(0x100e_485c, 5); calld(/* sys */ 0x1016_c606, 0x8_7da5); /* call 0x1016c606 */
            ii(0x100e_4861, 4); cmp(memd_a32[ss, ebp - 0x14], 0);       /* cmp dword [ebp-0x14], 0x0 */
            ii(0x100e_4865, 2); if(jzd(0x100e_4870, 0x9)) goto l_0x100e_4870; /* jz 0x100e4870 */
            ii(0x100e_4867, 7); mov(memd_a32[ss, ebp - 0xc], 0);        /* mov dword [ebp-0xc], 0x0 */
            ii(0x100e_486e, 2); jmpd(0x100e_4877, 0x7); goto l_0x100e_4877; /* jmp 0x100e4877 */
        l_0x100e_4870:
            ii(0x100e_4870, 7); mov(memd_a32[ss, ebp - 0xc], 0x1);      /* mov dword [ebp-0xc], 0x1 */
        l_0x100e_4877:
            ii(0x100e_4877, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_487a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_487c, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_487d, 1); popd(edi);                              /* pop edi */
            ii(0x100e_487e, 1); popd(esi);                              /* pop esi */
            ii(0x100e_487f, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_4880, 1); popd(ebx);                              /* pop ebx */
            ii(0x100e_4881, 1); retd(); return;                         /* ret */
        }
    }
}
