using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("760d333a-28f3-4337-9139-52e47d6b6954")]
        public void Method_1008_7b64()
        {
            ii(0x1008_7b64, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1008_7b69, 5); calld(Definitions.sys_check_available_stack_size, 0xd_e1e4); /* call 0x10165d52 */
            ii(0x1008_7b6e, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_7b6f, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_7b70, 1); pushd(esi);                             /* push esi */
            ii(0x1008_7b71, 1); pushd(edi);                             /* push edi */
            ii(0x1008_7b72, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_7b73, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_7b75, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1008_7b7b, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_7b7e, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1008_7b81, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_7b83, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_7b86, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1008_7b89, 5); calld(0x1013_ad11, 0xb_3183);           /* call 0x1013ad11 */
            ii(0x1008_7b8e, 2); test(al, al);                           /* test al, al */
            ii(0x1008_7b90, 2); if(jnzd(0x1008_7ba9, 0x17)) goto l_0x1008_7ba9; /* jnz 0x10087ba9 */
            ii(0x1008_7b92, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_7b95, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1008_7b98, 5); calld(0x1007_6574, -0x1_1629);          /* call 0x10076574 */
            ii(0x1008_7b9d, 3); mov(al, memb_a32[ds, eax + 0x4d]);      /* mov al, [eax+0x4d] */
            ii(0x1008_7ba0, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1008_7ba5, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1008_7ba7, 2); if(jnzd(0x1008_7bab, 0x2)) goto l_0x1008_7bab; /* jnz 0x10087bab */
        l_0x1008_7ba9:
            ii(0x1008_7ba9, 2); jmpd(0x1008_7bbd, 0x12); goto l_0x1008_7bbd; /* jmp 0x10087bbd */
        l_0x1008_7bab:
            ii(0x1008_7bab, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1008_7bae, 3); add(edx, 0x17);                         /* add edx, 0x17 */
            ii(0x1008_7bb1, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_7bb4, 5); calld(0x1008_b4b4, 0x38fb);             /* call 0x1008b4b4 */
            ii(0x1008_7bb9, 2); test(al, al);                           /* test al, al */
            ii(0x1008_7bbb, 2); if(jzd(0x1008_7bc3, 0x6)) goto l_0x1008_7bc3; /* jz 0x10087bc3 */
        l_0x1008_7bbd:
            ii(0x1008_7bbd, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
            ii(0x1008_7bc1, 2); jmpd(0x1008_7bc7, 0x4); goto l_0x1008_7bc7; /* jmp 0x10087bc7 */
        l_0x1008_7bc3:
            ii(0x1008_7bc3, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
        l_0x1008_7bc7:
            ii(0x1008_7bc7, 3); mov(al, memb_a32[ss, ebp - 0xc]);       /* mov al, [ebp-0xc] */
            ii(0x1008_7bca, 3); mov(memb_a32[ss, ebp - 0x10], al);      /* mov [ebp-0x10], al */
            ii(0x1008_7bcd, 3); mov(al, memb_a32[ss, ebp - 0x10]);      /* mov al, [ebp-0x10] */
            ii(0x1008_7bd0, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_7bd2, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_7bd3, 1); popd(edi);                              /* pop edi */
            ii(0x1008_7bd4, 1); popd(esi);                              /* pop esi */
            ii(0x1008_7bd5, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_7bd6, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_7bd7, 1); retd(); return;                         /* ret */
        }
    }
}