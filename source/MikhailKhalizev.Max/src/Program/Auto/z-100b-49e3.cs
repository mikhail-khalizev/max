using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("51ddce23-38c5-40e8-a529-531e2117198d")]
        public void Method_100b_49e3()
        {
            ii(0x100b_49e3, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x100b_49e8, 5); calld(Definitions.sys_check_available_stack_size, 0xb_1365); /* call 0x10165d52 */
            ii(0x100b_49ed, 1); pushd(ecx);                             /* push ecx */
            ii(0x100b_49ee, 1); pushd(esi);                             /* push esi */
            ii(0x100b_49ef, 1); pushd(edi);                             /* push edi */
            ii(0x100b_49f0, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_49f1, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_49f3, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x100b_49f9, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100b_49fc, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x100b_49ff, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x100b_4a02, 5); mov(ecx, 0x2);                          /* mov ecx, 0x2 */
            ii(0x100b_4a07, 3); mov(ebx, memd_a32[ss, ebp - 0x4]);      /* mov ebx, [ebp-0x4] */
            ii(0x100b_4a0a, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100b_4a0d, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100b_4a10, 5); calld(0x100b_4822, -0x1f3);             /* call 0x100b4822 */
            ii(0x100b_4a15, 2); test(al, al);                           /* test al, al */
            ii(0x100b_4a17, 2); if(jnzd(0x100b_4a30, 0x17)) goto l_0x100b_4a30; /* jnz 0x100b4a30 */
            ii(0x100b_4a19, 5); mov(ecx, 0x1);                          /* mov ecx, 0x1 */
            ii(0x100b_4a1e, 3); mov(ebx, memd_a32[ss, ebp - 0x4]);      /* mov ebx, [ebp-0x4] */
            ii(0x100b_4a21, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100b_4a24, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100b_4a27, 5); calld(0x100b_4822, -0x20a);             /* call 0x100b4822 */
            ii(0x100b_4a2c, 2); test(al, al);                           /* test al, al */
            ii(0x100b_4a2e, 2); if(jzd(0x100b_4a36, 0x6)) goto l_0x100b_4a36; /* jz 0x100b4a36 */
        l_0x100b_4a30:
            ii(0x100b_4a30, 4); mov(memb_a32[ss, ebp - 0x10], 0x1);     /* mov byte [ebp-0x10], 0x1 */
            ii(0x100b_4a34, 2); jmpd(0x100b_4a3a, 0x4); goto l_0x100b_4a3a; /* jmp 0x100b4a3a */
        l_0x100b_4a36:
            ii(0x100b_4a36, 4); mov(memb_a32[ss, ebp - 0x10], 0);       /* mov byte [ebp-0x10], 0x0 */
        l_0x100b_4a3a:
            ii(0x100b_4a3a, 3); mov(al, memb_a32[ss, ebp - 0x10]);      /* mov al, [ebp-0x10] */
            ii(0x100b_4a3d, 3); mov(memb_a32[ss, ebp - 0x14], al);      /* mov [ebp-0x14], al */
            ii(0x100b_4a40, 3); mov(al, memb_a32[ss, ebp - 0x14]);      /* mov al, [ebp-0x14] */
            ii(0x100b_4a43, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_4a45, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_4a46, 1); popd(edi);                              /* pop edi */
            ii(0x100b_4a47, 1); popd(esi);                              /* pop esi */
            ii(0x100b_4a48, 1); popd(ecx);                              /* pop ecx */
            ii(0x100b_4a49, 1); retd(); return;                         /* ret */
        }
    }
}
