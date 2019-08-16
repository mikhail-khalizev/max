using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("91f9a71f-8560-4696-815a-5adde15db346")]
        public void Method_1015_2a52()
        {
            ii(0x1015_2a52, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1015_2a57, 5); calld(Definitions.sys_check_available_stack_size, 0x1_32f6); /* call 0x10165d52 */
            ii(0x1015_2a5c, 1); pushd(ebx);                             /* push ebx */
            ii(0x1015_2a5d, 1); pushd(ecx);                             /* push ecx */
            ii(0x1015_2a5e, 1); pushd(esi);                             /* push esi */
            ii(0x1015_2a5f, 1); pushd(edi);                             /* push edi */
            ii(0x1015_2a60, 1); pushd(ebp);                             /* push ebp */
            ii(0x1015_2a61, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_2a63, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1015_2a69, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1015_2a6c, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1015_2a6f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_2a72, 5); calld(0x100a_2edb, -0xa_fb9c);          /* call 0x100a2edb */
            ii(0x1015_2a77, 2); test(al, al);                           /* test al, al */
            ii(0x1015_2a79, 2); if(jnzd(0x1015_2a81, 0x6)) goto l_0x1015_2a81; /* jnz 0x10152a81 */
            ii(0x1015_2a7b, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
            ii(0x1015_2a7f, 2); jmpd(0x1015_2a9e, 0x1d); goto l_0x1015_2a9e; /* jmp 0x10152a9e */
        l_0x1015_2a81:
            ii(0x1015_2a81, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_2a84, 5); calld(0x1015_26ac, -0x3dd);             /* call 0x101526ac */
            ii(0x1015_2a89, 3); cmp(eax, memd_a32[ss, ebp - 0x4]);      /* cmp eax, [ebp-0x4] */
            ii(0x1015_2a8c, 2); if(jnzd(0x1015_2a94, 0x6)) goto l_0x1015_2a94; /* jnz 0x10152a94 */
            ii(0x1015_2a8e, 4); mov(memb_a32[ss, ebp - 0x10], 0x1);     /* mov byte [ebp-0x10], 0x1 */
            ii(0x1015_2a92, 2); jmpd(0x1015_2a98, 0x4); goto l_0x1015_2a98; /* jmp 0x10152a98 */
        l_0x1015_2a94:
            ii(0x1015_2a94, 4); mov(memb_a32[ss, ebp - 0x10], 0);       /* mov byte [ebp-0x10], 0x0 */
        l_0x1015_2a98:
            ii(0x1015_2a98, 3); mov(al, memb_a32[ss, ebp - 0x10]);      /* mov al, [ebp-0x10] */
            ii(0x1015_2a9b, 3); mov(memb_a32[ss, ebp - 0xc], al);       /* mov [ebp-0xc], al */
        l_0x1015_2a9e:
            ii(0x1015_2a9e, 3); mov(al, memb_a32[ss, ebp - 0xc]);       /* mov al, [ebp-0xc] */
            ii(0x1015_2aa1, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_2aa3, 1); popd(ebp);                              /* pop ebp */
            ii(0x1015_2aa4, 1); popd(edi);                              /* pop edi */
            ii(0x1015_2aa5, 1); popd(esi);                              /* pop esi */
            ii(0x1015_2aa6, 1); popd(ecx);                              /* pop ecx */
            ii(0x1015_2aa7, 1); popd(ebx);                              /* pop ebx */
            ii(0x1015_2aa8, 1); retd(); return;                         /* ret */
        }
    }
}