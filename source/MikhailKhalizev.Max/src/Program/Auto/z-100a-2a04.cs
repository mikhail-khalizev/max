using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("3052a33e-8e0a-4292-8cad-89f83142b30c")]
        public void Method_100a_2a04()
        {
            ii(0x100a_2a04, 5); pushd(0x34);                            /* push 0x34 */
            ii(0x100a_2a09, 5); calld(Definitions.sys_check_available_stack_size, 0xc3344); /* call 0x10165d52 */
            ii(0x100a_2a0e, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_2a0f, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_2a10, 1); pushd(esi);                             /* push esi */
            ii(0x100a_2a11, 1); pushd(edi);                             /* push edi */
            ii(0x100a_2a12, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_2a13, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_2a15, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x100a_2a1b, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_2a1e, 3); mov(memb_a32[ss, ebp - 0x4], dl);       /* mov [ebp-0x4], dl */
            ii(0x100a_2a21, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_2a24, 5); calld(0x1008_acf8, -0x17d31);           /* call 0x1008acf8 */
            ii(0x100a_2a29, 2); test(al, al);                           /* test al, al */
            ii(0x100a_2a2b, 2); if(jnzd(0x100a_2a7a, 0x4d)) goto l_0x100a_2a7a; /* jnz 0x100a2a7a */
            ii(0x100a_2a2d, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100a_2a2f, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x100a_2a32, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100a_2a35, 5); mov(eax, 0xa);                          /* mov eax, 0xa */
            ii(0x100a_2a3a, 5); calld(Definitions.sys_new, 0xc33c1);    /* call 0x10165e00 */
            ii(0x100a_2a3f, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100a_2a42, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100a_2a45, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100a_2a48, 4); cmp(memd_a32[ss, ebp - 0x14], 0);       /* cmp dword [ebp-0x14], 0x0 */
            ii(0x100a_2a4c, 2); if(jzd(0x100a_2a64, 0x16)) goto l_0x100a_2a64; /* jz 0x100a2a64 */
            ii(0x100a_2a4e, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100a_2a51, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100a_2a54, 5); calld(0x100a_3711, 0xcb8);              /* call 0x100a3711 */
            ii(0x100a_2a59, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x100a_2a5c, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100a_2a5f, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x100a_2a62, 2); jmpd(0x100a_2a6a, 0x6); goto l_0x100a_2a6a; /* jmp 0x100a2a6a */
        l_0x100a_2a64:
            ii(0x100a_2a64, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100a_2a67, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
        l_0x100a_2a6a:
            ii(0x100a_2a6a, 3); mov(edx, memd_a32[ss, ebp - 0x1c]);     /* mov edx, [ebp-0x1c] */
            ii(0x100a_2a6d, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100a_2a72, 3); mov(ebx, memd_a32[ss, ebp - 0xc]);      /* mov ebx, [ebp-0xc] */
            ii(0x100a_2a75, 5); calld(0x100a_4db6, 0x233c);             /* call 0x100a4db6 */
        l_0x100a_2a7a:
            ii(0x100a_2a7a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_2a7c, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_2a7d, 1); popd(edi);                              /* pop edi */
            ii(0x100a_2a7e, 1); popd(esi);                              /* pop esi */
            ii(0x100a_2a7f, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_2a80, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_2a81, 1); retd(); return;                         /* ret */
        }
    }
}