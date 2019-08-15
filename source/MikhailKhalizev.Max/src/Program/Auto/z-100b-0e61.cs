using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("ea078298-f2f3-44d1-93ac-c5a7a6ce1d6d")]
        public void Method_100b_0e61()
        {
            ii(0x100b_0e61, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x100b_0e66, 5); calld(Definitions.sys_check_available_stack_size, 0xb_4ee7); /* call 0x10165d52 */
            ii(0x100b_0e6b, 1); pushd(ebx);                             /* push ebx */
            ii(0x100b_0e6c, 1); pushd(ecx);                             /* push ecx */
            ii(0x100b_0e6d, 1); pushd(edx);                             /* push edx */
            ii(0x100b_0e6e, 1); pushd(esi);                             /* push esi */
            ii(0x100b_0e6f, 1); pushd(edi);                             /* push edi */
            ii(0x100b_0e70, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_0e71, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_0e73, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100b_0e79, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100b_0e7c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_0e7e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_0e81, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x100b_0e84, 5); calld(0x1013_ad11, 0x8_9e88);           /* call 0x1013ad11 */
            ii(0x100b_0e89, 2); test(al, al);                           /* test al, al */
            ii(0x100b_0e8b, 2); if(jzd(0x100b_0e9d, 0x10)) goto l_0x100b_0e9d; /* jz 0x100b0e9d */
            ii(0x100b_0e8d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_0e90, 3); add(eax, 0x19);                         /* add eax, 0x19 */
            ii(0x100b_0e93, 5); calld(0x1007_6b90, -0x3_a308);          /* call 0x10076b90 */
            ii(0x100b_0e98, 1); cwde();                                 /* cwde */
            ii(0x100b_0e99, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_0e9b, 2); if(jgd(0x100b_0e9f, 0x2)) goto l_0x100b_0e9f; /* jg 0x100b0e9f */
        l_0x100b_0e9d:
            ii(0x100b_0e9d, 2); jmpd(0x100b_0ea5, 0x6); goto l_0x100b_0ea5; /* jmp 0x100b0ea5 */
        l_0x100b_0e9f:
            ii(0x100b_0e9f, 4); mov(memb_a32[ss, ebp - 0x8], 0x1);      /* mov byte [ebp-0x8], 0x1 */
            ii(0x100b_0ea3, 2); jmpd(0x100b_0ea9, 0x4); goto l_0x100b_0ea9; /* jmp 0x100b0ea9 */
        l_0x100b_0ea5:
            ii(0x100b_0ea5, 4); mov(memb_a32[ss, ebp - 0x8], 0);        /* mov byte [ebp-0x8], 0x0 */
        l_0x100b_0ea9:
            ii(0x100b_0ea9, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x100b_0eac, 3); mov(memb_a32[ss, ebp - 0xc], al);       /* mov [ebp-0xc], al */
            ii(0x100b_0eaf, 3); mov(al, memb_a32[ss, ebp - 0xc]);       /* mov al, [ebp-0xc] */
            ii(0x100b_0eb2, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_0eb4, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_0eb5, 1); popd(edi);                              /* pop edi */
            ii(0x100b_0eb6, 1); popd(esi);                              /* pop esi */
            ii(0x100b_0eb7, 1); popd(edx);                              /* pop edx */
            ii(0x100b_0eb8, 1); popd(ecx);                              /* pop ecx */
            ii(0x100b_0eb9, 1); popd(ebx);                              /* pop ebx */
            ii(0x100b_0eba, 1); retd(); return;                         /* ret */
        }
    }
}
